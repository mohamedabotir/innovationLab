namespace CPM.BusinessLogic
{
    public sealed class PrimeumCustomer : Customer
    {
        public PrimeumCustomer(int customerId, string homeAddress)
            : base(customerId, homeAddress)
        {
        }
        public override IOrderCalculator Calculator(Order order)
        {
            return new NormalCustomerCalculator(order);
        }
    }
}