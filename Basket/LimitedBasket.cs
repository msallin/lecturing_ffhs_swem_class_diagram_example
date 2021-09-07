using System;
using System.Collections.Generic;
using System.Linq;
using SwemExample.Items;

namespace SwemExample.Basket
{
    public class LimitedBasket : IBasket
    {
        private readonly List<Item> _internalBasket;

        public LimitedBasket(int maxItemCount)
        {
            MaxItemCount = maxItemCount;
            _internalBasket = new List<Item>(maxItemCount);
        }

        public int MaxItemCount { get; }

        public int GetPrice() => _internalBasket.Sum(i => i.Price);

        public void Remove(Item item) => _internalBasket.Remove(item);

        public IEnumerable<Item> Items => _internalBasket.AsEnumerable();

        public void Add(Item item)
        {
            if (_internalBasket.Count > MaxItemCount)
            {
                throw new InvalidOperationException("Must not contain more than " + MaxItemCount + " items!");
            }

            _internalBasket.Add(item);
        }
    }
}