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
    public class TransactionRepository
    {
        private DataAccess Da { get; set; }
        public TransactionRepository()
        {
            this.Da = new DataAccess();
        }
        public List<Transaction> GetAllTransaction(string key)
        {
            List<Transaction> transactionList = new List<Transaction>();

            string sql;

            try
            {
                if (key == null)
                    sql = "select * from TransactionTable;";
                else
                    sql = "select * from TransactionTable where AccountNo like  '%" + key + "%';";

                var dt = this.Da.ExecuteQueryTable(sql);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Transaction t = this.ConvertToEntity(dt.Rows[i]);
                    transactionList.Add(t);
                }

                return transactionList;
            }
            catch (Exception e)
            {
                return null;
            }

        }
        private Transaction ConvertToEntity(DataRow row)
        {
            if (row == null)
                return null;

            var transaction = new Transaction();

            transaction.Account_No = row["AccountNo"].ToString();
            transaction.Deposite = row["Deposite"].ToString();
            transaction.Withdraw = row["Withdraw"].ToString();
            transaction.Transaction_Time = row["TransactionTime"].ToString();
            return transaction;
        }
    }
}
