using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeInfoManager.Command;
using EmployeeInfoManager.Model;
using MongoDB.Driver;
using System.Windows;

namespace EmployeeInfoManager.ViewModel
{

    public enum SearchType
    {
        Username,
        Email,
        Alias,
        Name,
        PhoneNumber
    }

    public class MainWindowViewModel : BindableBase
    {

        private static MainWindowViewModel instance;
        public static MainWindowViewModel Instance
        {
            get
            {
                return instance;
            }
            set
            {
                instance = value;
            }
        }

        public MainWindowViewModel()
        {
            if(instance == null)
            {
                instance = this;
            }
            CurrentViewModel = homeViewModel;
            NavCommand = new CommandBase<string>(OnNav);

            SearchCommand = new CommandBase<string>(OnSearch, CanSearch);
            SearchInput = new Employee
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

            DBPrompt = new CommandBase<string>(OnDBPrompt, CanDBPrompt);

        }

        private EmployeeListViewModel employeeListViewModel = new EmployeeListViewModel();

        private EmployeeViewModel employeeViewModel = new EmployeeViewModel();

        private AddEmployeeViewModel addEmployeeViewModel = new AddEmployeeViewModel();

        private HomeViewModel homeViewModel = new HomeViewModel();

        private SearchType currentSearchType;
        public SearchType CurrentSearchType
        {
            get { return currentSearchType; }
            set
            {
                SetProperty(ref currentSearchType, value);
            }
        }

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

        public CommandBase<string> DBPrompt { get; set; }

        public CommandBase<string> NavCommand { get; private set; }

        private Employee searchInput;
        public Employee SearchInput
        {
            get { return searchInput; }
            set { SetProperty(ref searchInput, value); }
        }

        public CommandBase<string> SearchCommand
        {
            get; set;
        }

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

        private void OnSearch(string s)
        {

            List<Employee> search;

            switch(CurrentSearchType)
            {
                case SearchType.Username:
                default:
                    search = DBConnection.Instance.collection.Find(e => e.Username.Contains(s)).ToList();
                    break;
                case SearchType.Email:
                    search = DBConnection.Instance.collection.Find(e => e.Email.Contains(s)).ToList();
                    break;
                case SearchType.Alias:
                    search = DBConnection.Instance.collection.Find(e => e.Alias.Contains(s)).ToList();
                    break;
                case SearchType.Name:
                    search = DBConnection.Instance.collection.Find(e => e.Name.Contains(s)).ToList();
                    break;
                case SearchType.PhoneNumber:
                    search = DBConnection.Instance.collection.Find(e => e.PhoneNumber.Contains(s)).ToList();
                    break;
            }

            employeeListViewModel.Employees.Clear();

            search.ForEach(emp => employeeListViewModel.Employees.Add(emp));
            CurrentViewModel = employeeListViewModel;

        }

        private bool CanSearch(string s)
        {
            return true;
        }

        private void OnDBPrompt(string s)
        {

            var prompt = new Views.DBPromptView();
            prompt.ShowDialog();

        }

        private bool CanDBPrompt(string _)
        {
            return true;
        }

    }
}
