using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;

//using Ilog;

namespace EmployeesDIR
{
    class Employee
    {
        private int id;
        private string name;
        private string number;
        private string comment;
        private string email;
        private string edu;
        private string salary;

        public Employee() { }
        public Employee(int id, string name, string number, string comment, string email, string edu, string salary)
        {
            this.id = id;
            this.name = name;
            this.number = number;
            this.comment = comment;
            this.email = email;
            this.edu = edu;
            this.salary = salary;
        }
        public int GetId() { return id; }
        

    }
    
    class General
    {
        public static readonly string title = "EmployeesDIR - 3.0";
        public static readonly ILog logger = LogManager.GetLogger(typeof(Program));
        public Dictionary<int,Employee> employees = new Dictionary<int,Employee>();
        General()
        {
            log4net.Config.BasicConfigurator.Configure();
#if DEBUG
            ((log4net.Repository.Hierarchy.Hierarchy)LogManager.GetRepository()).Root.Level = log4net.Core.Level.Debug;
#else
            ((log4net.Repository.Hierarchy.Hierarchy)LogManager.GetRepository()).Root.Level = log4net.Core.Level.Info;
#endif
        }
        public void AppendEmployee(int id, string name, string number, string comment, string email, string edu, string salary)
        {
            employees.Add(id, new Employee(id, name, number, comment, email, edu, salary));
            logger.InfoFormat("New employee:{name},id{id};{sex},{number},{comment},{email},{edu},{salary}", name, id, number, comment, email, edu, salary);
        }
    }
}
