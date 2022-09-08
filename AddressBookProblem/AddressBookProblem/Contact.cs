using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookProblem
{
    public class Contact
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Zip { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public Contact(string Firstname, string Lastname, string Address, string City, string State, int Zip, string Phone, string Email)
        {
            this.FirstName = Firstname;
            this.LastName = Lastname;
            this.Address = Address;
            this.City = City;
            this.State = State;
            this.Zip = Zip;
            this.Phone = Phone;
            this.Email = Email;

        }
    }
}
