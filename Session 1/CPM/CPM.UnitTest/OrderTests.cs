using CPM.BusinessLogic;

namespace CPM.UnitTest
{
    public class OrderTests
    {
        [Fact]
        public void ApplyDiscount_10PercentDiscount()
        {
            // arrange
            var order = new Order(1, 1, "Nasr City, Cairo, Egypt");
            var orderItem = new OrderItem
            {
                OrderId = 1,
                OrderItemId = 1,
                Product = new Product
                {
                    Name = "Laptop",
                    Price = 1000
                },
                PurchasePrice = 1000,
                Quantity = 2
            };

            // act
            order.AddOrderItem(orderItem);
            order.ApplyDiscount(10, DiscountType.Percentage);

            Assert.Equal(1800, order.FinalPrice);
        }
        [Fact]
        public void NoDiscount_SumTotalPriceOfOrderItems()
        {
            // arrange
            var order = new Order(1, 1, "sss");
            var orderItem = new OrderItem
            {
                OrderId = 1,
                OrderItemId = 1,
                Product = new Product
                {
                    Name = "Laptop",
                    Price = 1000
                },
                PurchasePrice = 1000,
                Quantity = 2
            };

            // act 
            order.AddOrderItem(orderItem);

            // assert
            Assert.Equal(2000, order.FinalPrice);
        }
    }
}
