using System.Drawing;
using System.Text.RegularExpressions;

namespace VsCodeThemeGenerator;

public static class ColorUtil
{
    public static Dictionary<int, string> GenerateColorScale(string hexColor)
    {
        // Converte a cor hexadecimal para um objeto Color
        var baseColor = ColorTranslator.FromHtml(hexColor);

        // Dicionário para armazenar a escala de cores
        var colorScale = new Dictionary<int, string>();


        for (var i = 0; i < Configuration.Luminosities.Length; i++)
        {
            // Calcula a nova cor com base na luminosidade ajustada
            var newColor = AdjustBrightness(baseColor, Configuration.Luminosities[i]);
            // Adiciona a cor ao dicionário
            colorScale.Add(50 + i * 50, ColorTranslator.ToHtml(newColor));
        }

        return colorScale;
    }

    private static Color AdjustBrightness(Color color, double factor)
    {
        var r = (int)(color.R * factor);
        var g = (int)(color.G * factor);
        var b = (int)(color.B * factor);

        // Garante que os valores de RGB permaneçam dentro dos limites válidos
        r = Math.Min(Math.Max(r, 0), 255);
        g = Math.Min(Math.Max(g, 0), 255);
        b = Math.Min(Math.Max(b, 0), 255);

        return Color.FromArgb(r, g, b);
    }

    public static string? ExtractHexColorFromString(string input)
    {
        var match = Configuration.HexColorRegex.Match(input);

        return match.Success
            ? match.Value
            : null;
    }

    public static string AnalyzeColor(Color color)
    {
        var luminosity = Rounder.RoundToNearestTen(0.2126 * color.R + 0.7152 * color.G + 0.0722 * color.B);

        if (color.R == color.G && color.G == color.B)
        {
            return luminosity switch
            {
                < 50 => $"black-{luminosity}",
                > 200 => $"white-{luminosity}",
                _ => $"gray-{luminosity}"
            };
        }

        if (color.R > color.G && color.R > color.B) return $"danger-{luminosity}";
        if (color.G > color.R && color.G > color.B) return $"success-{luminosity}";
        if (color.B > color.R && color.B > color.G) return $"primary-{luminosity}";
        if (color.R > color.B && color.G > color.B) return $"warning-{luminosity}";
        return $"undefined-{luminosity}";
    }

    public static string FindClosestColor(string targetHex, List<string> colorList)
    {
        var targetColor = ColorTranslator.FromHtml(targetHex);
        var closestColor = "";
        var closestDistance = double.MaxValue;

        foreach (var hex in colorList)
        {
            var testColor = ColorTranslator.FromHtml(hex);
            var distance = ColorDistance(targetColor, testColor);

            if (!(distance < closestDistance)) continue;
            closestDistance = distance;
            closestColor = hex;
        }

        return closestColor;
    }

    private static double ColorDistance(Color c1, Color c2)
    {
        // Calcula a distância Euclidiana
        var redDiff = c1.R - c2.R;
        var greenDiff = c1.G - c2.G;
        var blueDiff = c1.B - c2.B;
        return Math.Sqrt(redDiff * redDiff + greenDiff * greenDiff + blueDiff * blueDiff);
    }
}

public class Rounder
{
    public static int RoundToNearestTen(double number)
    {
        return (int)Math.Round(number / 10) * 10;
    }
}