using System.Collections.Generic;
using System.Linq;
using SwemExample.Items;

namespace SwemExample.Basket
{
    public class UnlimitedBasket : IBasket
    {
        private readonly IList<Item> _internalBasket = new List<Item>();

        public void Add(Item item) => _internalBasket.Add(item);

        public int GetPrice() => _internalBasket.Sum(i => i.Price);

        public void Remove(Item item) => _internalBasket.Remove(item);


        public IEnumerable<Item> Items => _internalBasket.AsEnumerable();
    }
}