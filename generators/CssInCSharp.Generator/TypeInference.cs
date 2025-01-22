using CssInCSharp.Generator.Extensions;
using RulesEngine.Actions;
using RulesEngine.Models;

namespace CssInCSharp.Generator
{
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

        public static string Infer(object token, string defaultValue)
        {
            if (_engine == null) return defaultValue;
            var ruleName = string.Empty;
            try
            {
                var results = _engine.ExecuteAllRulesAsync("TypeInference", token).GetAwaiter().GetResult();
                if (results != null)
                {
                    foreach (var result in results)
                    {
                        ruleName = result.Rule.RuleName;
                        if (result.IsSuccess)
                        {
                            // If there are multiple matching results, the first one is used.
                            return result.ActionResult.Output.ToString()!.ToType();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new TypeInferenceException(ruleName, ex.Message);
            }
            return defaultValue;
        }
    }
}
