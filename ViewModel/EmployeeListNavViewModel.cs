using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeInfoManager.Command;
using EmployeeInfoManager.Model;

namespace EmployeeInfoManager.ViewModel
{
    public class EmployeeListNavViewModel : BindableBase
    {

        public CommandBase<string> ViewEmployeeCommand { get; set; }

        private Employee selectedEmployee;
        public Employee SelectedEmployee
        {
            get
            {
                return selectedEmployee;
            }
            set
            {
                selectedEmployee = value;
                ViewEmployeeCommand.OnCanExecuteChanged();
            }
        }

        public EmployeeListNavViewModel()
        {
            ViewEmployeeCommand = new CommandBase<string>(OnViewEmployee, CanViewEmployee);
        }

        private void OnViewEmployee(string username)
        {
            
        }

        private bool CanViewEmployee(string username)
        {
            return selectedEmployee != null;
        }

    }
}
