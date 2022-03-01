using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeInfoManager.Model;
using EmployeeInfoManager.Command;
using MongoDB.Driver;
using MongoDB.Bson;

namespace EmployeeInfoManager.ViewModel
{
    public class EmployeeListViewModel : BindableBase
    {

        private Employee selectedEmployee;
        public Employee SelectedEmployee
        {
            get { return selectedEmployee; }
            set { 
                SetProperty(ref selectedEmployee, value);
            }
        }

        private static EmployeeListViewModel instance;
        public static EmployeeListViewModel Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new EmployeeListViewModel();
                }
                return instance;
            }
            set
            {
                instance = value;
            }
        }

        public EmployeeListViewModel()
        {

            Employees = new ObservableCollection<Employee>();

            LoadEmployees();
        }

        public ObservableCollection<Employee> Employees { get; set; }

        public void LoadEmployees(IEnumerable<Employee> e)
        {
            foreach(Employee emp in e)
            {
                Employees.Add(emp);
            }
        }

        public void LoadEmployees()
        {

            var currentEmployees = DBConnection.Instance.GetAllCurrentEmployees();
            LoadEmployees(currentEmployees);

        }
    }
}
