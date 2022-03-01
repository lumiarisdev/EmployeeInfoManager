using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace EmployeeInfoManager.Model
{
    [BsonIgnoreExtraElements]
    public class Employee : BindableBase
    {

        private ObjectId id;

        private string name;
        private string preferredName;
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

        [BsonId]
        public ObjectId Id
        {
            get
            {
                return id;
            }
            set
            {
                SetProperty(ref id, value);
            }
        }

        [BsonElement("name")]
        public string Name { get { return name; } set { SetProperty<string>(ref name, value); } }
        [BsonElement("preferred_name")]
        public string PreferredName { get { return preferredName;} set { SetProperty<string>(ref preferredName, value); } }
        [BsonElement("date_of_birth")]
        public DateTime DateOfBirth { get { return dateofBirth; } set { SetProperty<DateTime>(ref dateofBirth, value); } }
        [BsonElement("phone_number")]
        public string PhoneNumber { get { return phoneNumber; } set { SetProperty<string>(ref phoneNumber, value);} }
        [BsonElement("phone_number_alternate")]
        public string PhoneNumber2 { get { return phoneNumber2; } set { SetProperty<string>(ref phoneNumber2, value);} }
        [BsonElement("email")]
        public string Email { get { return email; } set { SetProperty<string>(ref email, value); } }
        [BsonElement("name_alternate")]
        public string Email2 { get { return email2; } set { SetProperty<string>(ref email2, value); } }
        [BsonElement("username")]
        public string Username { get { return username; } set { SetProperty<string>(ref username, value); } }
        [BsonElement("alias")]
        public string Alias { get { return alias; } set { SetProperty<string>(ref alias, value); } }
        [BsonElement("address")]
        public string Address { get { return address; } set { SetProperty<string>(ref address, value); } }
        [BsonElement("address_line2")]
        public string Address2 { get { return address2; } set { SetProperty<string>(ref address2, value); } }
        [BsonElement("city")]
        public string City { get { return city; } set { SetProperty<string>(ref city, value); } }
        [BsonElement("zipcode")]
        public int ZipCode { get { return zipCode; } set { SetProperty<int>(ref zipCode, value);} }

        [BsonElement("date_hired")]
        public DateTime DateOfHire { get { return dateOfHire; } set { SetProperty<DateTime>(ref dateOfHire, value); } }
        [BsonElement("date_separated")]
        public DateTime DateOfSeparation { get { return dateOfSeparation; } set { SetProperty<DateTime>(ref dateOfSeparation, value); } }
        [BsonElement("active")]
        public bool Active { get { return active; } set { SetProperty<bool>(ref active, value); } }
        [BsonElement("temp")]
        public bool Temporary { get { return temporary; } set { SetProperty<bool>(ref temporary, value); } }
        [BsonElement("expiration")]
        public DateTime Expiration { get { return expiration; } set { SetProperty<DateTime>(ref expiration, value); } }

        [BsonElement("job_title")]
        public string JobTitle { get { return jobTitle; } set { SetProperty<string>(ref jobTitle, value);} }
        [BsonElement("department")]
        public string Department { get { return department; } set { SetProperty<string>(ref department, value);} }
        [BsonElement("manager")]
        public string Manager { get { return manager; } set { SetProperty<string>(ref manager, value); } }
        [BsonElement("salary")]
        public int Salary { get { return salary; } set { SetProperty<int>(ref salary, value);} }
        [BsonElement("ssn")]
        public int SSN { get { return ssn; } set { SetProperty<int>(ref ssn, value);} }

        // some mongodb helpers

     

    }
}
