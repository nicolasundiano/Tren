namespace Tren.Extensions;

public static class ListExtensions
{
    public static void AddElementToList(this List<int> list, int element, bool inRight)
    {
        if (inRight)
            list.Add(element);
        else
        {
            list.Insert(0, element);
        }
    }
    
    public static void RemoveElementFromList(this List<int> list, bool inRight)
    {
        if (list.Count > 0)
        {
            if (inRight)
            {
                var count = list.Count;
                list.RemoveAt(count-1);
            }
            else
            {
                list.RemoveAt(0);
            } 
        }
    }
    
    public static string JoinToString(this List<int> list, char c)
    {
        return string.Join(c, list);
    }
}