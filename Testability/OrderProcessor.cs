namespace Testability
{
    public class OrderProcessor
    {
        private readonly ShippingCalculator _shippingCalculator;
        public OrderProcessor()
        {
            _shippingCalculator = new ShippingCalculator();

        }
    }
}