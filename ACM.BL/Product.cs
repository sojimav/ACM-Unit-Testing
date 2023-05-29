using Acme.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Product : EntityBase
    {

        private string productName;
        public string ProductName
        {
            get
            {
                
                return StringHandler.InsertSpaces(productName);
            }

            set
            {
                productName = value;
            }
        }
        public string ProductDescription { get; set; }
        public decimal? CurrentPrice { get; set; }

        public int ProductId { get; private set; }

        public Product() { }

        public Product(int productId)
        {
            ProductId = productId;
        }


        // Validates the product data
        public override bool Validate()
        {
            var isValid = true;
            if(string.IsNullOrWhiteSpace(ProductName)) isValid = false;
            if(CurrentPrice == null) isValid = false;

            return isValid;
        }

        
    }
}
