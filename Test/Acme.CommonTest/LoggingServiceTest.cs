using ACM.BL;
using Acme.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Acme.CommonTest
{
    [TestClass]
    public class LoggingServiceTest
    {
        [TestMethod]
        public void WriteToFileTest()
        {
            var changeItems = new List<ILoggable>();
            AddressRepository addressRepository = new AddressRepository();

            var customer = new Customer(1)
            {
                EmailAddress = "mashayete@gmail.com",
                FirstName = "Freddo",
                LastName = "Baggins",
                AddressList = null
            };

            changeItems.Add(customer);

            var product = new Product(2)
            {
                ProductName = "Rake",
                ProductDescription = "Garden Rake with Steel Hand",
                CurrentPrice = 6M
            };
            changeItems.Add(product);

            LoggingService.WriteToFile(changeItems);
            

        }
    }
}
