using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConversion
{
  public  class DiscountCalculators 
    {
        public virtual decimal DiscountCalculator(decimal price, int clientType, int years)
        {
           return (years > 7) ? (decimal)7 / 100 : (decimal)years / 100;
        }
    }
    public class SilverCustomer : DiscountCalculators
    {
        public override decimal DiscountCalculator(decimal price, int clientType, int years)
        {
            return base.DiscountCalculator(price, clientType, years);
        }
    }
    public class GoldCustomer : DiscountCalculators
    {
        public override decimal DiscountCalculator(decimal price, int clientType, int years)
        {
            return base.DiscountCalculator(price, clientType, years);
        }
    }
    public class PlatinumCustomer : DiscountCalculators
    {
        public override decimal DiscountCalculator(decimal price, int clientType, int years)
        {
            return base.DiscountCalculator(price, clientType, years);
        }
    }


}
