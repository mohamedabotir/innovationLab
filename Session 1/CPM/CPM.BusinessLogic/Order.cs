namespace CPM.BusinessLogic
{
    public class Order
    {
        public Order(int id, Customer customer, string shippingAddress)
        {
            OrderId = id;

            if (customer is not null)
                throw new ArgumentException($"{nameof(customer)} can not be null.");
            if (string.IsNullOrEmpty(shippingAddress))
                throw new ArgumentException($"{nameof(shippingAddress)} can not be null or empty.");

            CustomerId = customer.CustomerId;
            Customer = customer;
            ShippingAddress = shippingAddress;
        }
        public int OrderId { get; }
        public int CustomerId { get; }
        public Customer Customer { get; }
        public string ShippingAddress { get; }
        public DateTime OrderDate { get; } = DateTime.Now;
        public List<OrderItem> Items { get; } = new List<OrderItem>();
        public decimal FinalPrice { get; private set; }
        public decimal DiscountValue { get; set; } = decimal.Zero;
        public DiscountType DiscountType { get; set; } = DiscountType.Value;


        public void AddOrderItem(OrderItem item)
        {
            Items.Add(item);

            FinalPrice = Items.Sum(e => e.TotalPrice);
        }

        public void ApplyDiscount(decimal value, DiscountType type)
        {
            DiscountValue = value;
            DiscountType = type;

            IOrderCalculator orderCalculator = Customer.Calculator(this);

            var discount = orderCalculator.GetDiscountValue();
            
            FinalPrice -= discount;
        }

    }
}
