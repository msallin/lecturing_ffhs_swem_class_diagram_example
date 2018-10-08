using System.Collections.Generic;
using SwemSample.Items;

namespace SwemSample.Basket
{
	public interface IBasket
	{
		IEnumerable<Item> Items { get; }

		void Add(Item item);

		int GetPrice();

		void Remove(Item item);
	}
}