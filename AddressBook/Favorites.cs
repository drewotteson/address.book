using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class Favorites
    {
        public string personFirstName;
        public string personLastName;
        public string personAddress;
        public string personPhoneNumber;


        public Favorites(string firstName, string lastName, string address, string phoneNumber)
        {
            this.personFirstName = firstName;
            this.personLastName = lastName;
            this.personAddress = address;
            this.personPhoneNumber = phoneNumber;
        }

        public override string ToString()
        {
            return (personFirstName + "" + personLastName + "" + personAddress + "" + personAddress + "" + personPhoneNumber);
        }
    }
}

