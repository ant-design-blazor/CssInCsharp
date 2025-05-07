using Microsoft.AspNetCore.Components.Rendering;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CssInCSharp
{
    internal sealed class StyleRegistry
    {
        private readonly Dictionary<object, StyleSection> _subscribersByIdentifier = new Dictionary<object, StyleSection>();
        private readonly Dictionary<object, List<StyleSectionContent>> _providersByIdentifier = new Dictionary<object, List<StyleSectionContent>>();

        public void AddProvider(object identifier, StyleSectionContent provider, bool isDefaultProvider)
        {
            if (!_providersByIdentifier.TryGetValue(identifier, out var providers))
            {
                providers = new();
                _providersByIdentifier.Add(identifier, providers);
            }

            if (isDefaultProvider)
            {
                providers.Insert(0, provider);
            }
            else
            {
                providers.Add(provider);
            }
        }

        public void RemoveProvider(object identifier, StyleSectionContent provider)
        {
            if (!_providersByIdentifier.TryGetValue(identifier, out var providers))
            {
                throw new InvalidOperationException($"There are no content providers with the given section ID '{identifier}'.");
            }

            var index = providers.LastIndexOf(provider);

            if (index < 0)
            {
                throw new InvalidOperationException($"The provider was not found in the providers list of the given section ID '{identifier}'.");
            }

            providers.RemoveAt(index);

            if (index == providers.Count)
            {
                // We just removed the most recently added provider, meaning we need to change
                // the current content to that of second most recently added provider.
                var contentProvider = GetCurrentProviderContentOrDefault(providers);
                NotifyContentChangedForSubscriber(identifier, contentProvider);
            }
        }

        public void Subscribe(object identifier, StyleSection subscriber)
        {
            if (_subscribersByIdentifier.ContainsKey(identifier))
            {
                throw new InvalidOperationException($"There is already a subscriber to the content with the given section ID '{identifier}'.");
            }

            // Notify the new subscriber with any existing content.
            var provider = GetCurrentProviderContentOrDefault(identifier);
            subscriber.ContentUpdated(provider);

            _subscribersByIdentifier.Add(identifier, subscriber);
        }

        public void Unsubscribe(object identifier)
        {
            if (!_subscribersByIdentifier.Remove(identifier))
            {
                throw new InvalidOperationException($"The subscriber with the given section ID '{identifier}' is already unsubscribed.");
            }
        }

        public void NotifyContentProviderChanged(object identifier, StyleSectionContent provider)
        {
            if (!_providersByIdentifier.TryGetValue(identifier, out var providers))
            {
                throw new InvalidOperationException($"There are no content providers with the given section ID '{identifier}'.");
            }

            // We only notify content changed for subscribers when the content of the
            // most recently added provider changes.
            if (providers.Count != 0 && providers[^1] == provider)
            {
                NotifyContentChangedForSubscriber(identifier, provider);
            }
        }

        private static StyleSectionContent? GetCurrentProviderContentOrDefault(List<StyleSectionContent> providers)
            => providers.Count != 0
                ? providers[^1]
                : null;

        public StyleSectionContent? GetCurrentProviderContentOrDefault(object identifier)
            => _providersByIdentifier.TryGetValue(identifier, out var existingList)
                ? GetCurrentProviderContentOrDefault(existingList)
                : null;

        private void NotifyContentChangedForSubscriber(object identifier, StyleSectionContent? provider)
        {
            if (_subscribersByIdentifier.TryGetValue(identifier, out var subscriber))
            {
                subscriber.ContentUpdated(provider);
            }
        }
    }

    internal class StyleSection : IComponent, IDisposable
    {
        private static readonly RenderFragment _emptyRenderFragment = _ => { };
        private object? _subscribedIdentifier;
        private RenderHandle _renderHandle;
        private StyleSectionContent? _currentContentProvider;
        private StyleRegistry _registry = default!;

        [Parameter] public string? SectionName { get; set; }

        [Parameter] public object? SectionId { get; set; }

        internal IComponent? CurrentLogicalParent => _currentContentProvider;

        public void Attach(RenderHandle renderHandle)
        {
            _renderHandle = renderHandle;
            _registry = StyleHelper.StyleRegistry;
        }

        public Task SetParametersAsync(ParameterView parameters)
        {
            parameters.SetParameterProperties(this);
            object? identifier;

            if (SectionName is not null && SectionId is not null)
            {
                throw new InvalidOperationException($"{nameof(StyleSection)} requires that '{nameof(SectionName)}' and '{nameof(SectionId)}' cannot both have non-null values.");
            }
            else if (SectionName is not null)
            {
                identifier = SectionName;
            }
            else if (SectionId is not null)
            {
                identifier = SectionId;
            }
            else
            {
                throw new InvalidOperationException($"{nameof(StyleSection)} requires a non-null value either for '{nameof(SectionName)}' or '{nameof(SectionId)}'.");
            }

            if (!object.Equals(identifier, _subscribedIdentifier))
            {
                if (_subscribedIdentifier is not null)
                {
                    _registry.Unsubscribe(_subscribedIdentifier);
                }

                _registry.Subscribe(identifier, this);
                _subscribedIdentifier = identifier;
            }

            RenderContent();

            return Task.CompletedTask;
        }

        internal void ContentUpdated(StyleSectionContent? provider)
        {
            _currentContentProvider = provider;
            RenderContent();
        }

        private void RenderContent()
        {
            if (!_renderHandle.IsInitialized)
            {
                return;
            }

            _renderHandle.Render(BuildRenderTree);
        }

        private void BuildRenderTree(RenderTreeBuilder builder)
        {
            var fragment = _currentContentProvider?.ChildContent ?? _emptyRenderFragment;

            builder.OpenComponent<StyleSectionContentRenderer>(0);
            builder.SetKey(fragment);
            builder.AddComponentParameter(1, StyleSectionContentRenderer.ContentParameterName, fragment);
            builder.CloseComponent();
        }

        public void Dispose()
        {
            if (_subscribedIdentifier is not null)
            {
                _registry.Unsubscribe(_subscribedIdentifier);
            }
        }

        internal sealed class StyleSectionContentRenderer : IComponent
        {
            public const string ContentParameterName = "content";

            private RenderHandle _renderHandle;

            public void Attach(RenderHandle renderHandle)
            {
                _renderHandle = renderHandle;
            }

            public Task SetParametersAsync(ParameterView parameters)
            {
                var fragment = parameters.GetValueOrDefault<RenderFragment>(ContentParameterName)!;
                _renderHandle.Render(fragment);
                return Task.CompletedTask;
            }
        }
    }

    internal class StyleSectionContent : IComponent, IDisposable
    {
        private object? _registeredIdentifier;
        private bool? _registeredIsDefaultContent;
        private StyleRegistry _registry = default!;

        [Parameter] public string? SectionName { get; set; }
        [Parameter] public object? SectionId { get; set; }
        internal bool IsDefaultContent { get; set; }
        [Parameter] public RenderFragment? ChildContent { get; set; }

        void IComponent.Attach(RenderHandle renderHandle)
        {
            _registry = StyleHelper.StyleRegistry;
        }

        Task IComponent.SetParametersAsync(ParameterView parameters)
        {
            // We are not using parameters.SetParameterProperties(this)
            // because IsDefaultContent is internal property and not a parameter
            SetParameterValues(parameters);

            object? identifier;

            if (SectionName is not null && SectionId is not null)
            {
                throw new InvalidOperationException($"{nameof(StyleSectionContent)} requires that '{nameof(SectionName)}' and '{nameof(SectionId)}' cannot both have non-null values.");
            }
            else if (SectionName is not null)
            {
                identifier = SectionName;
            }
            else if (SectionId is not null)
            {
                identifier = SectionId;
            }
            else
            {
                throw new InvalidOperationException($"{nameof(StyleSectionContent)} requires a non-null value either for '{nameof(SectionName)}' or '{nameof(SectionId)}'.");
            }

            if (!object.Equals(identifier, _registeredIdentifier) || IsDefaultContent != _registeredIsDefaultContent)
            {
                if (_registeredIdentifier is not null)
                {
                    _registry.RemoveProvider(_registeredIdentifier, this);
                }

                _registry.AddProvider(identifier, this, IsDefaultContent);
                _registeredIdentifier = identifier;
                _registeredIsDefaultContent = IsDefaultContent;
            }

            _registry.NotifyContentProviderChanged(identifier, this);

            return Task.CompletedTask;
        }

        private void SetParameterValues(in ParameterView parameters)
        {
            foreach (var param in parameters)
            {
                switch (param.Name)
                {
                    case nameof(StyleSectionContent.SectionName):
                        SectionName = (string)param.Value;
                        break;
                    case nameof(StyleSectionContent.SectionId):
                        SectionId = param.Value;
                        break;
                    case nameof(StyleSectionContent.IsDefaultContent):
                        IsDefaultContent = (bool)param.Value;
                        break;
                    case nameof(StyleSectionContent.ChildContent):
                        ChildContent = (RenderFragment)param.Value;
                        break;
                    default:
                        throw new ArgumentException($"Unknown parameter '{param.Name}'");
                }
            }
        }

        public void Dispose()
        {
            if (_registeredIdentifier is not null)
            {
                _registry.RemoveProvider(_registeredIdentifier, this);
            }
        }
    }
}
