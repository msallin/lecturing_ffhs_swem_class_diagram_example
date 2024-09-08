using System;
using System.Linq;
using SwemExample.Basket;
using SwemExample.Items;

namespace SwemExample;

public class Program
{
    // The abstract factory pattern is used to either create a limited or unlimited basket.
    private static readonly BasketFactory BasketFactory = new UnlimitedBasketFactory();

    private static void Main()
    {
        IBasket basket = BasketFactory.Create();

        // Add items to the basket.
        PopulateBasket(basket);

        // Print the added items.
        Console.WriteLine("After population");
        PrintBasket(basket);

        // Remove items until the price of all items in the basekt is below 10.
        RemoveItemsUntil(basket, 10);

        // Print the basket after the items were removed.
        Console.WriteLine("After removal");
        PrintBasket(basket);
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
    private static void RemoveItemsUntil(IBasket basket, int targetPrice)
    {
        while (basket.GetPrice() > targetPrice)
        {
            Item itemToRemove = basket.Items.OrderByDescending(item => item.Price).First();
            basket.Remove(itemToRemove);
        }
    }

    private static void PrintBasket(IBasket basket)
    {
        foreach (Item item in basket.Items)
        {
            Console.WriteLine(item.Name);
        }
    }

}