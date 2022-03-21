using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BankManagementSystem.Repository;
using BankManagementSystem.Entity;

namespace BankManagementSystem.App
{
    public partial class userControlEmployee : UserControl
    {
        private EmployeeRepository EmployeeRepo { get; set; }
        public userControlEmployee()
        {           
            InitializeComponent();
            this.EmployeeRepo = new EmployeeRepository();
            txtSearchEmp.ForeColor = SystemColors.GrayText;
            txtSearchEmp.Text = "Search by Name or ID";
            this.txtSearchEmp.Leave += new System.EventHandler(this.txtSearchEmp_Leave);
            this.txtSearchEmp.Enter += new System.EventHandler(this.txtSearchEmp_Enter);
           // this.PolpulateGridViewEmployee();
           // this.dgvEmployee.ClearSelection();
        }

        private void PolpulateGridViewEmployee(string searchKey=null)
        {
            this.dgvEmployee.AutoGenerateColumns = false;
            this.dgvEmployee.DataSource = this.EmployeeRepo.GetAllEmployee(searchKey).ToList();
            this.dgvEmployee.ClearSelection();
            this.dgvEmployee.Refresh();
        }

        private void userControlEmployee_Load(object sender, EventArgs e)
        {
            this.PolpulateGridViewEmployee();
            this.dgvEmployee.ClearSelection();
        }

        private void txtSearchEmp_TextChanged(object sender, EventArgs e)
        {
            this.PolpulateGridViewEmployee(this.txtSearchEmp.Text);
        }

