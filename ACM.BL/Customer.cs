using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    
    public class Customer
    {
        public Customer()
        {
                
        }

        public Customer(int customerId)
        {
            CustomerId = customerId;
        }

        public int CustomerId { get; private set; }
        public string EmailAddress { get; set; }
        public string FirstName {get; set;}
        public string LastName { get; set;}

        public string FullName
        {
            get
            {
               string fullName = LastName;
                if (!string.IsNullOrWhiteSpace(FirstName))
                {
                    if(!string.IsNullOrWhiteSpace(fullName))
                    {
                        fullName += ", ";
                    }
                    return fullName += FirstName;
                }

                return fullName;
            }
        }

        public bool Validate()
        {
            var isValid = true;
            if(string.IsNullOrWhiteSpace(LastName)) isValid = false; 
            if(string.IsNullOrWhiteSpace(EmailAddress)) isValid = false;

            return isValid;
        }

        public Customer Retrieve(int customerId)
        {
            // Code that retrieves the defined customer
            return new Customer { CustomerId = customerId };
        }
     
        public List<Customer> Retrieve()
        {
            // Code that retrieves all of the customers

            return new List<Customer>();    
        }


        public bool Save()
        {
            return true;
        }

    }
}
