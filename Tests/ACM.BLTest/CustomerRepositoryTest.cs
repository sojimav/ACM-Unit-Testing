using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerRepositoryTest
    {
        [TestMethod]
        public void RetrieveValid()
        {
            // Arrange
            var customerRepository = new CustomerRepository();
            var expected = new Customer(1)
            {
                EmailAddress = "mashayete@gmail.com",
                FirstName = "Freddo",
                LastName = "Baggins"
            };

            // Act
            var actual = customerRepository.Retrieve(1);

            // Assert
            Assert.AreEqual(expected.CustomerId, actual.CustomerId);
            Assert.AreEqual(expected.EmailAddress, actual.EmailAddress);
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);
        }

        [TestMethod]
        public void RetrievingExistingWithAddress()
        {     
            var customerRepository = new CustomerRepository();
            var expected = new Customer(1)
            {
                EmailAddress = "mashayete@gmail.com",
                FirstName = "Freddo",
                LastName = "Baggins",
                AddressList = new List<Address>()
                {
                    new Address()
                    {
                         AddressType = 1,
                         StreetLine1 = "Bag End",
                        StreetLine2 = "Bagshot row",
                        City = "Hobbiton",
                        State = "Shire",
                        Country = "Middle Earth",
                        PostalCode = "144"
                    },

                    new Address()
                    {
                         AddressType = 2,
                        StreetLine1 = "Green Dragon",
                        City = "Bywater",
                        State = "Shire",
                        Country = "Middle Earth",
                        PostalCode = "146"
                    }
                }
            };
            var actual = customerRepository.Retrieve(1);


            Assert.AreEqual(expected.AddressList[1].StreetLine1, actual.AddressList[1].StreetLine1);
            

            
        }
    }
}
