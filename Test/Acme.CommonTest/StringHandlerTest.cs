using Acme.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Acme.CommonTest
{
    [TestClass]
    public class StringHandlerTest
    {
        [TestMethod]
        public void InsertSpacesTestValid()
        {
          ;
            var source = "Sonic Screwdriver";
            var expected = "Sonic Screwdriver";
            var handler = StringHandler.InsertSpaces(source);

            Assert.AreEqual(expected, handler);
        }
    }
}
