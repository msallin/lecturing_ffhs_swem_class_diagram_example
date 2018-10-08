using System.Linq;
using SwemSample.Basket;
using SwemSample.Items;

namespace SwemSample
{
	public class Program
	{
		private static readonly BasketFactory basketFactory = new UnlimitedBasketFactory();

		static void Main(string[] args)
		{
			IBasket basket = basketFactory.Create();

			PopulateBasket(basket);

			int price = basket.GetPrice();
			if (price > 10)
			{
				Item firstItemInBasket = basket.Items.First();
				basket.Remove(firstItemInBasket);
			}
		}

		private static void PopulateBasket(IBasket basket)
		{
			Item item1 = new SportItem(15, "Football", 1, SportItemKind.X);
			basket.Add(item1);

			Item item2 = new SportItem(10, "Baseball", 1, SportItemKind.Y);
			basket.Add(item2);
		}
	}
}
