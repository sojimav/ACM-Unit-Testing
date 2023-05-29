using Acme.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    
    public class Customer : EntityBase,  ILoggable
    {
        public Customer() : this(0)
        {
                
        }

        public Customer(int customerId)
        {
            CustomerId = customerId;
            AddressList = new List<Address>();
        }


        public List<Address> AddressList { get; set; }
        public int CustomerType { get; set; }
        public int CustomerId { get; private set; }
        public string EmailAddress { get; set; }
        public string FirstName {get; set;}
        public string LastName { get; set;}

        public static int instanceCount { get; set; }


        public string Log() => $"{CustomerId}: {FullName} Email: {EmailAddress}";
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

        public override bool Validate()
        {
            var isValid = true;
            if(string.IsNullOrWhiteSpace(LastName)) isValid = false; 
            if(string.IsNullOrWhiteSpace(EmailAddress)) isValid = false;

            return isValid;
        }

      
    }
}
