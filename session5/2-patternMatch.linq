<Query Kind="Statements" />



ICustomerDiscountStrategy CustomerDiscountFactory(decimal totalCost)=> totalCost switch
{
       (< 5000) and (> 0) => new StandardCustomerDiscountStrategy(),
   (< 10000) and (>= 5000) => new GoldCustomerDiscountStrategy(),
   (>= 10000) => new PremiumCustomerDiscountStrategy(),//positional pattern
_ => throw new InvalidOperationException("invalid Operation")
};

ICustomerDiscountStrategy CustomerDiscountWithOrderFactory(Order order)=> order switch
{
    { Items: > 10, Cost: > 1000M } => new GoldCustomerDiscountStrategy(),
    { Items: > 5, Cost: > 1000M } => new PremiumCustomerDiscountStrategy(),
    { Cost: <= 1000M and >=500} => new StandardCustomerDiscountStrategy(),// relational pattern
    (<500M and >= 250M,>=3) => new LawEndCustomerDiscountStrategy(),
    _ => new NoStandardCustomerDiscountStrategy(),
   
};



public class Order(int items, decimal cost)
{
    public int Items { get; } = items;
    public decimal Cost { get; } = cost;

    public void Deconstruct(out decimal cost, out int items) // deconstruct
    {
       (items, cost) = (Items, Cost) ;
    }
};