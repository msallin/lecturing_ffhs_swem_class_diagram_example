namespace SwemExample.Basket
{
    public class UnlimitedBasketFactory : BasketFactory
    {
        public override IBasket Create()
        {
            return new UnlimitedBasket();
        }
    }
}