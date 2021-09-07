using System.Collections.Generic;
using SwemExample.Items;

namespace SwemExample.Basket
{
    public interface IBasket
    {
        IEnumerable<Item> Items { get; }

        void Add(Item item);

        int GetPrice();

        void Remove(Item item);
    }
}