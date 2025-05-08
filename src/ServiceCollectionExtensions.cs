using CssInCSharp;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddCssInCSharp(this IServiceCollection builder)
        {
            builder.AddScoped<StyleService>();
            return builder;
        }
    }
}
