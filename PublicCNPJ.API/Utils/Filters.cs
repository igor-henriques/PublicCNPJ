namespace PublicCNPJ.API.Utils;

public static class Filters
{
    public static bool TryFilter(this string text, out string filteredText)
    {
        filteredText = new string(text
            ?.Trim()
            ?.Where(c => char.IsDigit(c))
            ?.ToArray());

        return filteredText?.Length == 14;
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