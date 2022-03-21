using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManagementSystem.Entity
{
    public class Transaction
    {
        public string Account_No { get; set; }
        public string Deposite { get; set; }
        public string Withdraw { get; set; }
        public string Transaction_Time { get; set; }
    }
}
