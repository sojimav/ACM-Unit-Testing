using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class ProductRepository
    {

        public Product Retrieve(int productId)
        {
            // Create the instance of the Customer class
            // Pass in the requested id

            Product product = new Product(productId);

            // Code that retrieves the defined customer

            // Temporary hard-coded values to return a populated customer

            if (productId == 2)
            {
                product.ProductName = "Sunflowers";
                product.ProductDescription = "Assorted Size Set of 4 Bright Yellow Mini Sunflowers";
                product.CurrentPrice = 15.96M;
            } 

           
            return product;
        }

        public bool Save(Product product)
        {
            var success = true;

            if (product.IsValid)
            {
                if (product.IsNew)
                {
                    // Call an Insert Stored Procedure
                }
                else
                {
                    // Call an Update Stored Procedure
                }
            }
            else
            {
                success = false;
            }
            // Code that save the passed in customer
            return success;
        }
    }
}
