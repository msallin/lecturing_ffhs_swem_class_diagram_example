namespace SwemSample.Basket
{
	public class LimitedBasketFactory : BasketFactory
	{
		private const int maxItemCount = 10;

		public override IBasket Create() => new LimitedBasket(maxItemCount);
	}
}
