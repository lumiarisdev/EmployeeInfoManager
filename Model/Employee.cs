using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeInfoManager.Model
{
    public class Employee : BindableBase
    {

        private string name;
        private DateTime dateofBirth;
        private string phoneNumber;
        private string phoneNumber2;
        private string email;
        private string email2;
        private string username;
        private string alias;
        private string address;
        private string address2;
        private string city;
        private int zipCode;

        private DateTime dateOfHire;
        private DateTime dateOfSeparation;
        private bool active;
        private bool temporary;
        private DateTime expiration;

        private string jobTitle;
        private string department;
        private string manager;
        private int salary;
        private int ssn;

        public string Name { get { return name; } set { SetProperty<string>(ref name, value); } }
        public DateTime DateOfBirth { get { return dateofBirth; } set { SetProperty<DateTime>(ref dateofBirth, value); } }
        public string PhoneNumber { get { return phoneNumber; } set { SetProperty<string>(ref phoneNumber, value);} }
        public string PhoneNumber2 { get { return phoneNumber2; } set { SetProperty<string>(ref phoneNumber2, value);} }
        public string Email { get { return email; } set { SetProperty<string>(ref email, value); } }  
        public string Email2 { get { return email2; } set { SetProperty<string>(ref email2, value); } }  
        public string Username { get { return username; } set { SetProperty<string>(ref username, value); } }  
        public string Alias { get { return alias; } set { SetProperty<string>(ref alias, value); } }  
        public string Address { get { return address; } set { SetProperty<string>(ref address, value); } }
        public string Address2 { get { return address2; } set { SetProperty<string>(ref address2, value); } }
        public string City { get { return city; } set { SetProperty<string>(ref city, value); } }
        public int ZipCode { get { return zipCode; } set { SetProperty<int>(ref zipCode, value);} }

        public DateTime DateOfHire { get { return dateOfHire; } set { SetProperty<DateTime>(ref dateOfHire, value); } }
        public DateTime DateOfSeparation { get { return dateOfSeparation; } set { SetProperty<DateTime>(ref dateOfSeparation, value); } }
        public bool Active { get { return active; } set { SetProperty<bool>(ref active, value); } }
        public bool Temporary { get { return temporary; } set { SetProperty<bool>(ref temporary, value); } }
        public DateTime Expiration { get { return expiration; } set { SetProperty<DateTime>(ref expiration, value); } }

        public string JobTitle { get { return jobTitle; } set { SetProperty<string>(ref jobTitle, value);} }
        public string Department { get { return department; } set { SetProperty<string>(ref department, value);} }
        public string Manager { get { return manager; } set { SetProperty<string>(ref manager, value); } }
        public int Salary { get { return salary; } set { SetProperty<int>(ref salary, value);} }
        public int SSN { get { return ssn; } set { SetProperty<int>(ref ssn, value);} }


    }
}
