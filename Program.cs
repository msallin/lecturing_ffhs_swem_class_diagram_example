using System;
using System.Linq;
using SwemExample.Basket;
using SwemExample.Items;

namespace SwemExample
{
    public class Program
    {
        private static readonly BasketFactory BasketFactory = new UnlimitedBasketFactory();

        private static void Main()
        {
            var basket = BasketFactory.Create();

            PopulateBasket(basket);

            Console.WriteLine("After population");
            PrintBasket(basket);

            while (basket.GetPrice() > 10)
            {
                Item itemToRemove = basket.Items.OrderByDescending(item => item.Price).First();
                basket.Remove(itemToRemove);
            }

            Console.WriteLine("After removal");
            PrintBasket(basket);
        }

        private static void PrintBasket(IBasket basket)
        {
            foreach (Item item in basket.Items)
            {
                Console.WriteLine(item.Name);
            }
        }

        private static void PopulateBasket(IBasket basket)
        {
            Item item1 = new SportItem(15, "Football", 1, SportItemKind.X);
            basket.Add(item1);

            Item item2 = new SportItem(10, "Baseball", 1, SportItemKind.Y);
            basket.Add(item2);

            Item item3 = new SportItem(20, "Bike", 1, SportItemKind.Z);
            basket.Add(item3);
        }
    }
}