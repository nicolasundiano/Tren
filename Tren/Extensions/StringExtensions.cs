namespace Tren.Extensions;

public static class StringExtensions
{
    public static List<int> SplitToIntList(this string input)
    {
        if (string.IsNullOrEmpty(input))
        {
            return new List<int>();
        }

        var splitString = input.Split(new[] { '-' }, StringSplitOptions.RemoveEmptyEntries);
        var integerList = splitString.Select(int.Parse).ToList();
        return integerList;
    }
}