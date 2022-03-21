
namespace BankManagementSystem.App
{
    partial class TempManForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvManager = new System.Windows.Forms.DataGridView();
            this.ManagerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ManagerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ManagerPass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ManagerSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ManagerPhnNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ManagerAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ManagerEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ManagerJoiningDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnShowAllTransaction = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManager)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvManager
            // 
            this.dgvManager.AllowUserToAddRows = false;
            this.dgvManager.AllowUserToDeleteRows = false;
            this.dgvManager.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvManager.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ManagerId,
            this.ManagerName,
            this.ManagerPass,
            this.ManagerSalary,
            this.ManagerPhnNo,
            this.ManagerAddress,
            this.ManagerEmail,
            this.ManagerJoiningDate,
            this.Role});
            this.dgvManager.Location = new System.Drawing.Point(222, 69);
            this.dgvManager.Name = "dgvManager";
            this.dgvManager.ReadOnly = true;
            this.dgvManager.RowHeadersWidth = 51;
            this.dgvManager.RowTemplate.Height = 29;
            this.dgvManager.Size = new System.Drawing.Size(559, 285);
            this.dgvManager.TabIndex = 1;
            // 
            // ManagerId
            // 
            this.ManagerId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ManagerId.DataPropertyName = "ManagerId";
            this.ManagerId.HeaderText = "Id";
            this.ManagerId.MinimumWidth = 6;
            this.ManagerId.Name = "ManagerId";
            this.ManagerId.ReadOnly = true;
            // 
            // ManagerName
            // 
            this.ManagerName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ManagerName.DataPropertyName = "ManagerName";
            this.ManagerName.HeaderText = "Name";
            this.ManagerName.MinimumWidth = 6;
            this.ManagerName.Name = "ManagerName";
            this.ManagerName.ReadOnly = true;
            // 
            // ManagerPass
            // 
            this.ManagerPass.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ManagerPass.DataPropertyName = "ManagerPass";
            this.ManagerPass.HeaderText = "Password";
            this.ManagerPass.MinimumWidth = 6;
            this.ManagerPass.Name = "ManagerPass";
            this.ManagerPass.ReadOnly = true;
            // 
            // ManagerSalary
            // 
            this.ManagerSalary.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ManagerSalary.DataPropertyName = "ManagerSalary";
            this.ManagerSalary.HeaderText = "Salary";
            this.ManagerSalary.MinimumWidth = 6;
            this.ManagerSalary.Name = "ManagerSalary";
            this.ManagerSalary.ReadOnly = true;
            // 
            // ManagerPhnNo
            // 
            this.ManagerPhnNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ManagerPhnNo.DataPropertyName = "ManagerPhnNo";
            this.ManagerPhnNo.HeaderText = "PhoneNo";
            this.ManagerPhnNo.MinimumWidth = 6;
            this.ManagerPhnNo.Name = "ManagerPhnNo";
            this.ManagerPhnNo.ReadOnly = true;
            // 
            // ManagerAddress
            // 
            this.ManagerAddress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ManagerAddress.DataPropertyName = "ManagerAddress";
            this.ManagerAddress.HeaderText = "Address";
            this.ManagerAddress.MinimumWidth = 6;
            this.ManagerAddress.Name = "ManagerAddress";
            this.ManagerAddress.ReadOnly = true;
            // 
            // ManagerEmail
            // 
            this.ManagerEmail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ManagerEmail.DataPropertyName = "ManagerEmail";
            this.ManagerEmail.HeaderText = "E-Mail";
            this.ManagerEmail.MinimumWidth = 6;
            this.ManagerEmail.Name = "ManagerEmail";
            this.ManagerEmail.ReadOnly = true;
            // 
            // ManagerJoiningDate
            // 
            this.ManagerJoiningDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ManagerJoiningDate.DataPropertyName = "ManagerJoiningDate";
            this.ManagerJoiningDate.HeaderText = "JoiningDate";
            this.ManagerJoiningDate.MinimumWidth = 6;
            this.ManagerJoiningDate.Name = "ManagerJoiningDate";
            this.ManagerJoiningDate.ReadOnly = true;
            // 
            // Role
            // 
            this.Role.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Role.DataPropertyName = "Role";
            this.Role.HeaderText = "Role";
            this.Role.MinimumWidth = 6;
            this.Role.Name = "Role";
            this.Role.ReadOnly = true;
            // 
            // btnShowAllTransaction
            // 
            this.btnShowAllTransaction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(176)))), ((int)(((byte)(213)))));
            this.btnShowAllTransaction.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnShowAllTransaction.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(215)))), ((int)(((byte)(255)))));
            this.btnShowAllTransaction.FlatAppearance.BorderSize = 5;
            this.btnShowAllTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowAllTransaction.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnShowAllTransaction.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.btnShowAllTransaction.IconColor = System.Drawing.Color.Black;
            this.btnShowAllTransaction.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnShowAllTransaction.IconSize = 38;
            this.btnShowAllTransaction.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShowAllTransaction.Location = new System.Drawing.Point(0, 0);
            this.btnShowAllTransaction.Name = "btnShowAllTransaction";
            this.btnShowAllTransaction.Padding = new System.Windows.Forms.Padding(20, 0, 8, 0);
            this.btnShowAllTransaction.Size = new System.Drawing.Size(1753, 52);
            this.btnShowAllTransaction.TabIndex = 9;
            this.btnShowAllTransaction.Text = "ShowAll";
            this.btnShowAllTransaction.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnShowAllTransaction.UseVisualStyleBackColor = false;
            // 
            // TempManForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1753, 710);
            this.Controls.Add(this.btnShowAllTransaction);
            this.Controls.Add(this.dgvManager);
            this.Name = "TempManForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvManager)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn ManagerId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ManagerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ManagerPass;
        private System.Windows.Forms.DataGridViewTextBoxColumn ManagerSalary;
        private System.Windows.Forms.DataGridViewTextBoxColumn ManagerPhnNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ManagerAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn ManagerEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn ManagerJoiningDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Role;
        private FontAwesome.Sharp.IconButton btnShowAllTransaction;
    }
}