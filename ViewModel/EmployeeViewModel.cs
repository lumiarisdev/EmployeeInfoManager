using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeInfoManager.Model;
using EmployeeInfoManager.Command;

namespace EmployeeInfoManager.ViewModel
{
    public class EmployeeViewModel : BindableBase
    {

        private Employee employee;
        public Employee Employee
        {
            get { return employee; }
            set { SetProperty(ref employee, value); }
        }

        public CommandBase<string> SaveRecord;

        public EmployeeViewModel()
        {
            Employee = new Employee { Name = "test"};
        }

        public EmployeeViewModel(Employee employee)
        {
            Employee = employee;
        }

        private void OnSave()
        {
            // save to db
        }

        private bool CanSave()
        {
            return true;
        }

    }
}
