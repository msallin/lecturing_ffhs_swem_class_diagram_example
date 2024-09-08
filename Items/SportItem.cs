namespace SwemExample.Items;

public class SportItem : Item
{
    public SportItem(int price, string name, int id, SportItemKind kind)
        : base(price, name, id)
    {
        Kind = kind;
    }

    public SportItemKind Kind { get; set; }
}