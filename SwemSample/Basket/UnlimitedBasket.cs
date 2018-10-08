using System.Collections.Generic;
using System.Linq;
using SwemSample.Items;

namespace SwemSample.Basket
{
	public class UnlimitedBasket : IBasket
	{
		private readonly IList<Item> internalBasket = new List<Item>();

		public void Add(Item item) => internalBasket.Add(item);

		public int GetPrice() => internalBasket.Sum(i => i.Price);

		public void Remove(Item item) => internalBasket.Remove(item);

		public IEnumerable<Item> Items => internalBasket.AsEnumerable();
	}
}
