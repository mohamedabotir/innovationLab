namespace CPM.BusinessLogic
{
    public sealed class NormalCustomer : Customer
    {
        public NormalCustomer(int customerId, string homeAddress) 
            : base(customerId, homeAddress)
        {
        }

        public override IOrderCalculator Calculator(Order order)
        {
            return new NormalCustomerCalculator(order);
        }
    }
}