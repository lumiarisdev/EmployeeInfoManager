using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeInfoManager.Command;
using EmployeeInfoManager.Model;

namespace EmployeeInfoManager.ViewModel
{
    public class MainWindowViewModel : BindableBase
    {

        public MainWindowViewModel()
        {
            NavCommand = new CommandBase<string>(OnNav);
        }

        private EmployeeListViewModel employeeListViewModel = new EmployeeListViewModel();
        
        private EmployeeViewModel employeeViewModel = new EmployeeViewModel();

        private AddEmployeeViewModel addEmployeeViewModel = new AddEmployeeViewModel();

        private AddEmployeeNavViewModel addEmployeeNavViewModel = new AddEmployeeNavViewModel();

        private EmployeeNavViewModel employeeNavViewModel = new EmployeeNavViewModel();

        private EmployeeListNavViewModel employeeListNavViewModel = new EmployeeListNavViewModel();

        private BindableBase currentViewModel;

        public BindableBase CurrentViewModel
        {
            get
            {
                return currentViewModel;
            } 
            set
            {
                SetProperty(ref currentViewModel, value);
            }
        }

        private BindableBase currentNavViewModel;

        public BindableBase CurrentNavViewModel
        {
            get { return currentNavViewModel; }
            set
            {
                SetProperty(ref currentNavViewModel, value);
            }
        }

        public CommandBase<string> NavCommand { get; private set; }

        private void OnNav(string destination)
        {
            switch(destination)
            {
                case "employee":
                    CurrentViewModel = employeeViewModel;
                    CurrentNavViewModel = employeeNavViewModel;
                break;
                case "addEmployee":
                    CurrentViewModel = addEmployeeViewModel;
                    CurrentNavViewModel = addEmployeeNavViewModel;
                break;
                case "employeelist":
                default:
                    CurrentViewModel = employeeListViewModel;
                    CurrentNavViewModel = employeeListNavViewModel;
                break;
            }
        }

    }
}
