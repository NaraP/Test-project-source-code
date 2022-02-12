using CurrencyConversion.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConversion.Services
{
  public  class Converter : IConverter
    {
        public  double ConversionUSDtoEUR(int usd, dynamic currencyRate)
        {
            double curAmount = usd * Convert.ToSingle(currencyRate);

            return curAmount;
        }

        public  double ConversionEURtoUSD(int eur, dynamic currencyRate)
        {
            double curAmount = eur * Convert.ToSingle(currencyRate);

            return curAmount;
        }
    }
}
