namespace SwemExample.Basket
{
    public class LimitedBasketFactory : BasketFactory
    {
        private const int MaxItemCount = 10;

        public override IBasket Create() => new LimitedBasket(MaxItemCount);
    }
}