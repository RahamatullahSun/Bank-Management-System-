
namespace BankManagementSystem.App
{
    partial class UserControlCustomer
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
            this.pnlCusTop = new System.Windows.Forms.Panel();
            this.lblEmployee = new System.Windows.Forms.Label();
            this.pnlCusSearch = new System.Windows.Forms.Panel();
            this.btnClearSearchCus = new FontAwesome.Sharp.IconButton();
            this.btnInsertCus = new FontAwesome.Sharp.IconButton();
            this.txtSearchCus = new System.Windows.Forms.TextBox();
            this.btnEditCus = new FontAwesome.Sharp.IconButton();
            this.btnSearchMainCus = new FontAwesome.Sharp.IconButton();
            this.btnRemoveCus = new FontAwesome.Sharp.IconButton();
            this.pnlDgvCus = new System.Windows.Forms.Panel();
            this.dgvCustomer = new System.Windows.Forms.DataGridView();
            this.CusId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CusPass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CusAccNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CusName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CusAccCreatDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CusAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CusEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CusPhnNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CusAccBalance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlCusTop.SuspendLayout();
            this.pnlCusSearch.SuspendLayout();
            this.pnlDgvCus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCusTop
            // 
            this.pnlCusTop.BackColor = System.Drawing.Color.Aqua;
            this.pnlCusTop.Controls.Add(this.lblEmployee);
            this.pnlCusTop.Controls.Add(this.pnlCusSearch);
            this.pnlCusTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCusTop.Location = new System.Drawing.Point(0, 0);
            this.pnlCusTop.Name = "pnlCusTop";
            this.pnlCusTop.Size = new System.Drawing.Size(1440, 187);
            this.pnlCusTop.TabIndex = 0;
            // 
            // lblEmployee
            // 
            this.lblEmployee.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblEmployee.Font = new System.Drawing.Font("Times New Roman", 25.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEmployee.Location = new System.Drawing.Point(0, 0);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new System.Drawing.Size(1440, 48);
            this.lblEmployee.TabIndex = 12;
            this.lblEmployee.Text = "Customer";
            this.lblEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlCusSearch
            // 
            this.pnlCusSearch.Controls.Add(this.btnClearSearchCus);
            this.pnlCusSearch.Controls.Add(this.btnInsertCus);
            this.pnlCusSearch.Controls.Add(this.txtSearchCus);
            this.pnlCusSearch.Controls.Add(this.btnEditCus);
            this.pnlCusSearch.Controls.Add(this.btnSearchMainCus);
            this.pnlCusSearch.Controls.Add(this.btnRemoveCus);
            this.pnlCusSearch.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlCusSearch.Location = new System.Drawing.Point(0, 137);
            this.pnlCusSearch.Name = "pnlCusSearch";
            this.pnlCusSearch.Size = new System.Drawing.Size(1440, 50);
            this.pnlCusSearch.TabIndex = 11;
            // 
            // btnClearSearchCus
            // 
            this.btnClearSearchCus.BackColor = System.Drawing.Color.Gainsboro;
            this.btnClearSearchCus.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClearSearchCus.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnClearSearchCus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearSearchCus.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClearSearchCus.ForeColor = System.Drawing.Color.White;
            this.btnClearSearchCus.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnClearSearchCus.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClearSearchCus.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClearSearchCus.IconSize = 50;
            this.btnClearSearchCus.Location = new System.Drawing.Point(809, 0);
            this.btnClearSearchCus.Name = "btnClearSearchCus";
            this.btnClearSearchCus.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.btnClearSearchCus.Size = new System.Drawing.Size(76, 50);
            this.btnClearSearchCus.TabIndex = 1;
            this.btnClearSearchCus.UseVisualStyleBackColor = false;
            this.btnClearSearchCus.Click += new System.EventHandler(this.btnClearSearchCus_Click);
            // 
            // btnInsertCus
            // 
            this.btnInsertCus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnInsertCus.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnInsertCus.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(215)))), ((int)(((byte)(255)))));
            this.btnInsertCus.FlatAppearance.BorderSize = 2;
            this.btnInsertCus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsertCus.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnInsertCus.ForeColor = System.Drawing.Color.White;
            this.btnInsertCus.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.btnInsertCus.IconColor = System.Drawing.Color.White;
            this.btnInsertCus.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnInsertCus.IconSize = 40;
            this.btnInsertCus.Location = new System.Drawing.Point(885, 0);
            this.btnInsertCus.Name = "btnInsertCus";
            this.btnInsertCus.Padding = new System.Windows.Forms.Padding(27, 2, 0, 0);
            this.btnInsertCus.Size = new System.Drawing.Size(185, 50);
            this.btnInsertCus.TabIndex = 4;
            this.btnInsertCus.Text = "Add";
            this.btnInsertCus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInsertCus.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnInsertCus.UseVisualStyleBackColor = false;
            // 
            // txtSearchCus
            // 
            this.txtSearchCus.BackColor = System.Drawing.Color.Gainsboro;
            this.txtSearchCus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearchCus.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchCus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSearchCus.Font = new System.Drawing.Font("Times New Roman", 25.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSearchCus.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtSearchCus.Location = new System.Drawing.Point(220, 0);
            this.txtSearchCus.Margin = new System.Windows.Forms.Padding(20, 10, 10, 10);
            this.txtSearchCus.Name = "txtSearchCus";
            this.txtSearchCus.Size = new System.Drawing.Size(850, 49);
            this.txtSearchCus.TabIndex = 0;
            this.txtSearchCus.TextChanged += new System.EventHandler(this.txtSearchCus_TextChanged);
            this.txtSearchCus.Enter += new System.EventHandler(this.txtSearchCus_Enter);
            this.txtSearchCus.Leave += new System.EventHandler(this.txtSearchCus_Leave);
            // 
            // btnEditCus
            // 
            this.btnEditCus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnEditCus.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnEditCus.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(215)))), ((int)(((byte)(255)))));
            this.btnEditCus.FlatAppearance.BorderSize = 2;
            this.btnEditCus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditCus.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEditCus.ForeColor = System.Drawing.Color.White;
            this.btnEditCus.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            this.btnEditCus.IconColor = System.Drawing.Color.White;
            this.btnEditCus.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditCus.IconSize = 40;
            this.btnEditCus.Location = new System.Drawing.Point(1070, 0);
            this.btnEditCus.Name = "btnEditCus";
            this.btnEditCus.Padding = new System.Windows.Forms.Padding(28, 2, 0, 0);
            this.btnEditCus.Size = new System.Drawing.Size(185, 50);
            this.btnEditCus.TabIndex = 3;
            this.btnEditCus.Text = "Edit";
            this.btnEditCus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditCus.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnEditCus.UseVisualStyleBackColor = false;
            // 
            // btnSearchMainCus
            // 
            this.btnSearchMainCus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnSearchMainCus.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSearchMainCus.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(215)))), ((int)(((byte)(255)))));
            this.btnSearchMainCus.FlatAppearance.BorderSize = 2;
            this.btnSearchMainCus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchMainCus.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSearchMainCus.ForeColor = System.Drawing.Color.White;
            this.btnSearchMainCus.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnSearchMainCus.IconColor = System.Drawing.Color.White;
            this.btnSearchMainCus.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSearchMainCus.IconSize = 40;
            this.btnSearchMainCus.Location = new System.Drawing.Point(0, 0);
            this.btnSearchMainCus.Name = "btnSearchMainCus";
            this.btnSearchMainCus.Padding = new System.Windows.Forms.Padding(25, 4, 0, 0);
            this.btnSearchMainCus.Rotation = 5D;
            this.btnSearchMainCus.Size = new System.Drawing.Size(220, 50);
            this.btnSearchMainCus.TabIndex = 0;
            this.btnSearchMainCus.Text = "Search";
            this.btnSearchMainCus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchMainCus.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSearchMainCus.UseVisualStyleBackColor = false;
            this.btnSearchMainCus.Click += new System.EventHandler(this.btnSearchMainCus_Click);
            // 
            // btnRemoveCus
            // 
            this.btnRemoveCus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnRemoveCus.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnRemoveCus.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(215)))), ((int)(((byte)(255)))));
            this.btnRemoveCus.FlatAppearance.BorderSize = 2;
            this.btnRemoveCus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveCus.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRemoveCus.ForeColor = System.Drawing.Color.White;
            this.btnRemoveCus.IconChar = FontAwesome.Sharp.IconChar.UserMinus;
            this.btnRemoveCus.IconColor = System.Drawing.Color.White;
            this.btnRemoveCus.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRemoveCus.IconSize = 40;
            this.btnRemoveCus.Location = new System.Drawing.Point(1255, 0);
            this.btnRemoveCus.Name = "btnRemoveCus";
            this.btnRemoveCus.Padding = new System.Windows.Forms.Padding(8, 2, 0, 0);
            this.btnRemoveCus.Size = new System.Drawing.Size(185, 50);
            this.btnRemoveCus.TabIndex = 2;
            this.btnRemoveCus.Text = "Remove";
            this.btnRemoveCus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemoveCus.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnRemoveCus.UseVisualStyleBackColor = false;
            this.btnRemoveCus.Click += new System.EventHandler(this.btnRemoveCus_Click);
            // 
            // pnlDgvCus
            // 
            this.pnlDgvCus.Controls.Add(this.dgvCustomer);
            this.pnlDgvCus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDgvCus.Location = new System.Drawing.Point(0, 187);
            this.pnlDgvCus.Name = "pnlDgvCus";
            this.pnlDgvCus.Size = new System.Drawing.Size(1440, 483);
            this.pnlDgvCus.TabIndex = 1;
            // 
            // dgvCustomer
            // 
            this.dgvCustomer.AllowUserToAddRows = false;
            this.dgvCustomer.AllowUserToDeleteRows = false;
            this.dgvCustomer.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CusId,
            this.CusPass,
            this.CusAccNo,
            this.CusName,
            this.CusAccCreatDate,
            this.CusAddress,
            this.CusEmail,
            this.CusPhnNo,
            this.CusAccBalance,
            this.dataGridViewTextBoxColumn1});
            this.dgvCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCustomer.GridColor = System.Drawing.Color.DarkGray;
            this.dgvCustomer.Location = new System.Drawing.Point(0, 0);
            this.dgvCustomer.Name = "dgvCustomer";
            this.dgvCustomer.ReadOnly = true;
            this.dgvCustomer.RowHeadersWidth = 51;
            this.dgvCustomer.RowTemplate.Height = 29;
            this.dgvCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustomer.Size = new System.Drawing.Size(1440, 483);
            this.dgvCustomer.TabIndex = 12;
            // 
            // CusId
            // 
            this.CusId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CusId.DataPropertyName = "CusId";
            this.CusId.HeaderText = "Id";
            this.CusId.MinimumWidth = 6;
            this.CusId.Name = "CusId";
            this.CusId.ReadOnly = true;
            // 
            // CusPass
            // 
            this.CusPass.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CusPass.DataPropertyName = "CusPass";
            this.CusPass.HeaderText = "Password";
            this.CusPass.MinimumWidth = 6;
            this.CusPass.Name = "CusPass";
            this.CusPass.ReadOnly = true;
            // 
            // CusAccNo
            // 
            this.CusAccNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CusAccNo.DataPropertyName = "CusAccNo";
            this.CusAccNo.HeaderText = "Account No";
            this.CusAccNo.MinimumWidth = 6;
            this.CusAccNo.Name = "CusAccNo";
            this.CusAccNo.ReadOnly = true;
            // 
            // CusName
            // 
            this.CusName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CusName.DataPropertyName = "CusName";
            this.CusName.HeaderText = "Name";
            this.CusName.MinimumWidth = 6;
            this.CusName.Name = "CusName";
            this.CusName.ReadOnly = true;
            // 
            // CusAccCreatDate
            // 
            this.CusAccCreatDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CusAccCreatDate.DataPropertyName = "CusAccCreatDate";
            this.CusAccCreatDate.HeaderText = "Create Date";
            this.CusAccCreatDate.MinimumWidth = 6;
            this.CusAccCreatDate.Name = "CusAccCreatDate";
            this.CusAccCreatDate.ReadOnly = true;
            // 
            // CusAddress
            // 
            this.CusAddress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CusAddress.DataPropertyName = "CusAddress";
            this.CusAddress.HeaderText = "Address";
            this.CusAddress.MinimumWidth = 6;
            this.CusAddress.Name = "CusAddress";
            this.CusAddress.ReadOnly = true;
            // 
            // CusEmail
            // 
            this.CusEmail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CusEmail.DataPropertyName = "CusEmail";
            this.CusEmail.HeaderText = "Email";
            this.CusEmail.MinimumWidth = 6;
            this.CusEmail.Name = "CusEmail";
            this.CusEmail.ReadOnly = true;
            // 
            // CusPhnNo
            // 
            this.CusPhnNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CusPhnNo.DataPropertyName = "CusPhnNo";
            this.CusPhnNo.HeaderText = "Phone No";
            this.CusPhnNo.MinimumWidth = 6;
            this.CusPhnNo.Name = "CusPhnNo";
            this.CusPhnNo.ReadOnly = true;
            // 
            // CusAccBalance
            // 
            this.CusAccBalance.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CusAccBalance.DataPropertyName = "CusAccBalance";
            this.CusAccBalance.HeaderText = "Balance";
            this.CusAccBalance.MinimumWidth = 6;
            this.CusAccBalance.Name = "CusAccBalance";
            this.CusAccBalance.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Role";
            this.dataGridViewTextBoxColumn1.HeaderText = "Role";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // UserControlCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnlDgvCus);
            this.Controls.Add(this.pnlCusTop);
            this.Name = "UserControlCustomer";
            this.Size = new System.Drawing.Size(1440, 670);
            this.Load += new System.EventHandler(this.UserControlCustomer_Load);
            this.pnlCusTop.ResumeLayout(false);
            this.pnlCusSearch.ResumeLayout(false);
            this.pnlCusSearch.PerformLayout();
            this.pnlDgvCus.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCusTop;
        private System.Windows.Forms.Panel pnlDgvCus;
        private System.Windows.Forms.DataGridView dgvCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn CusId;
        private System.Windows.Forms.DataGridViewTextBoxColumn CusPass;
        private System.Windows.Forms.DataGridViewTextBoxColumn CusAccNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CusName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CusAccCreatDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn CusAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn CusEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn CusPhnNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CusAccBalance;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.Panel pnlCusSearch;
        private FontAwesome.Sharp.IconButton btnClearSearchCus;
        private FontAwesome.Sharp.IconButton btnInsertCus;
        private System.Windows.Forms.TextBox txtSearchCus;
        private FontAwesome.Sharp.IconButton btnEditCus;
        private FontAwesome.Sharp.IconButton btnSearchMainCus;
        private FontAwesome.Sharp.IconButton btnRemoveCus;
        private System.Windows.Forms.Label lblEmployee;
    }
}
