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
    public partial class FormManager : Form
    {
        public FormManager()
        {
            InitializeComponent();
            this.ManagerRepo = new ManagerRepository();
            UserControlLoader.openUserControl(new userControlEmployee(), pnlManager);
        }


        #region Buttons
        private void btnEmployee_Click(object sender, EventArgs e)
        {
            this.btnTransaction.Rotation = 0;
            this.btnCustomer.Rotation = 0;
            this.btnEmployee.Rotation = 270;
            UserControlLoader.openUserControl(new userControlEmployee(), pnlManager);
        }
        

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            this.btnEmployee.Rotation = 0;
            this.btnTransaction.Rotation = 0;
            this.btnCustomer.Rotation = 270;
            UserControlLoader.openUserControl(new UserControlCustomer(), pnlManager);
        }


        private void btnTransaction_Click(object sender, EventArgs e)
        {
            this.btnEmployee.Rotation = 0;
            this.btnTransaction.Rotation = 270;
            this.btnCustomer.Rotation = 0;
            UserControlLoader.openUserControl(new UserControlTransaction(), pnlManager);
        }

       #endregion
        private ManagerRepository ManagerRepo { get; set; }

        private void populateGridViewManager()
        {
            //this.dgvManager.AutoGenerateColumns = false;
           // this.dgvManager.DataSource = this.ManagerRepo.GetAllManager().ToList();
        }
        private void FormManager_Load(object sender, EventArgs e)
        {
            // this.populateGridViewManager();
           // UserControlLoader.openUserControl(new userControlEmployee(), pnlManager);
        }

    }
}