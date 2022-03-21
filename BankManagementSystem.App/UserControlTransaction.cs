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
    public partial class UserControlTransaction : UserControl
    {
        private TransactionRepository TransactionRepo { get; set; }
        public UserControlTransaction()
        {
            InitializeComponent();
            this.TransactionRepo = new TransactionRepository();
            txtSearchTransaction.ForeColor = SystemColors.GrayText;
            txtSearchTransaction.Text = "Search by Account Number";
            this.txtSearchTransaction.Leave += new System.EventHandler(this.txtSearchTransaction_Leave);
            this.txtSearchTransaction.Enter += new System.EventHandler(this.txtSearchTransaction_Enter);

        }

        private void PopulateGrideViewTransaction(string SearchKey=null)
        {
            this.dgvTransaction.AutoGenerateColumns = false;
            this.dgvTransaction.DataSource = this.TransactionRepo.GetAllTransaction(SearchKey).ToList();
            this.dgvTransaction.ClearSelection();
            this.dgvTransaction.Refresh();
        }

        private void UserControlTransaction_Load(object sender, EventArgs e)
        {
            this.PopulateGrideViewTransaction();
        }

        private void txtSearchTransaction_TextChanged(object sender, EventArgs e)
        {
            this.PopulateGrideViewTransaction(this.txtSearchTransaction.Text);
        }

        private void txtSearchTransaction_Enter(object sender, EventArgs e)
        {
            if (txtSearchTransaction.Text == "Search by Account Number")
            {
                this.txtSearchTransaction.Text = "";
                this.txtSearchTransaction.ForeColor = SystemColors.WindowText;
            }
        }

        private void txtSearchTransaction_Leave(object sender, EventArgs e)
        {
            if (txtSearchTransaction.Text.Length == 0)
            {
                this.txtSearchTransaction.Text = "Search by Account Number";
                this.txtSearchTransaction.ForeColor = SystemColors.GrayText;
            }
        }

        private void btnSearchMainTransaction_Click(object sender, EventArgs e)
        {
            if (this.txtSearchTransaction.Text == "Search by Account Number")
            {
                MessageBox.Show("Please Enter Your Search text", "Empty!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.PopulateGrideViewTransaction();
                return;
            }
            this.PopulateGrideViewTransaction(this.txtSearchTransaction.Text);

            if (this.dgvTransaction.CurrentRow == null)
            {
                MessageBox.Show("No Data Found", "Opps!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }

        }

        private void btnClearSearchTransaction_Click(object sender, EventArgs e)
        {
            this.txtSearchTransaction.Text = "";
            if (txtSearchTransaction.Text.Length == 0)
            {
                this.txtSearchTransaction.Text = "Search by Account Number";
                this.txtSearchTransaction.ForeColor = SystemColors.GrayText;
            }
            this.PopulateGrideViewTransaction();

        }

        private void btnInsertTransaction_Click(object sender, EventArgs e)
        {

        }
    }
}
