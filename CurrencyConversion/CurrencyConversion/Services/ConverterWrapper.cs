using CurrencyConversion.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConversion.Services
{
   public class ConverterWrapper : IConverterWrapper
    {
        private readonly IConverter _converter;
   
        public ConverterWrapper (IConverter converter)
        {
            _converter = converter;
        }

        public double Convert(int usd, int eur, int exchangeType)
        {
            double conversionCurrency = 0.00;

            dynamic exchangeRate = ExchangeFees.GetExchangeRate();

            switch (exchangeType)
            {
                case 1:
                    conversionCurrency = _converter.ConversionUSDtoEUR(usd, exchangeRate.eur.rate);
                    break;

                case 2:
                    conversionCurrency = _converter.ConversionEURtoUSD(eur, exchangeRate.eur.inverseRate);
                    break;

                default:
                    Console.WriteLine("No match found");
                    break;
            }

            return conversionCurrency;
        }
    }
}
