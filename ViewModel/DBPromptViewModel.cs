using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeInfoManager.Model;
using EmployeeInfoManager.Command;
using MongoDB.Bson;
using MongoDB.Driver;

namespace EmployeeInfoManager.ViewModel
{
    public class DBPromptViewModel : BindableBase
    {

        public CommandBase<string> DBPromptInputButton { get; set; }

        private string dbPromptInput;
        public string DBPromptInput
        {
            get { return dbPromptInput; }
            set
            {
                SetProperty(ref dbPromptInput, value);
            }
        }

        public DBPromptViewModel()
        {
            dbPromptInput = DBConnection.Instance.client.Settings.Server.ToString();
            DBPromptInputButton = new CommandBase<string>(OnDBPromptInputButton, CanDBPromptInputButton);
        }

        private void OnDBPromptInputButton(string s)
        {
            DBConnection.Instance = new DBConnection(s);
            MainWindowViewModel.Instance.CurrentViewModel = new HomeViewModel();
        }

        private bool CanDBPromptInputButton(string s)
        {
            return true;
        }

    }
}
