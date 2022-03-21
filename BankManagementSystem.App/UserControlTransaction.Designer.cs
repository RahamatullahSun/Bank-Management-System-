
namespace BankManagementSystem.App
{
    partial class UserControlTransaction
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlUpTransaction = new System.Windows.Forms.Panel();
            this.lblTransaction = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnInsertTransaction = new FontAwesome.Sharp.IconButton();
            this.btnEditTransaction = new FontAwesome.Sharp.IconButton();
            this.btnRemoveTransaction = new FontAwesome.Sharp.IconButton();
            this.btnClearSearchTransaction = new FontAwesome.Sharp.IconButton();
            this.txtSearchTransaction = new System.Windows.Forms.TextBox();
            this.btnSearchMainTransaction = new FontAwesome.Sharp.IconButton();
            this.pnlDgvTransaction = new System.Windows.Forms.Panel();
            this.dgvTransaction = new System.Windows.Forms.DataGridView();
            this.Account_No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Deposite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Withdraw = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Transaction_Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlUpTransaction.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlDgvTransaction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransaction)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlUpTransaction
            // 
            this.pnlUpTransaction.BackColor = System.Drawing.Color.Aqua;
            this.pnlUpTransaction.Controls.Add(this.lblTransaction);
            this.pnlUpTransaction.Controls.Add(this.panel1);
            this.pnlUpTransaction.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUpTransaction.Location = new System.Drawing.Point(0, 0);
            this.pnlUpTransaction.Name = "pnlUpTransaction";
            this.pnlUpTransaction.Size = new System.Drawing.Size(1440, 187);
            this.pnlUpTransaction.TabIndex = 1;
            // 
            // lblTransaction
            // 
            this.lblTransaction.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTransaction.Font = new System.Drawing.Font("Times New Roman", 25.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTransaction.Location = new System.Drawing.Point(0, 0);
            this.lblTransaction.Name = "lblTransaction";
            this.lblTransaction.Size = new System.Drawing.Size(1440, 48);
            this.lblTransaction.TabIndex = 3;
            this.lblTransaction.Text = "Transaction";
            this.lblTransaction.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnInsertTransaction);
            this.panel1.Controls.Add(this.btnEditTransaction);
            this.panel1.Controls.Add(this.btnRemoveTransaction);
            this.panel1.Controls.Add(this.btnClearSearchTransaction);
            this.panel1.Controls.Add(this.txtSearchTransaction);
            this.panel1.Controls.Add(this.btnSearchMainTransaction);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 137);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1440, 50);
            this.panel1.TabIndex = 2;
            // 
            // btnInsertTransaction
            // 
            this.btnInsertTransaction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnInsertTransaction.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnInsertTransaction.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(215)))), ((int)(((byte)(255)))));
            this.btnInsertTransaction.FlatAppearance.BorderSize = 2;
            this.btnInsertTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsertTransaction.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnInsertTransaction.ForeColor = System.Drawing.Color.White;
            this.btnInsertTransaction.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.btnInsertTransaction.IconColor = System.Drawing.Color.White;
            this.btnInsertTransaction.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnInsertTransaction.IconSize = 40;
            this.btnInsertTransaction.Location = new System.Drawing.Point(885, 0);
            this.btnInsertTransaction.Name = "btnInsertTransaction";
            this.btnInsertTransaction.Padding = new System.Windows.Forms.Padding(27, 2, 0, 0);
            this.btnInsertTransaction.Size = new System.Drawing.Size(185, 50);
            this.btnInsertTransaction.TabIndex = 5;
            this.btnInsertTransaction.Text = "Add";
            this.btnInsertTransaction.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInsertTransaction.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnInsertTransaction.UseVisualStyleBackColor = false;
            this.btnInsertTransaction.Click += new System.EventHandler(this.btnInsertTransaction_Click);
            // 
            // btnEditTransaction
            // 
            this.btnEditTransaction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnEditTransaction.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnEditTransaction.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(215)))), ((int)(((byte)(255)))));
            this.btnEditTransaction.FlatAppearance.BorderSize = 2;
            this.btnEditTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditTransaction.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEditTransaction.ForeColor = System.Drawing.Color.White;
            this.btnEditTransaction.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            this.btnEditTransaction.IconColor = System.Drawing.Color.White;
            this.btnEditTransaction.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditTransaction.IconSize = 40;
            this.btnEditTransaction.Location = new System.Drawing.Point(1070, 0);
            this.btnEditTransaction.Name = "btnEditTransaction";
            this.btnEditTransaction.Padding = new System.Windows.Forms.Padding(28, 2, 0, 0);
            this.btnEditTransaction.Size = new System.Drawing.Size(185, 50);
            this.btnEditTransaction.TabIndex = 4;
            this.btnEditTransaction.Text = "Edit";
            this.btnEditTransaction.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditTransaction.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnEditTransaction.UseVisualStyleBackColor = false;
            // 
            // btnRemoveTransaction
            // 
            this.btnRemoveTransaction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnRemoveTransaction.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnRemoveTransaction.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(215)))), ((int)(((byte)(255)))));
            this.btnRemoveTransaction.FlatAppearance.BorderSize = 2;
            this.btnRemoveTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveTransaction.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRemoveTransaction.ForeColor = System.Drawing.Color.White;
            this.btnRemoveTransaction.IconChar = FontAwesome.Sharp.IconChar.UserMinus;
            this.btnRemoveTransaction.IconColor = System.Drawing.Color.White;
            this.btnRemoveTransaction.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRemoveTransaction.IconSize = 40;
            this.btnRemoveTransaction.Location = new System.Drawing.Point(1255, 0);
            this.btnRemoveTransaction.Name = "btnRemoveTransaction";
            this.btnRemoveTransaction.Padding = new System.Windows.Forms.Padding(8, 2, 0, 0);
            this.btnRemoveTransaction.Size = new System.Drawing.Size(185, 50);
            this.btnRemoveTransaction.TabIndex = 3;
            this.btnRemoveTransaction.Text = "Remove";
            this.btnRemoveTransaction.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemoveTransaction.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnRemoveTransaction.UseVisualStyleBackColor = false;
            // 
            // btnClearSearchTransaction
            // 
            this.btnClearSearchTransaction.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnClearSearchTransaction.BackColor = System.Drawing.Color.Gainsboro;
            this.btnClearSearchTransaction.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnClearSearchTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearSearchTransaction.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClearSearchTransaction.ForeColor = System.Drawing.Color.White;
            this.btnClearSearchTransaction.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnClearSearchTransaction.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClearSearchTransaction.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClearSearchTransaction.IconSize = 50;
            this.btnClearSearchTransaction.Location = new System.Drawing.Point(813, 1);
            this.btnClearSearchTransaction.Name = "btnClearSearchTransaction";
            this.btnClearSearchTransaction.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.btnClearSearchTransaction.Size = new System.Drawing.Size(76, 49);
            this.btnClearSearchTransaction.TabIndex = 2;
            this.btnClearSearchTransaction.UseVisualStyleBackColor = false;
            this.btnClearSearchTransaction.Click += new System.EventHandler(this.btnClearSearchTransaction_Click);
            // 
            // txtSearchTransaction
            // 
            this.txtSearchTransaction.BackColor = System.Drawing.Color.Gainsboro;
            this.txtSearchTransaction.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearchTransaction.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchTransaction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSearchTransaction.Font = new System.Drawing.Font("Times New Roman", 25.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSearchTransaction.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtSearchTransaction.Location = new System.Drawing.Point(220, 0);
            this.txtSearchTransaction.Margin = new System.Windows.Forms.Padding(20, 10, 10, 10);
            this.txtSearchTransaction.Name = "txtSearchTransaction";
            this.txtSearchTransaction.Size = new System.Drawing.Size(1220, 49);
            this.txtSearchTransaction.TabIndex = 0;
            this.txtSearchTransaction.TextChanged += new System.EventHandler(this.txtSearchTransaction_TextChanged);
            this.txtSearchTransaction.Enter += new System.EventHandler(this.txtSearchTransaction_Enter);
            this.txtSearchTransaction.Leave += new System.EventHandler(this.txtSearchTransaction_Leave);
            // 
            // btnSearchMainTransaction
            // 
            this.btnSearchMainTransaction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnSearchMainTransaction.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSearchMainTransaction.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnSearchMainTransaction.FlatAppearance.BorderSize = 2;
            this.btnSearchMainTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchMainTransaction.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSearchMainTransaction.ForeColor = System.Drawing.Color.White;
            this.btnSearchMainTransaction.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnSearchMainTransaction.IconColor = System.Drawing.Color.White;
            this.btnSearchMainTransaction.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSearchMainTransaction.IconSize = 40;
            this.btnSearchMainTransaction.Location = new System.Drawing.Point(0, 0);
            this.btnSearchMainTransaction.Name = "btnSearchMainTransaction";
            this.btnSearchMainTransaction.Padding = new System.Windows.Forms.Padding(25, 4, 0, 0);
            this.btnSearchMainTransaction.Rotation = 5D;
            this.btnSearchMainTransaction.Size = new System.Drawing.Size(220, 50);
            this.btnSearchMainTransaction.TabIndex = 0;
            this.btnSearchMainTransaction.Text = "Search";
            this.btnSearchMainTransaction.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchMainTransaction.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSearchMainTransaction.UseVisualStyleBackColor = false;
            this.btnSearchMainTransaction.Click += new System.EventHandler(this.btnSearchMainTransaction_Click);
            // 
            // pnlDgvTransaction
            // 
            this.pnlDgvTransaction.Controls.Add(this.dgvTransaction);
            this.pnlDgvTransaction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDgvTransaction.Location = new System.Drawing.Point(0, 187);
            this.pnlDgvTransaction.Name = "pnlDgvTransaction";
            this.pnlDgvTransaction.Size = new System.Drawing.Size(1440, 483);
            this.pnlDgvTransaction.TabIndex = 2;
            // 
            // dgvTransaction
            // 
            this.dgvTransaction.AllowUserToAddRows = false;
            this.dgvTransaction.AllowUserToDeleteRows = false;
            this.dgvTransaction.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvTransaction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransaction.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Account_No,
            this.Deposite,
            this.Withdraw,
            this.Transaction_Time});
            this.dgvTransaction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTransaction.Location = new System.Drawing.Point(0, 0);
            this.dgvTransaction.Name = "dgvTransaction";
            this.dgvTransaction.ReadOnly = true;
            this.dgvTransaction.RowHeadersWidth = 51;
            this.dgvTransaction.RowTemplate.Height = 29;
            this.dgvTransaction.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTransaction.Size = new System.Drawing.Size(1440, 483);
            this.dgvTransaction.TabIndex = 0;
            // 
            // Account_No
            // 
            this.Account_No.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Account_No.DataPropertyName = "Account_No";
            this.Account_No.HeaderText = "Account No ";
            this.Account_No.MinimumWidth = 6;
            this.Account_No.Name = "Account_No";
            this.Account_No.ReadOnly = true;
            // 
            // Deposite
            // 
            this.Deposite.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Deposite.DataPropertyName = "Deposite";
            this.Deposite.HeaderText = "Deposite";
            this.Deposite.MinimumWidth = 6;
            this.Deposite.Name = "Deposite";
            this.Deposite.ReadOnly = true;
            // 
            // Withdraw
            // 
            this.Withdraw.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Withdraw.DataPropertyName = "Withdraw";
            this.Withdraw.HeaderText = "Withdraw";
            this.Withdraw.MinimumWidth = 6;
            this.Withdraw.Name = "Withdraw";
            this.Withdraw.ReadOnly = true;
            // 
            // Transaction_Time
            // 
            this.Transaction_Time.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Transaction_Time.DataPropertyName = "Transaction_Time";
            this.Transaction_Time.HeaderText = "Transaction Time";
            this.Transaction_Time.MinimumWidth = 6;
            this.Transaction_Time.Name = "Transaction_Time";
            this.Transaction_Time.ReadOnly = true;
            // 
            // UserControlTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnlDgvTransaction);
            this.Controls.Add(this.pnlUpTransaction);
            this.MinimumSize = new System.Drawing.Size(1440, 670);
            this.Name = "UserControlTransaction";
            this.Size = new System.Drawing.Size(1440, 670);
            this.Load += new System.EventHandler(this.UserControlTransaction_Load);
            this.pnlUpTransaction.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlDgvTransaction.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransaction)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlUpTransaction;
        private System.Windows.Forms.Panel pnlDgvTransaction;
        private System.Windows.Forms.DataGridView dgvTransaction;
        private System.Windows.Forms.DataGridViewTextBoxColumn Account_No;
        private System.Windows.Forms.DataGridViewTextBoxColumn Deposite;
        private System.Windows.Forms.DataGridViewTextBoxColumn Withdraw;
        private System.Windows.Forms.DataGridViewTextBoxColumn Transaction_Time;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnClearSearchTransaction;
        private System.Windows.Forms.TextBox txtSearchTransaction;
        private FontAwesome.Sharp.IconButton btnSearchMainTransaction;
        private System.Windows.Forms.Label lblTransaction;
        private FontAwesome.Sharp.IconButton btnRemoveTransaction;
        private FontAwesome.Sharp.IconButton btnEditTransaction;
        private FontAwesome.Sharp.IconButton btnInsertTransaction;
    }
}
