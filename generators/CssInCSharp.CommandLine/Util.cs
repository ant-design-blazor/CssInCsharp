using Microsoft.Extensions.FileSystemGlobbing;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.Text.RegularExpressions;
using AutoMapper;
using CssInCSharp.Generator;

namespace CssInCSharp.CommandLine;

public static class Util
{
    public static readonly IMapper Mapper = new MapperConfiguration(cfg =>
    {
        cfg.CreateMap<CSharpOptions, CSharpOptions>()
            .ForMember(x => x.Usings, opt =>
            {
                opt.PreCondition((src, dest, srcMember) => src.Usings is { Count: > 0 });
            })
            .ForMember(x => x.Replacements, opt =>
            {
                opt.PreCondition((src, dest, srcMember) => src.Replacements is { Count: > 0 });
            });
    }).CreateMapper();

    public static async Task WriteAllTextAsync(string path, string content)
    {
        var destDir = Path.GetDirectoryName(path);
        if (!Directory.Exists(destDir))
        {
            Directory.CreateDirectory(destDir);
        }
        await File.WriteAllTextAsync(path, content);
    }

    public static IEnumerable<MatchFile> GetFiles(string path)
    {
        path = Path.GetFullPath(path);
        var dir = "";
        var pattern = "";
        var index = path.IndexOf("*");
        if (index > 0)
        {
            dir = path.Substring(0, index);
            pattern = path.Substring(index);
        }
        else
        {
            dir = Path.GetDirectoryName(path);
            pattern = path.Substring(dir.Length + 1);
        }
        var matcher = new Matcher();
        matcher.AddInclude(pattern);
        return matcher.GetResultsInFullPath(dir).Select(x => new MatchFile
        {
            Dir = dir,
            Pattern = pattern,
            FullPath = x
        });
    }

    public static string GetDest(string dir, string file, string dest, string ext)
    {
        if (!string.IsNullOrEmpty(dest) && !IsFolder(dest)) return Path.GetFullPath(dest);
        dest = Path.GetFullPath(dest ?? dir);
        var destFile = Path.Combine(dest, file.Substring(dir.Length));
        var destFolder = Path.GetDirectoryName(destFile);
        var destFileName = Path.GetFileNameWithoutExtension(destFile);
        return Path.Combine(destFolder, destFileName + ext);
    }

    public static bool IsFolder(string path)
    {
        try
        {
            var attr = File.GetAttributes(path);
            return (attr & FileAttributes.Directory) == FileAttributes.Directory;
        }
        catch (Exception e)
        {
            return false;
        }
    }

    public static string PurifyFileName(string fileName)
    {
        // remove "-"
        return Regex.Replace(fileName, @"-(\w)", match => match.Groups[1].Value.ToUpper());
    }

    public static string ToJson<T>(this T obj)
    {
        var settings = new JsonSerializerOptions
        {
            WriteIndented = true
        };
        settings.Converters.Add(new JsonStringEnumConverter(JsonNamingPolicy.CamelCase));
        return JsonSerializer.Serialize(obj, settings);
    }

    public static T? FromJson<T>(this string json)
    {
        var settings = new JsonSerializerOptions();
        settings.Converters.Add(new JsonStringEnumConverter(JsonNamingPolicy.CamelCase));
        return JsonSerializer.Deserialize<T>(json, settings);
    }
}

public class MatchFile : IEquatable<MatchFile>
{
    public string Dir { get; set; } = default!;
    public string Pattern { get; set; } = default!;
    public string FullPath { get; set; } = default!;

    public bool Equals(MatchFile? other)
    {
        if (other == null) return false;
        return FullPath == other.FullPath;
    }

    public override bool Equals(object? obj)
    {
        return Equals(obj as MatchFile);
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(FullPath);
    }
}
