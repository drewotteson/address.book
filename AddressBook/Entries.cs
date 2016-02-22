using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class Entries
    {
        private string FirstName;
        private string LastName;
        private string PhoneNumber;
        private string Address;


        public Entries(string firstName, string lastName, string phoneNumber, string address)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.PhoneNumber = phoneNumber;
            this.Address = address;
        }
        public Entries()
        {

        }
        public override string ToString()
        {
            return (FirstName + "" + LastName + "" + Address + "" + PhoneNumber);
        }
        
        }
       
        }
    

