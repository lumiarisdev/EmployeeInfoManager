using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;
using EmployeeInfoManager.Model;


namespace EmployeeInfoManager
{
    public class DBConnection
    {

        private static DBConnection instance;
        public static DBConnection Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new DBConnection();
                }
                return instance;
            }
            set
            {
                instance = value;
            }

        }

        public MongoClient client;
        public IMongoDatabase db;
        public IMongoCollection<Employee> collection;
        private const string defaultConnection = "mongodb+srv://ziegw1:EMOv5e5SOsV2EZwI@employeeappcluster.d4xux.mongodb.net/employee_db?retryWrites=true&w=majority";

        public bool Connected { get; set; }

        public DBConnection()
        {

            try
            {
                client = new MongoClient(defaultConnection);
                Connected = true;
            }
            catch(MongoConfigurationException)
            {
                Connected = false;
            }

            if(Connected)
            {
                db = client.GetDatabase("employee_db");
                collection = db.GetCollection<Employee>("employee_c");
            }

        }

        public DBConnection(string cString)
        {
            try
            {
                client = new MongoClient(cString);
                Connected = true;
            }
            catch (MongoConfigurationException)
            {
                Connected = false;
            }

            db = client.GetDatabase("employee_db");
            collection = db.GetCollection<Employee>("employee_c");

        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            var list = new List<Employee>();
            foreach(Employee employee in collection.Find(e => e.Id != null).ToList())
            {
                list.Add(employee);
            }
            return list;
        }

        public IEnumerable<Employee> GetAllCurrentEmployees()
        {
            var list = new List<Employee>();
            foreach(Employee employee in collection.Find(e => e.Active == true).ToList())
            {
                list.Add(employee);
            }
            return list;
        }

        public IEnumerable<Employee> GetAllFormerEmployees()
        {
            var list = new List<Employee>();
            foreach(Employee employee in collection.Find(e => e.Active == false).ToList())
            {
                list.Add(employee);
            }
            return list;
        }

        /*public IEnumerable<Employee> Get()
        {
            return collection.Find(e => e.Active == true).ToList();
        }*/

    }
}
