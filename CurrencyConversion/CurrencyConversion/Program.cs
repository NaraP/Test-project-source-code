using CurrencyConversion.IServices;
using CurrencyConversion.Services;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Net;
using System.Net.Http;
using System.Text.RegularExpressions;

namespace CurrencyConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            double amount, curAmount;
            Console.Write("Enter Your Amount:");
            amount = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nPress(1) for Dollar->Euro \nPress(2) for Euro->Dollar \nEnter exchange type: ");
            int exchangeType = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("*************************");

            //setup our DI
            var serviceCollection = new ServiceCollection()
                        .AddScoped<IConverter, Converter>()
                        .AddScoped<IConverterWrapper, ConverterWrapper>()
                        .AddScoped<IAccountDiscountCalculator, AccountDiscountCalculator>()
                        .AddScoped<IAccountDiscountCalculatorFactory, DefaultAccountDiscountCalculatorFactory>()
                        .AddScoped<ILoyaltyDiscountCalculator, DefaultLoyaltyDiscountCalculator>()
                        .BuildServiceProvider();

            var _converterWrapper = serviceCollection.GetService<IConverterWrapper>(); 

            switch (exchangeType)
            {
                case 1:
                    curAmount = _converterWrapper.Convert(Convert.ToInt32(amount), 0, exchangeType);
                    Console.WriteLine("{0:N2}{1}", amount + " " + "USD = " + Math.Round(curAmount,3), " " + "EURO");
                    break;

                case 2:
                    curAmount = _converterWrapper.Convert(0, Convert.ToInt32(amount), exchangeType);
                    Console.WriteLine("{0:N2}{1}", amount + " " + "EURO = " + Math.Round(curAmount,3), " " + "USD");
                    break;

                default:
                    Console.WriteLine("No match found");
                    break;
            }

            Console.ReadLine();
        }
    }
}
