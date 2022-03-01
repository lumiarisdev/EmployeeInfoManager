using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeInfoManager.Model;

namespace EmployeeInfoManager.ViewModel
{
    public class AddEmployeeViewModel : BindableBase
    {

        private Employee newEmployee;
        public Employee NewEmployee
        {
            get { return newEmployee; }
            set { SetProperty(ref newEmployee, value); }
        }

        public AddEmployeeViewModel()
        {
            NewEmployee = new Employee { Active = true };
        }

    }
}
