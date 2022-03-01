using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeInfoManager.Model;
using EmployeeInfoManager.Command;
using MongoDB.Driver;

namespace EmployeeInfoManager.ViewModel
{
    public class HomeViewModel : BindableBase
    {

        private string statusMessage;
        public string StatusMessage
        {
            get
            {
                return statusMessage;
            }
            set
            {
                SetProperty(ref statusMessage, value);
            }
        }

        private int employeeRecordsCount;
        public int EmployeeRecordsCount
        {
            get { return employeeRecordsCount; }
            set
            {
                SetProperty(ref employeeRecordsCount, value);
            }
        }

        private int activeEmployeesCount;
        public int ActiveEmployeesCount
        {
            get
            {
                return activeEmployeesCount;
            }
            set
            {
                SetProperty(ref activeEmployeesCount, value);
            }
        }

        public HomeViewModel()
        {

            if(DBConnection.Instance.client == null || DBConnection.Instance.db == null)
            {
                statusMessage = "Failed";
            } else if(DBConnection.Instance.collection == null)
            {
                statusMessage = "Warning | Collection Error";
            } else
            {
                statusMessage = "Connected";
            }
            if(DBConnection.Instance.Connected)
            {
                EmployeeRecordsCount = DBConnection.Instance.GetAllEmployees().Count();
                ActiveEmployeesCount = DBConnection.Instance.GetAllCurrentEmployees().Count();
            }

        }

    }

}
