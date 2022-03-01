using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeInfoManager.Model;
using EmployeeInfoManager.Command;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Windows;

namespace EmployeeInfoManager.ViewModel
{
    public class EmployeeViewModel : BindableBase
    {   

        private Employee employee;
        public Employee Employee
        {
            get { return employee; }
            set { 
                SetProperty(ref employee, value);
            }
        }

        public CommandBase<Employee> DeleteRecord
        {
            get; set;
        }
        public CommandBase<string> SaveRecord
        {
            get; set;
        }

        public EmployeeViewModel()
        {
            Employee = new Employee { Name = "test"};
            SaveRecord = new CommandBase<string>(OnSave, CanSave);
            DeleteRecord = new CommandBase<Employee>(OnDelete, CanDelete);
        }

        public EmployeeViewModel(Employee employee)
        {
            Employee = employee;
            SaveRecord = new CommandBase<string>(OnSave, CanSave);
            DeleteRecord = new CommandBase<Employee>(OnDelete, CanDelete);
        }

        private void OnSave(string _)
        {
            // save to db

            var filter = Builders<Employee>.Filter.Eq("_id", Employee.Id);

            var update = Builders<Employee>.Update.Set("name", Employee.Name);
            DBConnection.Instance.collection.UpdateOne(filter, update);

            update = Builders<Employee>.Update.Set("preferred_name", Employee.PreferredName);
            DBConnection.Instance.collection.UpdateOne(filter, update);

            update = Builders<Employee>.Update.Set("phone_number", Employee.PhoneNumber);
            DBConnection.Instance.collection.UpdateOne(filter, update);

            update = Builders<Employee>.Update.Set("phone_number_alternate", Employee.PhoneNumber2);
            DBConnection.Instance.collection.UpdateOne(filter, update);

            update = Builders<Employee>.Update.Set("email", Employee.Email);
            DBConnection.Instance.collection.UpdateOne(filter, update);

            update = Builders<Employee>.Update.Set("email_alternate", Employee.Email2);
            DBConnection.Instance.collection.UpdateOne(filter, update);

            update = Builders<Employee>.Update.Set("username", Employee.Username);
            DBConnection.Instance.collection.UpdateOne(filter, update);

            update = Builders<Employee>.Update.Set("alias", Employee.Alias);
            DBConnection.Instance.collection.UpdateOne(filter, update);

            update = Builders<Employee>.Update.Set("address", Employee.Address);
            DBConnection.Instance.collection.UpdateOne(filter, update);

            update = Builders<Employee>.Update.Set("address_line2", Employee.Address2);
            DBConnection.Instance.collection.UpdateOne(filter, update);

            update = Builders<Employee>.Update.Set("city", Employee.City);
            DBConnection.Instance.collection.UpdateOne(filter, update);

            update = Builders<Employee>.Update.Set("zipcode", Employee.ZipCode);
            DBConnection.Instance.collection.UpdateOne(filter, update);

            update = Builders<Employee>.Update.Set("date_hired", Employee.DateOfHire);
            DBConnection.Instance.collection.UpdateOne(filter, update);

            update = Builders<Employee>.Update.Set("date_separated", Employee.DateOfSeparation);
            DBConnection.Instance.collection.UpdateOne(filter, update);

            update = Builders<Employee>.Update.Set("active", Employee.Active);
            DBConnection.Instance.collection.UpdateOne(filter, update);

            update = Builders<Employee>.Update.Set("temp", Employee.Temporary);
            DBConnection.Instance.collection.UpdateOne(filter, update);

            update = Builders<Employee>.Update.Set("expiration", Employee.Expiration);
            DBConnection.Instance.collection.UpdateOne(filter, update);

            update = Builders<Employee>.Update.Set("job_title", Employee.JobTitle);
            DBConnection.Instance.collection.UpdateOne(filter, update);

            update = Builders<Employee>.Update.Set("department", Employee.Department);
            DBConnection.Instance.collection.UpdateOne(filter, update);

            update = Builders<Employee>.Update.Set("manager", Employee.Manager);
            DBConnection.Instance.collection.UpdateOne(filter, update);

            update = Builders<Employee>.Update.Set("salary", Employee.Salary);
            DBConnection.Instance.collection.UpdateOne(filter, update);

            update = Builders<Employee>.Update.Set("ssn", Employee.SSN);
            DBConnection.Instance.collection.UpdateOne(filter, update);

        }

        private bool CanSave(string _)
        {
            return true;
        }

        private void OnDelete(Employee _)
        {
            MessageBoxResult confirm =
                MessageBox.Show("Are you sure you want to permanently delete this user?", "Confirmation", MessageBoxButton.YesNo);

            if (confirm == MessageBoxResult.Yes)
            {
                // delete from database, return to homepage

                DBConnection.Instance.collection.DeleteOne(Builders<Employee>.Filter.Eq("_id", Employee.Id));
                MainWindowViewModel.Instance.CurrentViewModel = new HomeViewModel();
            }
            else if (confirm == MessageBoxResult.No)
            {

            }
            else if(confirm == MessageBoxResult.Cancel)
            {

            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private bool CanDelete(Employee _)
        {
            return true;
        }

    }
}
