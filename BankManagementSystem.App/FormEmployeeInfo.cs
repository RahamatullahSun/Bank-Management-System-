using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BankManagementSystem.Entity;
using BankManagementSystem.Repository;

namespace BankManagementSystem.App
{
    public partial class FormEmployeeInfo : Form
    {
        private EmployeeRepository EmployeeRepo { get; set; }
        private Delegate.RefreshGrid RefreshGrid { get; set; }
        public FormEmployeeInfo()
        {           
            InitializeComponent();            
        }

        public FormEmployeeInfo(EmployeeRepository er, Delegate.RefreshGrid refresh):this()
        {
            this.EmployeeRepo = er;
            this.RefreshGrid = refresh;
            this.AutoIdGenerate();
        }

        public FormEmployeeInfo(EmployeeRepository e, Delegate.RefreshGrid refresh, string empId, string empName, string EmpEmail, string EmpPass, string EmpAddress, string EmpJoiningDate, string EmpPhnNo, string EmpGender, string Role, string EmpSalary) :this()
        {
            this.EmployeeRepo = e;
            this.RefreshGrid = refresh;
            this.txtIdEmp.Text = empId;
            this.txtNameEmp.Text = empName;
            this.txtEmailEmp.Text = EmpEmail;
            this.txtPassEmp.Text = EmpPass;
            this.txtAddEmp.Text = EmpAddress;
            this.dtpEmp.Text = EmpJoiningDate;
            this.txtPhnNoEmp.Text = EmpPhnNo;
            this.cmbGemderEmp.Text = EmpGender;
            this.txtRoleEmp.Text = Role;
            this.txtSalaryEmp.Text = EmpSalary;
        }

        private void btnConfirmEmp_Click(object sender, EventArgs e)
        {

            try
            {
                var empObject = this.FillEntity();


                if (empObject==null)
                {
                    MessageBox.Show("Information Missing!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var decision = this.EmployeeRepo.Save(empObject);
               if(decision)
                {
                    MessageBox.Show("Employee Updated", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.RefreshGrid(null);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Data Insertion Failed!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show("Error : " + ex.Message);
            }
            this.Close();
        }

        private Employee FillEntity()
        {
            Employee emp = new Employee();

            emp.EmpId = this.txtIdEmp.Text;
            emp.EmpName = this.txtNameEmp.Text;
            emp.EmpPass = this.txtPassEmp.Text;
            emp.EmpPhnNo = this.txtPhnNoEmp.Text;
            emp.EmpAddress = this.txtAddEmp.Text;
            emp.EmpSalary = Convert.ToDouble(this.txtSalaryEmp.Text);
            emp.EmpJoiningDate = Convert.ToDateTime(this.dtpEmp.Value);
            emp.EmpEmail = this.txtEmailEmp.Text;
            emp.Role = this.txtRoleEmp.Text;
            emp.EmpGender = this.cmbGemderEmp.Text;
            

            return emp;
        }

        private void FillForm()
        {

        }

        private void btnRefreshEmp_Click(object sender, EventArgs e)
        {
            this.RefreshContent();
        }

        private void btnCancelEmp_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AutoIdGenerate()
        {

            string oldId = this.EmployeeRepo.GetOldId();
            string[] temp = oldId.Split('-');
            int num = Convert.ToInt32(temp[1]);
            string newId = "E-" + (++num).ToString("d3");
            this.txtIdEmp.Text = newId;
            this.txtRoleEmp.Text = "Employee";
        }
        private void RefreshContent()
        {
            this.txtIdEmp.Clear();
            this.txtEmailEmp.Clear();
            this.txtNameEmp.Clear();
            this.txtAddEmp.Clear();
            this.txtPhnNoEmp.Clear();
            this.txtSalaryEmp.Clear();
            this.cmbGemderEmp.Text = "";
            this.txtRoleEmp.Clear();
            this.txtPassEmp.Clear();
            this.AutoIdGenerate();
        }

        private void FormEmployeeInfo_Load(object sender, EventArgs e)
        {
            this.cmbGemderEmp.SelectedIndex = 0;
        }
    }
}
