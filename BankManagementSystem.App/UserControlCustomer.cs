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
 
    public partial class UserControlCustomer : UserControl
    {
        private CustomerRepository CustomerRepo { get;set; }
        public UserControlCustomer()
        {
            InitializeComponent();
            this.CustomerRepo = new CustomerRepository();
            txtSearchCus.ForeColor = SystemColors.GrayText;
            txtSearchCus.Text = "Search by Name or ID";
            this.txtSearchCus.Leave += new System.EventHandler(this.txtSearchCus_Leave);
            this.txtSearchCus.Enter += new System.EventHandler(this.txtSearchCus_Enter);

        }

        private void PolpulateGridViewCustomer(string searchKey = null)
        {
            this.dgvCustomer.AutoGenerateColumns = false;
            this.dgvCustomer.DataSource = this.CustomerRepo.GetAllCustomer(searchKey).ToList();
            this.dgvCustomer.ClearSelection();
            this.dgvCustomer.Refresh();
        }

        private void UserControlCustomer_Load(object sender, EventArgs e)
        {
            this.PolpulateGridViewCustomer();
        }

        private void btnSearchMainCus_Click(object sender, EventArgs e)
        {
            if (this.txtSearchCus.Text == "Search by Name or ID")
            {
                MessageBox.Show("Please Enter Your Search text", "Empty!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.PolpulateGridViewCustomer();
                return;
            }
            this.PolpulateGridViewCustomer(this.txtSearchCus.Text);

            if (this.dgvCustomer.CurrentRow == null)
            {
                MessageBox.Show("No Data Found", "Opps!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
        }

        private void txtSearchCus_TextChanged(object sender, EventArgs e)
        {
            this.PolpulateGridViewCustomer(this.txtSearchCus.Text);
        }

        private void btnClearSearchCus_Click(object sender, EventArgs e)
        {
            this.txtSearchCus.Text = "";
            if (txtSearchCus.Text.Length == 0)
            {
                txtSearchCus.Text = "Search by Name or ID";
                txtSearchCus.ForeColor = SystemColors.GrayText;
            }
            this.PolpulateGridViewCustomer();
        }

        private void txtSearchCus_Enter(object sender, EventArgs e)
        {
            if (txtSearchCus.Text == "Search by Name or ID")
            {
                txtSearchCus.Text = "";
                txtSearchCus.ForeColor = SystemColors.WindowText;
            }
        }

        private void txtSearchCus_Leave(object sender, EventArgs e)
        {
            if (txtSearchCus.Text.Length == 0)
            {
                txtSearchCus.Text = "Search by Name or ID";
                txtSearchCus.ForeColor = SystemColors.GrayText;
            }
        }

        private void btnRemoveCus_Click(object sender, EventArgs e)
        {
            if (dgvCustomer.SelectedRows.Count < 1)
            {
                MessageBox.Show("Please Select a Row First To Delete", "Opps!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var msg = "Are You Sure Want to Delete?";

            DialogResult result = MessageBox.Show(msg, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);

            if (result == DialogResult.Yes)
            {
                this.CustomerRepo.RemoveCustomer(this.dgvCustomer.CurrentRow.Cells["CusId"].Value.ToString());

                MessageBox.Show("Employee Removed", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.PolpulateGridViewCustomer();
            }
            else
            {
                this.dgvCustomer.ClearSelection();
                this.dgvCustomer.Refresh();
            }
        }
    }
}
