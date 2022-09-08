using AddressBookProblem;

namespace TestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_To_Add_Data_In_Addressbook()
        {
            List<Contact> AddresDetails = new List<Contact>();
            AddresDetails.Add(new Contact(Firstname: "Rajesh", Lastname: "Verma", Address: "Bemetara", City: "Durg", State: "Chhattisgarh", Zip: 490020, Phone: "7898625487", Email: "sahu@12gmail.com"));
            AddresDetails.Add(new Contact(Firstname: "Mukesh", Lastname: "Tiwari", Address: "Utai", City: "Durg", State: "Chhattisgarh", Zip: 490020, Phone: "7898625487", Email: "sahu@12gmail.com"));
            AddresDetails.Add(new Contact(Firstname: "Govind", Lastname: "Bhatt", Address: "Rajendra nagar", City: "Durg", State: "Chhattisgarh", Zip: 490020, Phone: "7898625487", Email: "sahu@12gmail.com"));
            AddresDetails.Add(new Contact(Firstname: "Vidya", Lastname: "yadav", Address: "", City: "Durg", State: "Chhattisgarh", Zip: 490020, Phone: "7898625487", Email: "sahu@12gmail.com"));
            AddressBook emppayroll = new AddressBook();
            DateTime StartDateTime = DateTime.Now;
            emppayroll.AddEmployee(AddresDetails);
            DateTime StopDateTimes = DateTime.Now;

            Console.WriteLine("Duration without threads: " + (StopDateTimes - StartDateTime));
        }
    }
}