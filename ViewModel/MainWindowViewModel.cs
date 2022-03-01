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
            CurrentViewModel = homeViewModel;
            NavCommand = new CommandBase<string>(OnNav);
        }

        private EmployeeListViewModel employeeListViewModel = new EmployeeListViewModel();

        private EmployeeViewModel employeeViewModel = new EmployeeViewModel();

        private AddEmployeeViewModel addEmployeeViewModel = new AddEmployeeViewModel();

        private HomeViewModel homeViewModel = new HomeViewModel();
        
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

        public CommandBase<string> NavCommand { get; private set; }

        private void OnNav(string destination)
        {
            switch(destination)
            {
                case "employee":
                    CurrentViewModel = employeeViewModel;
                    employeeViewModel.Employee = employeeListViewModel.SelectedEmployee;
                    break;
                case "addEmployee":
                    CurrentViewModel = addEmployeeViewModel;
                break;
                case "employeelist":
                    employeeListViewModel.Employees.Clear();
                    foreach(Employee e in DBConnection.Instance.GetAllEmployees())
                    {
                        employeeListViewModel.Employees.Add(e);
                    }
                    CurrentViewModel = employeeListViewModel;
                break;
                case "home":
                default:
                    CurrentViewModel = homeViewModel;
                break;
            }
        }


    }
}
