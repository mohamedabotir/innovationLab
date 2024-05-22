using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session5.Strategy
{
    public interface ICustomerDiscountStrategy
    {
        decimal CalculateDiscount(decimal totalPrice);
    }
}
