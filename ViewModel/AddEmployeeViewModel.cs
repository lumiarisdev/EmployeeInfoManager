using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeInfoManager.Model;
using EmployeeInfoManager.Command;
using MongoDB.Bson;
using MongoDB.Driver;

namespace EmployeeInfoManager.ViewModel
{
    public class AddEmployeeViewModel : BindableBase
    {

        private string warningText;
        public string WarningText
        {
            get
            {
                return warningText;
            }
            set
            {
               SetProperty(ref warningText, value);
            }
        }


        private Employee newEmployee;
        public Employee NewEmployee
        {
            get { return newEmployee; }
            set {
                SetProperty(ref newEmployee, value);
            }
        }

        public CommandBase<Employee> AddEmployee
        {
            get; set;
        }

        public AddEmployeeViewModel()
        {
            AddEmployee = new CommandBase<Employee>(OnAddEmployee, CanAddEmployee);

            NewEmployee = new Employee
            {
                Name = "",
                PreferredName = "",
                DateOfBirth = DateTime.Today,
                PhoneNumber = "",
                PhoneNumber2 = "",
                Email = "",
                Email2 = "",
                Username = "",
                Alias = "",
                Address = "",
                Address2 = "",
                City = "",
                ZipCode = 0,
                DateOfHire = DateTime.Today,
                Active = true,
                Temporary = false,
                JobTitle = "",
                Department = "",
                Manager = "",
                Salary = 0,
                SSN = 0,
            };
        }

        private void OnAddEmployee(Employee e)
        {
            if (e.Name.Equals("") || e.Username.Equals("") || e.Email.Equals(""))
            {
                WarningText = "Please provide a name, username, and email for the user.";
            } else
            {
                var locate = DBConnection.Instance.collection.Find(emp => emp.Name == e.Name).ToList().Count > 0;
                if (!locate)
                {
                    e.Id = new ObjectId();
                    DBConnection.Instance.collection.InsertOne(e);
                }
                else
                {
                    WarningText = "Employee already exists!";
                }
            }
        }

        private bool CanAddEmployee(Employee _)
        {

            return true; //(newEmployee != null) && (!newEmployee.Username.Equals(""));
        }

    }
}