        private void btnSearchMainEmp_Click(object sender, EventArgs e)
        {
            

            if (this.txtSearchEmp.Text == "Search by Name or ID")
            {
                MessageBox.Show("Please Enter Your Search text", "Empty!!", MessageBoxButtons.OK, MessageBoxIcon.Error);               
                this.PolpulateGridViewEmployee();
                return;
            }
            this.PolpulateGridViewEmployee(this.txtSearchEmp.Text);

             if(this.dgvEmployee.CurrentRow==null)
             {
             MessageBox.Show("No Data Found", "Opps!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
             return;
             }

        }

        private void btnClearSearchEmp_Click(object sender, EventArgs e)
        {
            this.txtSearchEmp.Text = "";
            if (txtSearchEmp.Text.Length == 0)
            {
                txtSearchEmp.Text = "Search by Name or ID";
                txtSearchEmp.ForeColor = SystemColors.GrayText;
            }
            this.PolpulateGridViewEmployee();
        }

        private void txtSearchEmp_Enter(object sender, EventArgs e)
        {
            if (txtSearchEmp.Text == "Search by Name or ID")
            {
                txtSearchEmp.Text = "";
                txtSearchEmp.ForeColor = SystemColors.WindowText;
            }
        }

        private void txtSearchEmp_Leave(object sender, EventArgs e)
        {

            if (txtSearchEmp.Text.Length==0)
            {
                txtSearchEmp.Text = "Search by Name or ID";
                txtSearchEmp.ForeColor = SystemColors.GrayText;
            }
        }

        private void btnRemoveEmp_Click(object sender, EventArgs e)
        {
            if (dgvEmployee.SelectedRows.Count < 1)
            {
                MessageBox.Show("Please Select a Row First To Delete", "Opps!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var msg = "Are You Sure Want to Delete?";

            DialogResult result = MessageBox.Show(msg, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);

            if(result==DialogResult.Yes)
            {
                this.EmployeeRepo.RemoveEmployee(this.dgvEmployee.CurrentRow.Cells["EmpId"].Value.ToString());

                MessageBox.Show("Employee Removed", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.PolpulateGridViewEmployee();
            }
            else
            {
                this.dgvEmployee.ClearSelection();
                this.dgvEmployee.Refresh();
            }
        }

        private void btnInsertEmp_Click(object sender, EventArgs e)
        {
             Delegate.RefreshGrid refresh = this.PolpulateGridViewEmployee;
             new FormEmployeeInfo(EmployeeRepo, refresh).Show();
            
        }

        private void dgvEmployee_DoubleClick(object sender, EventArgs e)
        {
            // this.PolpulateGridViewEmployee(this.dgvEmployee.CurrentRow.Cells["EmpId"].Value.ToString());
            //Delegate.RefreshGrid refresh = this.PolpulateGridViewEmployee;
            //new FormEmployeeInfo(EmployeeRepo, refresh).Show();
            //var emp = new Employee();


            var msg = "Are You Sure Want to Edit?";

            DialogResult result = MessageBox.Show(msg, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);

            if (result == DialogResult.Yes)
            {

                string EmpId = this.dgvEmployee.CurrentRow.Cells["EmpId"].Value.ToString();
                string EmpName = this.dgvEmployee.CurrentRow.Cells["EmpName"].Value.ToString();
                string EmpEmail = this.dgvEmployee.CurrentRow.Cells["EmpEmail"].Value.ToString();
                string EmpPass = this.dgvEmployee.CurrentRow.Cells["EmpPass"].Value.ToString();
                string EmpAddress = this.dgvEmployee.CurrentRow.Cells["EmpAddress"].Value.ToString();
                string EmpJoiningDate = this.dgvEmployee.CurrentRow.Cells["EmpJoiningDate"].Value.ToString();
                string EmpPhnNo = this.dgvEmployee.CurrentRow.Cells["EmpPhnNo"].Value.ToString();
                string EmpGender = this.dgvEmployee.CurrentRow.Cells["EmpGender"].Value.ToString();
                string Role = this.dgvEmployee.CurrentRow.Cells["Role"].Value.ToString();
                string EmpSalary = this.dgvEmployee.CurrentRow.Cells["EmpSalary"].Value.ToString();
                Delegate.RefreshGrid refresh = this.PolpulateGridViewEmployee;

                new FormEmployeeInfo(EmployeeRepo, refresh, EmpId, EmpName, EmpEmail, EmpPass, EmpAddress, EmpJoiningDate, EmpPhnNo, EmpGender, Role, EmpSalary).Show();

            }
            else
            {
                this.dgvEmployee.ClearSelection();
                this.dgvEmployee.Refresh();
            }
        }

        private void btnRefreshEmp_Click(object sender, EventArgs e)
        {
            this.PolpulateGridViewEmployee();
        }

        private void btnEditEmp_Click(object sender, EventArgs e)
        {

            if (dgvEmployee.SelectedRows.Count < 1)
            {
                MessageBox.Show("Please Select a Row First To Edit", "Opps!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var msg = "Are You Sure Want to Edit?";

            DialogResult result = MessageBox.Show(msg, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);

            if (result == DialogResult.Yes)
            {

                string EmpId = this.dgvEmployee.CurrentRow.Cells["EmpId"].Value.ToString();
                string EmpName = this.dgvEmployee.CurrentRow.Cells["EmpName"].Value.ToString();
                string EmpEmail = this.dgvEmployee.CurrentRow.Cells["EmpEmail"].Value.ToString();
                string EmpPass = this.dgvEmployee.CurrentRow.Cells["EmpPass"].Value.ToString();
                string EmpAddress = this.dgvEmployee.CurrentRow.Cells["EmpAddress"].Value.ToString();
                string EmpJoiningDate = this.dgvEmployee.CurrentRow.Cells["EmpJoiningDate"].Value.ToString();
                string EmpPhnNo = this.dgvEmployee.CurrentRow.Cells["EmpPhnNo"].Value.ToString();
                string EmpGender = this.dgvEmployee.CurrentRow.Cells["EmpGender"].Value.ToString();
                string Role = this.dgvEmployee.CurrentRow.Cells["Role"].Value.ToString();
                string EmpSalary = this.dgvEmployee.CurrentRow.Cells["EmpSalary"].Value.ToString();
                Delegate.RefreshGrid refresh = this.PolpulateGridViewEmployee;

                new FormEmployeeInfo(EmployeeRepo, refresh, EmpId, EmpName, EmpEmail, EmpPass, EmpAddress, EmpJoiningDate, EmpPhnNo, EmpGender, Role, EmpSalary).Show();

            }
            else
            {
                this.dgvEmployee.ClearSelection();
                this.dgvEmployee.Refresh();
            }
        }
    }
}
