using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConversion.IServices
{
  public  interface IAccountDiscountCalculatorFactory
    {
        IAccountDiscountCalculator GetAccountDiscountCalculator(CustomerType customerType);
    }
}
