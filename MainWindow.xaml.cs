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
using EmployeeInfoManager.ViewModel;

namespace EmployeeInfoManager
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void EmployeeView_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var c = (ComboBox)sender;
            switch(c.SelectedIndex)
            {
                case 0:
                default:
                    MainWindowViewModel.Instance.CurrentSearchType = SearchType.Username;
                    break;
                case 1:
                    MainWindowViewModel.Instance.CurrentSearchType = SearchType.Email;
                    break;
                case 2:
                    MainWindowViewModel.Instance.CurrentSearchType = SearchType.Alias;
                    break;
            }
            

        }
    }
}
