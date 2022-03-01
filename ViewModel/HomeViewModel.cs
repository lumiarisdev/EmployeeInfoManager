using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeInfoManager.Model;

namespace EmployeeInfoManager.ViewModel
{
    public class HomeViewModel : BindableBase
    {

        private Employee searchInput;
        public Employee SearchInput
        {
            get { return searchInput; }
            set { SetProperty(ref searchInput, value); }
        }

        public HomeViewModel()
        {
            SearchInput = new Employee
            {
                Name = "",
                PreferredName = "",
                DateOfBirth = DateTime.Today,
                PhoneNumber = "",
                PhoneNumber2 = "",
                Email = "",
                Email2 ="",
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
        }

    }
}
