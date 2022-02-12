using CurrencyConversion;
using CurrencyConversion.IServices;
using CurrencyConversion.Services;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace TestCurrencyConversion
{
    public class CurrencyConversionTest
    {
        #region Property  
        public Mock<IConverterWrapper> mock = new Mock<IConverterWrapper>();
        #endregion

        [Fact]
        public void ConversionUSDtoEUR() 
        {
            // Arrange
            var mockRepo = new Mock<IConverterWrapper>();
            mockRepo.Setup(repo => repo.Convert(5, 0, 1));

            var mockRepo1 = new Mock<IConverter>(); 
            mockRepo.Setup(repo => repo.Convert(5, 0, 1));

        }

        [Fact]
        public void ConversionEURtoUSD()  
        {
            //// Arrange
            //IConverterWrapper convertWrapper = new ConverterWrapper();
            //// Act
            //var result = convertWrapper.Convert(0, 5, 2);
            //// Assert
            //double data = Math.Round(result, 3);
            //Assert.Equal("5.708", Convert.ToString(data));
        }
    }
}
