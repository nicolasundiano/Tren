namespace Tren.Models;

public class TrenViewModel
{
    public List<int> Tren { get; set; } = new();
    public int Vagon { get; set; }
    public string TrenString { get; set; } = string.Empty;
    public bool InRight { get; set; }
}