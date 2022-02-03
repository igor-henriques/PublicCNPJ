namespace PublicCNPJ.API.Utils;

public static class Filters
{
    private static List<string> filter = new List<string>() { "-", "/", "." };

    public static bool TryFilter(this string text, out string filteredText)
    {
        string result = text;

        if (text.Any(c => filter.Contains(c.ToString())))
            result = new string(text?.Where(c => !filter.Contains(c.ToString())).ToArray());

        filteredText = result;

        return !string.IsNullOrEmpty(filteredText);
    }

    public static bool TryFilter(this IEnumerable<string> texts, out IEnumerable<string> filteredTexts)
    {
        filteredTexts = new List<string>();

        var _filteredTexts = new List<string>();

        foreach (var text in texts)
        {
            if (!text.TryFilter(out string filteredText)) return false;

            _filteredTexts.Add(filteredText);
        }

        filteredTexts = _filteredTexts;

        return true;
    }
}