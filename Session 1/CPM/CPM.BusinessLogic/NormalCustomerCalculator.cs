namespace CPM.BusinessLogic
{
    public class NormalCustomerCalculator : IOrderCalculator
    {
        private readonly Order _order;

        public NormalCustomerCalculator(Order order)
        {
            _order = order;
        }

        public decimal GetDiscountValue()
        {
            var items = _order.Items;
            var finalPrice = items.Sum(e => e.TotalPrice);

            return finalPrice;
        }
    }
}
