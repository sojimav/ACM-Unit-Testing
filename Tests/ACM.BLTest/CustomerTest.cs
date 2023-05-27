using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ACM.BL;


namespace ACM.BLTest
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameTestValid()
        {
            //-- Arrange 
            Customer customer = new Customer { 
                FirstName  = "Bilbo",
                LastName = "Baggins"
            };
            string expected = "Baggins, Bilbo";

            //-- Act
            string actual = customer.FullName;

            // --Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void FullNameFirstEmpty()
        {
            Customer customer = new Customer
            {
                LastName = "Baggins"

            };

            string expected = "Baggins";
            string actual = customer.FullName;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FullNameLastNameEmpty()
        {
            Customer customer = new Customer
            {
                FirstName = "Bilbo"

            };

            string expected = "Bilbo";
            string actual = customer.FullName;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidateValid()
        {
            // Arrange
            Customer customer = new Customer
            {
                LastName = "Baggins",
                EmailAddress = "baggins@gmail.com"
            };

            bool expected = true;

            bool actual = customer.Validate();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidateMissingLastName()
        {
            Customer customer = new Customer
            {
                EmailAddress = "baggins@gmail.com"
        };

            bool expected = false;
            bool actual = customer.Validate();
            Assert.AreEqual(expected, actual);
        }
    }
}
