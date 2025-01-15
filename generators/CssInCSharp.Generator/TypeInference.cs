using System.Text.RegularExpressions;
using CssInCSharp.Generator.Extensions;
using RulesEngine.Actions;
using RulesEngine.Models;

namespace CssInCSharp.Generator
{
    public class Token
    {
        public string? Kind { get; set; }
        public string? Identifier { get; set; }
        public string? MethodName { get; set; }
        public string? NamePrefix { get; set; }
        public string? DefaultValue { get; set; }

        public string ParseDefaultType()
        {
            if (double.TryParse(DefaultValue, out _))
            {
                return "double";
            }

            if (bool.TryParse(DefaultValue, out _))
            {
                return "bool";
            }

            if (Regex.IsMatch(DefaultValue, @"^""\w*""$"))
            {
                return "string";
            }

            return "object";
        }
    }

    public static class InferenceEngine
    {
        private static RulesEngine.RulesEngine? _engine;

        public static void Initialize(List<Rule> rules)
        {
            if (rules.Count <= 0) return;
            var workflows = new Workflow[]
            {
                new Workflow()
                {
                    WorkflowName = "TypeInference",
                    Rules = rules
                }
            };
            var reSettings = new ReSettings();
            reSettings.CustomActions = new Dictionary<string, Func<ActionBase>>()
            {
            };

            _engine = new RulesEngine.RulesEngine(workflows, reSettings);
        }

        public static string Infer(Token token, string defaultValue = "object")
        {
            if (_engine == null) return defaultValue;
            var results = _engine.ExecuteAllRulesAsync("TypeInference", token).GetAwaiter().GetResult();
            if (results != null)
            {
                foreach (var result in results)
                {
                    if (result.IsSuccess)
                    {
                        // If there are multiple matching results, the first one is used.
                        return result.ActionResult.Output.ToString()!.ToType();
                    }
                }
            }

            return defaultValue;
        }
    }
}
