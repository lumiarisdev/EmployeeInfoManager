using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeInfoManager.Model;
using EmployeeInfoManager.Command;
using MongoDB.Driver;

namespace EmployeeInfoManager.ViewModel
{
    public class EmployeeViewModelImmut : BindableBase
    {

        private Employee employee;
        public Employee Employee
        {
            get { return employee; }
            set
            {
                SetProperty(ref employee, value);
            }
        }

    }
}
