using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    internal class Order
    {
        public Order() { }

        public Order(int orderId)
        {
            OrderId = orderId;
        }

        public int OrderId { get;  private set; }
        public DateTimeOffset? OrderDate { get; set; }

        public Order Retrieve(int orderId)
        {
            return new Order();
        }

        public bool Save()
        {
            return true;
        }

         public bool Validate()
        {
            bool isValid = true;
            if(OrderDate == null) isValid = false;

            return isValid;

        }
    }
}
