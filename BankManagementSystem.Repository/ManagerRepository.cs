using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using BankManagementSystem.Data;
using BankManagementSystem.Entity;

namespace BankManagementSystem.Repository
{
    public class ManagerRepository
    {   

        private DataAccess Da { get; set; }
        public ManagerRepository()
        {
            this.Da = new DataAccess();
        }

        public List<Manager> GetAllManager()
        {
            List<Manager> managerList = new List<Manager>();

            string sql;
            try
            {
                
                sql = "select * from Manager;";


                var dt = this.Da.ExecuteQueryTable(sql);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Manager m = this.ConvertToEntity(dt.Rows[i]);
                    managerList.Add(m);
                }

                return managerList;
            }
            catch (Exception e)
            {
                return null;
            }

        }

        private Manager ConvertToEntity(DataRow row)
        {
            if (row == null)
                return null;

            var manager = new Manager();

            manager.ManagerId = row["ManagerId"].ToString();
            manager.ManagerName = row["ManagerName"].ToString();
            manager.ManagerPass = row["ManagerPass"].ToString();
            manager.ManagerPhnNo = row["ManagerPhnNo"].ToString();
            manager.ManagerSalary = row["ManagerSalary"].ToString();
            manager.ManagerAddress = row["ManagerAddress"].ToString();
            manager.ManagerEmail = row["ManagerEmail"].ToString();
            manager.ManagerJoiningDate = row["ManagerJoiningDate"].ToString();
            manager.Role = row["Role"].ToString();

            return manager;
        }
    }
}
