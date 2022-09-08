using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookProblem
{
    public class AddressBook
    {
        public List<Contact> AddDatalist = new List<Contact>();
        public void AddEmployee(List<Contact> AddDatalist)
        {
            AddDatalist.ForEach(AddData =>
            {
                Console.WriteLine("Data being added: " + AddData.FirstName + " " + AddData.LastName + " " + AddData.Address + " " + AddData.City + " " + AddData.State + " " + AddData.Zip + " " + AddData.Phone + " " + AddData.Email);
                this.AddEmployeePayroll(AddData);
                Console.WriteLine("Employee added: " + AddData.FirstName + " " + AddData.LastName + " " + AddData.Address + " " + AddData.City + " " + AddData.State + " " + AddData.Zip + " " + AddData.Phone + " " + AddData.Email);
            }
            );
            Console.WriteLine(this.AddDatalist.ToString());
        }


        public void AddEmployeePayroll(Contact emp)
        {
            AddDatalist.Add(emp);
        }
    }
}
