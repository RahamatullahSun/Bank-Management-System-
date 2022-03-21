using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManagementSystem.Entity
{
    public class Customer
    {
        public string CusId { get; set; }
        public string CusPass { get; set; }
        public string CusName { get; set; }
        public string CusAccNo { get; set; }
        public string CusAccCreatDate { get; set; }
        public string CusAccBalance { get; set; }
        public string CusPhnNo { get; set; }
        public string CusEmail { get; set; }
        public string Role { get; set; }
    }
}
