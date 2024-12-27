using System.CommandLine;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CssInCSharp.CommandLine
{
    internal class InitCommand : Command
    {
        public InitCommand() : base("init", "Init an empty configuration file.")
        {
            var configOption = new Option<string>(
                aliases: ["--config", "-c"],
                description: "Specify the configuration file.",
                getDefaultValue: () => "cssincs.json");
            this.Add(configOption);
            this.SetHandler(ExecAsync, configOption);
        }

        public async Task ExecAsync(string configFile)
        {
            configFile = Path.GetFullPath(configFile);
            // create an empty configuration.
            if (File.Exists(configFile))
            {
                Console.WriteLine("The cssincs.json file already exists.");
                return;
            }

            var config = new Configuration();
            config.AddIncludeItem("./src/**/*.ts", "./dest");
            var settings = new JsonSerializerOptions
            {
                WriteIndented = true
            };
            settings.Converters.Add(new JsonStringEnumConverter(JsonNamingPolicy.CamelCase));
            var json = JsonSerializer.Serialize(config, settings);
            await Util.WriteAllTextAsync(configFile, json);
        }
    }
}
