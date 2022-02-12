using CurrencyConversion.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConversion.Services
{
 
    public class DefaultAccountDiscountCalculatorFactory : IAccountDiscountCalculatorFactory
    {
        public IAccountDiscountCalculator GetAccountDiscountCalculator(CurrencyConversion.CustomerType customerType)
        {
            IAccountDiscountCalculator calculator;

            switch (customerType.ToString())
            {
                case Constants.Silver:
                    calculator = new SilverDiscountCalculator();
                    break;

                case Constants.Gold:
                    calculator = new GoldDiscountCalculator();
                    break;

                case Constants.Platinum:
                    calculator = new PlatinumDiscountCalculator();
                    break;

                default:
                    throw new NotImplementedException();
            }
            return calculator;
        }
    }
}
