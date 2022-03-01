using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeInfoManager.Model
{
    public class ConnectionString : BindableBase
    {

        private string cString;
        public string CString { get { return cString; } set { SetProperty(ref cString, value); } }

    }
}
