using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeInfoManager.Model;

namespace EmployeeInfoManager.ViewModel
{
    public class EmployeeListViewModel : BindableBase
    {

        public EmployeeListViewModel()
        {
            LoadEmployees();
        }

        public ObservableCollection<Employee> Employees { get; set; }

        public void LoadEmployees()
        {
            ObservableCollection<Employee> employees = new ObservableCollection<Employee>
            {
                new Employee { Name = "Joe Schmoe", Username = "jschmoe011", Email = "joe@schmoe.net" },
            };

            Employees = employees;
        }

    }
}
