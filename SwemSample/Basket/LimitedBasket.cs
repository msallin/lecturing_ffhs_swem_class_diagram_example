using System;
using System.Collections.Generic;
using System.Linq;
using SwemSample.Items;

namespace SwemSample.Basket
{
	public class LimitedBasket : IBasket
	{
		private readonly List<Item> internalBasket;

		public LimitedBasket(int maxItemCount)
		{
			MaxItemCount = maxItemCount;
			internalBasket = new List<Item>(maxItemCount);
		}

		public int GetPrice() => internalBasket.Sum(i => i.Price);

		public void Remove(Item item) => internalBasket.Remove(item);

		public IEnumerable<Item> Items => internalBasket.AsEnumerable();

		public int MaxItemCount { get; }

		public void Add(Item item)
		{
			if (internalBasket.Count > MaxItemCount)
			{
				throw new InvalidOperationException("Must not contain more than " + MaxItemCount + " items!");
			}

			internalBasket.Add(item);
		}
	}
}
