using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    internal class Product
    {
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public decimal? CurrentPrice { get; set; }

        public int ProductId { get; private set; }

        public Product() { }

        public Product(int productId)
        {
            ProductId = productId;
        }


        // Validates the product data
        public bool Validate()
        {
            var isValid = true;
            if(string.IsNullOrWhiteSpace(ProductName)) isValid = false;
            if(CurrentPrice == null) isValid = false;

            return isValid;
        }

        public Product Retrieve(int productId)
        {
            return new Product();
        }

        public bool Save()
        {
            // Code that save the defined product
            return true;
        }
    }
}
