using System;

namespace BankManagementSystem.Entity
{
    public class Employee
    {
        public string EmpId { get; set; }
        public string EmpPass { get; set; }
        public string EmpName { get; set; }
        public double EmpSalary { get; set; }
        public string EmpAddress { get; set; }
        public DateTime EmpJoiningDate { get; set; }
        public string EmpPhnNo { get; set; }
        public string EmpEmail { get; set; }
        public string Role { get; set; }
        public string EmpGender { get; set; }
    }
}
