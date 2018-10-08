namespace SwemSample.Basket
{
	public class UnlimitedBasketFactory : BasketFactory
	{
		public override IBasket Create() => new UnlimitedBasket();
	}
}
