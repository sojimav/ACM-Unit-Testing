using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    internal class OrderItem
    {
        public OrderItem() { }  
        public OrderItem(int orderItemId)
        {
            OrderItemId = orderItemId;
        }

        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal? PurchasePrice { get; set; }
        public int OrderItemId { get; private set; }
        

        public OrderItem Retrieve(int orderItemId)
        {
            return new OrderItem();
        }

        public bool Save()
        {
            // Code that saves the defined order item
           return true;
        }


        public bool isValidate()
        {
           bool isValid = true;
            if(Quantity <= 0) isValid = false;
            if(ProductId <= 0) isValid = false;
            if(PurchasePrice <= 0) isValid = false;

            return isValid;
        }
    }
}
