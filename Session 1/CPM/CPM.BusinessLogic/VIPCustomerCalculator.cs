namespace CPM.BusinessLogic
{
    public class VIPCustomerCalculator : IOrderCalculator
    {
        private readonly Order _order;

        public VIPCustomerCalculator(Order order)
        {
            _order = order;
        }

        public decimal GetDiscountValue()
        {
            var items = _order.Items;
            var finalPrice = items.Sum(e => e.TotalPrice);

            if (_order.DiscountType == DiscountType.Percentage)
                finalPrice -= (finalPrice * (10 / 100));
            else
                finalPrice -= _order.DiscountValue;

            return finalPrice;
        }
    }
}
