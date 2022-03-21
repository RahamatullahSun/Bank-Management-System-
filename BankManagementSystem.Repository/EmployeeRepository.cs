using System;
using System.Collections.Generic;
using System.Data;
using BankManagementSystem.Data;
using BankManagementSystem.Entity;

namespace BankManagementSystem.Repository
{
    public class EmployeeRepository
    {   
        private DataAccess Da { get; set; }
        public EmployeeRepository()
        {
            this.Da = new DataAccess();
        }

        public List<Employee> GetAllEmployee(string key)
        {
            List<Employee> employeeList = new List<Employee>();

            string sql;

            try
            {
                if (key == null)
                    sql = "select * from Employee;";
                else
                    sql = "select * from Employee where EmpId like  '%" + key + "%' or EmpName like '%" + key + "%';";


                var dt = this.Da.ExecuteQueryTable(sql);

                for(int i=0; i<dt.Rows.Count; i++)
                {
                    Employee e = this.ConvertToEntity(dt.Rows[i]);
                    employeeList.Add(e);
                }

               return employeeList;
            }
            catch(Exception ex)
            {
                return null;
            }
           
        }
    public string GetOldId()
        {
            var sql = "Select EmpId From Employee order by EmpId desc;";
            DataTable dt = this.Da.ExecuteQueryTable(sql);
            Employee e = this.AutoGenerate(dt.Rows[0]);
            return e.EmpId;
        }

        private Employee AutoGenerate(DataRow row)
        {
            if (row == null)
                return null;

            var employee = new Employee();

            employee.EmpId = row["EmpId"].ToString();
            

            return employee;
        }

        private Employee ConvertToEntity(DataRow row)
        {
            if (row == null)
                return null;

            var employee = new Employee();

            employee.EmpId = row["EmpId"].ToString();
            employee.EmpName = row["EmpName"].ToString();
            employee.EmpPass = row["EmpPass"].ToString();
            employee.EmpPhnNo = row["EmpPhnNo"].ToString();
            employee.EmpSalary = Convert.ToDouble(row["EmpSalary"].ToString());
            employee.EmpAddress = row["EmpAddress"].ToString();
            employee.EmpEmail = row["EmpEmail"].ToString();
            employee.EmpJoiningDate = Convert.ToDateTime(row["EmpJoiningDate"].ToString());
            employee.EmpGender = row["EmpGender"].ToString();
            employee.Role = row["Role"].ToString();

            return employee;
        }

        public void RemoveEmployee(string id)
        {
            var sql = "Delete From Employee Where EmpId = '" + id + "';";
            this.Da.ExecuteDML(sql);
        }

        public bool Save(Employee e)
        {
            try
            {
                var sql = "Select  * From Employee Where EmpId  = '"+e.EmpId+"';";
                var ds = this.Da.ExecuteQuery(sql);

               if(ds.Tables[0].Rows.Count==1)
                {
                    var sql1 = @"Update Employee
                                  set EmpId = '" + e.EmpId + @"',
                                      EmpName = '" + e.EmpName + @"',
                                      EmpPass = '" + e.EmpPass + @"',
                                      EmpSalary = '" + e.EmpSalary + @"',
                                      EmpAddress = '" + e.EmpAddress + @"',
                                      EmpJoiningDate = '" + e.EmpJoiningDate + @"',
                                      EmpPhnNo = '" + e.EmpPhnNo + @"',
                                      EmpGender = '" + e.EmpGender + @"',
                                      EmpEmail = '" + e.EmpEmail + @"',
                                      Role = '" + e.Role + @"'
                                      Where EmpId  = '" + e.EmpId + "';";
                    var rowCount = this.Da.ExecuteUpdateQuery(sql1);
                    if (rowCount == 1)
                        return true;
                    else
                        return false;
                }
                else
                {
                    var sql2 = "insert into  Employee values('" + e.EmpId + "', '" + e.EmpName + "','" + e.EmpPass + "','" + e.EmpSalary + "','" + e.EmpAddress + "','" + e.EmpJoiningDate + "','" + e.EmpPhnNo + "','" + e.EmpGender + "','" + e.EmpEmail + "','" + e.Role + "');";
                    var rowCount = this.Da.ExecuteUpdateQuery(sql2);
                    if (rowCount == 1)
                        return true;
                    else
                        return false;
                }
                
            }
            catch (Exception )
            {
                return false;
            }
        }


    }
}
