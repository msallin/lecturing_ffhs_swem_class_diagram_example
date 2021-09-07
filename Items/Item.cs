namespace SwemExample.Items
{
    public abstract class Item
    {
        protected Item(int price, string name, int id)
        {
            Price = price;
            Name = name;
            Id = id;
        }

        public int Price { get; }

        public string Name { get; }

        public int Id { get; }

        public override string ToString() => $"{Name}: CHF {Price}";
    }
}