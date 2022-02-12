using CurrencyConversion.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConversion.Services
{
  public  class PlatinumDiscountCalculator : IAccountDiscountCalculator
    {
        public decimal ApplyDiscount(decimal price)
        {
            return price - (Constants.DISCOUNT_FOR_PLATINUM_CUSTOMERS * price);
        }
    }
}
