namespace TstMauiApp;

public class ColViewItem
{
    public int IndexNr { get; set; }
}

public class ViewModel
{
    public List<ColViewItem> Data { get; } =
    [
        new ColViewItem() { IndexNr = 1 },
        new ColViewItem() { IndexNr = 2 },
        new ColViewItem() { IndexNr = 3 },
        new ColViewItem() { IndexNr = 4 }
    ];
}