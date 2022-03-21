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

    public class CustomerRepository
    {
        private DataAccess Da { get; set; }
        public CustomerRepository()
        {
            this.Da = new DataAccess();
        }
        public List<Customer> GetAllCustomer(string key)
        {
            List<Customer> customerList = new List<Customer>();

            string sql;

            try
            {
                if (key == null)
                    sql = "select * from Customer;";
                else
                    sql = "select * from Customer where CusId like  '%"+key+ "%' or CusName like '%" + key + "%';";

                var dt = this.Da.ExecuteQueryTable(sql);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Customer c = this.ConvertToEntity(dt.Rows[i]);
                    customerList.Add(c);
                }

                return customerList;
            }
            catch (Exception e)
            {
                return null;
            }

        }
        private Customer ConvertToEntity(DataRow row)
        {
            if (row == null)
                return null;

            var customer = new Customer();

            customer.CusId = row["CusId"].ToString();
            customer.CusName = row["CusName"].ToString();
            customer.CusPass = row["CusPass"].ToString();
            customer.CusPhnNo = row["CusPhnNo"].ToString();
            customer.CusAccNo = row["CusAccNo"].ToString();
            customer.CusAccCreatDate = row["CusAccCreatDate"].ToString();
            customer.CusEmail = row["CusEmail"].ToString();
            customer.CusAccBalance = row["CusAccBalance"].ToString();
            customer.Role = row["Role"].ToString();

            return customer;
        }

        public void RemoveCustomer(string id)
        {
            var sql = "Delete From Customer Where CusId = '" + id + "';";
            this.Da.ExecuteDML(sql);
        }
    }
}
