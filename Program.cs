using System.Drawing;
using System.Text;
using Spectre.Console;
using VsCodeThemeGenerator;

Configuration.Luminosities = [0.95, 0.90, 0.80, 0.70, 0.60, 0.50, 0.40, 0.30, 0.20, 0.10];
Configuration.Colors = new Dictionary<string, string>
{
    { "primary", "#8625D2" },
    { "secondary", "#FF508F" },
    { "tertiary", "#8625D2" },
    { "white", "#FFFFFF" },
    { "black", "#1A191F" },
    { "gray", "#5F5E61" },
    { "success", "#89DD13" },
    { "warning", "#FFCD25" },
    { "danger", "#FF413A" },
    { "category-frontend", "#DD0031" },
    { "category-backend", "#11D15E" },
    { "category-mobile", "#FF8C00" },
    { "category-data", "#FCDB04" },
    { "category-cloud", "#008DF1" },
    { "category-devops", "#0060F1" },
    { "category-fullstack", "#8625D2" }
};

var vsThemeJsonFile = "";
var outputJsonFile = $"";

Dictionary<string, string> colors = [];
foreach (var color in Configuration.Colors)
{
    var scale = ColorUtil.GenerateColorScale(color.Value);
    foreach (var item in scale)
    {
        Console.ForegroundColor
            = ConsoleColor.Blue;
        Console.Write("HI");
        Console.ForegroundColor
            = ConsoleColor.White;
        Console.WriteLine($"CKey: {color.Key} - CVal: {color.Value} - SKey: {item.Key} - SVal: {scale.Values}");

    }
}

AnsiConsole.Markup("[underline red]Hello[/] World!");

Console.Clear();
foreach (var color in colors)
    Console.WriteLine($"{color.Key} -> {color.Value}");

var result = new StringBuilder();
using var sr = new StreamReader(vsThemeJsonFile);
while (sr.ReadLine() is { } line)
{
    var currentColor = ColorUtil.ExtractHexColorFromString(line);
    if (currentColor is not null)
    {
        var color = ColorTranslator.FromHtml(currentColor);
        var analysis = ColorUtil.AnalyzeColor(color);
        Console.WriteLine($"{currentColor} -> {analysis}");
        // var themeColor = ColorUtil.FindClosestColor(currentColor, colors);
        // Console.WriteLine($"{currentColor} -> {themeColor}");
        // line = line.Replace(currentColor, themeColor);
    }

    result.Append(line + Environment.NewLine);
}
using var sw = new StreamWriter(outputJsonFile);
sw.Write(result.ToString());