using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using EmployeeInfoManager.Model;
using EmployeeInfoManager.ViewModel;

namespace EmployeeInfoManager.Views
{
    /// <summary>
    /// Interaction logic for AddEmployeeView.xaml
    /// </summary>
    public partial class AddEmployeeView : UserControl
    {
        public AddEmployeeView()
        {
            InitializeComponent();
        }

        public class AddEmployee_ClickEventArgs : EventArgs
        {
            public Employee? NewEmployee { get; set; }
        }

        private void AddEmployee_Click(object sender, AddEmployee_ClickEventArgs e)
        {
            // add employee to db
            // also add to the employee list view
            var b = (Button)sender;
            Employee n = (Employee)b.Tag;
            EmployeeListViewModel.Instance.Employees.Add(n);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
