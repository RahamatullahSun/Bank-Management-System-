namespace BankManagementSystem.App
{
    partial class userControlEmployee
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
            this.pnlUpEmp = new System.Windows.Forms.Panel();
            this.btnRefreshEmp = new FontAwesome.Sharp.IconButton();
            this.lblEmployee = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnInsertEmp = new FontAwesome.Sharp.IconButton();
            this.btnEditEmp = new FontAwesome.Sharp.IconButton();
            this.btnRemoveEmp = new FontAwesome.Sharp.IconButton();
            this.btnClearSearchEmp = new FontAwesome.Sharp.IconButton();
            this.txtSearchEmp = new System.Windows.Forms.TextBox();
            this.btnSearchMainEmp = new FontAwesome.Sharp.IconButton();
            this.pnlDgvEmp = new System.Windows.Forms.Panel();
            this.dgvEmployee = new System.Windows.Forms.DataGridView();
            this.EmpId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpPass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpPhnNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpJoiningDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlUpEmp.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlDgvEmp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlUpEmp
            // 
            this.pnlUpEmp.BackColor = System.Drawing.Color.Aqua;
            this.pnlUpEmp.Controls.Add(this.btnRefreshEmp);
            this.pnlUpEmp.Controls.Add(this.lblEmployee);
            this.pnlUpEmp.Controls.Add(this.panel1);
            this.pnlUpEmp.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUpEmp.Location = new System.Drawing.Point(0, 0);
            this.pnlUpEmp.Name = "pnlUpEmp";
            this.pnlUpEmp.Size = new System.Drawing.Size(1440, 187);
            this.pnlUpEmp.TabIndex = 0;
            // 
            // btnRefreshEmp
            // 
            this.btnRefreshEmp.BackColor = System.Drawing.Color.Aqua;
            this.btnRefreshEmp.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRefreshEmp.FlatAppearance.BorderSize = 0;
            this.btnRefreshEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshEmp.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRefreshEmp.IconChar = FontAwesome.Sharp.IconChar.Sync;
            this.btnRefreshEmp.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRefreshEmp.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRefreshEmp.IconSize = 45;
            this.btnRefreshEmp.Location = new System.Drawing.Point(13, 8);
            this.btnRefreshEmp.Name = "btnRefreshEmp";
            this.btnRefreshEmp.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.btnRefreshEmp.Size = new System.Drawing.Size(54, 47);
            this.btnRefreshEmp.TabIndex = 24;
            this.btnRefreshEmp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefreshEmp.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnRefreshEmp.UseVisualStyleBackColor = false;
            this.btnRefreshEmp.Click += new System.EventHandler(this.btnRefreshEmp_Click);
            // 
            // lblEmployee
            // 
            this.lblEmployee.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblEmployee.Font = new System.Drawing.Font("Times New Roman", 25.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEmployee.Location = new System.Drawing.Point(0, 0);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new System.Drawing.Size(1440, 48);
            this.lblEmployee.TabIndex = 1;
            this.lblEmployee.Text = "Employee";
            this.lblEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnInsertEmp);
            this.panel1.Controls.Add(this.btnEditEmp);
            this.panel1.Controls.Add(this.btnRemoveEmp);
            this.panel1.Controls.Add(this.btnClearSearchEmp);
            this.panel1.Controls.Add(this.txtSearchEmp);
            this.panel1.Controls.Add(this.btnSearchMainEmp);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 137);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1440, 50);
            this.panel1.TabIndex = 0;
            // 
            // btnInsertEmp
            // 
            this.btnInsertEmp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnInsertEmp.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnInsertEmp.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(215)))), ((int)(((byte)(255)))));
            this.btnInsertEmp.FlatAppearance.BorderSize = 2;
            this.btnInsertEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsertEmp.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnInsertEmp.ForeColor = System.Drawing.Color.White;
            this.btnInsertEmp.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.btnInsertEmp.IconColor = System.Drawing.Color.White;
            this.btnInsertEmp.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnInsertEmp.IconSize = 40;
            this.btnInsertEmp.Location = new System.Drawing.Point(885, 0);
            this.btnInsertEmp.Name = "btnInsertEmp";
            this.btnInsertEmp.Padding = new System.Windows.Forms.Padding(27, 2, 0, 0);
            this.btnInsertEmp.Size = new System.Drawing.Size(185, 50);
            this.btnInsertEmp.TabIndex = 5;
            this.btnInsertEmp.Text = "Add";
            this.btnInsertEmp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInsertEmp.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnInsertEmp.UseVisualStyleBackColor = false;
            this.btnInsertEmp.Click += new System.EventHandler(this.btnInsertEmp_Click);
            // 
            // btnEditEmp
            // 
            this.btnEditEmp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnEditEmp.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnEditEmp.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(215)))), ((int)(((byte)(255)))));
            this.btnEditEmp.FlatAppearance.BorderSize = 2;
            this.btnEditEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditEmp.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEditEmp.ForeColor = System.Drawing.Color.White;
            this.btnEditEmp.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            this.btnEditEmp.IconColor = System.Drawing.Color.White;
            this.btnEditEmp.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditEmp.IconSize = 40;
            this.btnEditEmp.Location = new System.Drawing.Point(1070, 0);
            this.btnEditEmp.Name = "btnEditEmp";
            this.btnEditEmp.Padding = new System.Windows.Forms.Padding(28, 2, 0, 0);
            this.btnEditEmp.Size = new System.Drawing.Size(185, 50);
            this.btnEditEmp.TabIndex = 4;
            this.btnEditEmp.Text = "Edit";
            this.btnEditEmp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditEmp.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnEditEmp.UseVisualStyleBackColor = false;
            this.btnEditEmp.Click += new System.EventHandler(this.btnEditEmp_Click);
            // 
            // btnRemoveEmp
            // 
            this.btnRemoveEmp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnRemoveEmp.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnRemoveEmp.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(215)))), ((int)(((byte)(255)))));
            this.btnRemoveEmp.FlatAppearance.BorderSize = 2;
            this.btnRemoveEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveEmp.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRemoveEmp.ForeColor = System.Drawing.Color.White;
            this.btnRemoveEmp.IconChar = FontAwesome.Sharp.IconChar.UserMinus;
            this.btnRemoveEmp.IconColor = System.Drawing.Color.White;
            this.btnRemoveEmp.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRemoveEmp.IconSize = 40;
            this.btnRemoveEmp.Location = new System.Drawing.Point(1255, 0);
            this.btnRemoveEmp.Name = "btnRemoveEmp";
            this.btnRemoveEmp.Padding = new System.Windows.Forms.Padding(8, 2, 0, 0);
            this.btnRemoveEmp.Size = new System.Drawing.Size(185, 50);
            this.btnRemoveEmp.TabIndex = 3;
            this.btnRemoveEmp.Text = "Remove";
            this.btnRemoveEmp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemoveEmp.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnRemoveEmp.UseVisualStyleBackColor = false;
            this.btnRemoveEmp.Click += new System.EventHandler(this.btnRemoveEmp_Click);
            // 
            // btnClearSearchEmp
            // 
            this.btnClearSearchEmp.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnClearSearchEmp.BackColor = System.Drawing.Color.Gainsboro;
            this.btnClearSearchEmp.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnClearSearchEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearSearchEmp.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClearSearchEmp.ForeColor = System.Drawing.Color.White;
            this.btnClearSearchEmp.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnClearSearchEmp.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClearSearchEmp.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClearSearchEmp.IconSize = 50;
            this.btnClearSearchEmp.Location = new System.Drawing.Point(812, 0);
            this.btnClearSearchEmp.Name = "btnClearSearchEmp";
            this.btnClearSearchEmp.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.btnClearSearchEmp.Size = new System.Drawing.Size(76, 50);
            this.btnClearSearchEmp.TabIndex = 1;
            this.btnClearSearchEmp.UseVisualStyleBackColor = false;
            this.btnClearSearchEmp.Click += new System.EventHandler(this.btnClearSearchEmp_Click);
            // 
            // txtSearchEmp
            // 
            this.txtSearchEmp.BackColor = System.Drawing.Color.Gainsboro;
            this.txtSearchEmp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearchEmp.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchEmp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSearchEmp.Font = new System.Drawing.Font("Times New Roman", 25.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSearchEmp.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtSearchEmp.Location = new System.Drawing.Point(220, 0);
            this.txtSearchEmp.Margin = new System.Windows.Forms.Padding(20, 10, 10, 10);
            this.txtSearchEmp.Name = "txtSearchEmp";
            this.txtSearchEmp.Size = new System.Drawing.Size(1220, 49);
            this.txtSearchEmp.TabIndex = 0;
            this.txtSearchEmp.TextChanged += new System.EventHandler(this.txtSearchEmp_TextChanged);
            this.txtSearchEmp.Enter += new System.EventHandler(this.txtSearchEmp_Enter);
            this.txtSearchEmp.Leave += new System.EventHandler(this.txtSearchEmp_Leave);
            // 
            // btnSearchMainEmp
            // 
            this.btnSearchMainEmp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnSearchMainEmp.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSearchMainEmp.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnSearchMainEmp.FlatAppearance.BorderSize = 2;
            this.btnSearchMainEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchMainEmp.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSearchMainEmp.ForeColor = System.Drawing.Color.White;
            this.btnSearchMainEmp.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnSearchMainEmp.IconColor = System.Drawing.Color.White;
            this.btnSearchMainEmp.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSearchMainEmp.IconSize = 40;
            this.btnSearchMainEmp.Location = new System.Drawing.Point(0, 0);
            this.btnSearchMainEmp.Name = "btnSearchMainEmp";
            this.btnSearchMainEmp.Padding = new System.Windows.Forms.Padding(25, 4, 0, 0);
            this.btnSearchMainEmp.Rotation = 5D;
            this.btnSearchMainEmp.Size = new System.Drawing.Size(220, 50);
            this.btnSearchMainEmp.TabIndex = 0;
            this.btnSearchMainEmp.Text = "Search";
            this.btnSearchMainEmp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchMainEmp.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSearchMainEmp.UseVisualStyleBackColor = false;
            this.btnSearchMainEmp.Click += new System.EventHandler(this.btnSearchMainEmp_Click);
            // 
            // pnlDgvEmp
            // 
            this.pnlDgvEmp.Controls.Add(this.dgvEmployee);
            this.pnlDgvEmp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDgvEmp.Location = new System.Drawing.Point(0, 187);
            this.pnlDgvEmp.Name = "pnlDgvEmp";
            this.pnlDgvEmp.Size = new System.Drawing.Size(1440, 483);
            this.pnlDgvEmp.TabIndex = 1;
            // 
            // dgvEmployee
            // 
            this.dgvEmployee.AllowUserToAddRows = false;
            this.dgvEmployee.AllowUserToDeleteRows = false;
            this.dgvEmployee.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EmpId,
            this.EmpName,
            this.EmpPass,
            this.EmpEmail,
            this.EmpPhnNo,
            this.EmpAddress,
            this.EmpSalary,
            this.EmpJoiningDate,
            this.EmpGender,
            this.Role});
            this.dgvEmployee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEmployee.Location = new System.Drawing.Point(0, 0);
            this.dgvEmployee.Name = "dgvEmployee";
            this.dgvEmployee.ReadOnly = true;
            this.dgvEmployee.RowHeadersWidth = 51;
            this.dgvEmployee.RowTemplate.Height = 29;
            this.dgvEmployee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmployee.Size = new System.Drawing.Size(1440, 483);
            this.dgvEmployee.TabIndex = 0;
            this.dgvEmployee.DoubleClick += new System.EventHandler(this.dgvEmployee_DoubleClick);
            // 
            // EmpId
            // 
            this.EmpId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EmpId.DataPropertyName = "EmpId";
            this.EmpId.HeaderText = "Id";
            this.EmpId.MinimumWidth = 6;
            this.EmpId.Name = "EmpId";
            this.EmpId.ReadOnly = true;
            // 
            // EmpName
            // 
            this.EmpName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EmpName.DataPropertyName = "EmpName";
            this.EmpName.HeaderText = "Name";
            this.EmpName.MinimumWidth = 6;
            this.EmpName.Name = "EmpName";
            this.EmpName.ReadOnly = true;
            // 
            // EmpPass
            // 
            this.EmpPass.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EmpPass.DataPropertyName = "EmpPass";
            this.EmpPass.HeaderText = "Password";
            this.EmpPass.MinimumWidth = 6;
            this.EmpPass.Name = "EmpPass";
            this.EmpPass.ReadOnly = true;
            // 
            // EmpEmail
            // 
            this.EmpEmail.DataPropertyName = "EmpEmail";
            this.EmpEmail.HeaderText = "E-Mail";
            this.EmpEmail.MinimumWidth = 6;
            this.EmpEmail.Name = "EmpEmail";
            this.EmpEmail.ReadOnly = true;
            this.EmpEmail.Width = 125;
            // 
            // EmpPhnNo
            // 
            this.EmpPhnNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EmpPhnNo.DataPropertyName = "EmpPhnNo";
            this.EmpPhnNo.HeaderText = "Phone No";
            this.EmpPhnNo.MinimumWidth = 6;
            this.EmpPhnNo.Name = "EmpPhnNo";
            this.EmpPhnNo.ReadOnly = true;
            // 
            // EmpAddress
            // 
            this.EmpAddress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EmpAddress.DataPropertyName = "EmpAddress";
            this.EmpAddress.HeaderText = "Address";
            this.EmpAddress.MinimumWidth = 6;
            this.EmpAddress.Name = "EmpAddress";
            this.EmpAddress.ReadOnly = true;
            // 
            // EmpSalary
            // 
            this.EmpSalary.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EmpSalary.DataPropertyName = "EmpSalary";
            this.EmpSalary.HeaderText = "Salary";
            this.EmpSalary.MinimumWidth = 6;
            this.EmpSalary.Name = "EmpSalary";
            this.EmpSalary.ReadOnly = true;
            // 
            // EmpJoiningDate
            // 
            this.EmpJoiningDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EmpJoiningDate.DataPropertyName = "EmpJoiningDate";
            this.EmpJoiningDate.HeaderText = "Joining Date";
            this.EmpJoiningDate.MinimumWidth = 6;
            this.EmpJoiningDate.Name = "EmpJoiningDate";
            this.EmpJoiningDate.ReadOnly = true;
            // 
            // EmpGender
            // 
            this.EmpGender.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EmpGender.DataPropertyName = "EmpGender";
            this.EmpGender.HeaderText = "Gender";
            this.EmpGender.MinimumWidth = 6;
            this.EmpGender.Name = "EmpGender";
            this.EmpGender.ReadOnly = true;
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
            // userControlEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnlDgvEmp);
            this.Controls.Add(this.pnlUpEmp);
            this.Name = "userControlEmployee";
            this.Size = new System.Drawing.Size(1440, 670);
            this.Load += new System.EventHandler(this.userControlEmployee_Load);
            this.pnlUpEmp.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlDgvEmp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlUpEmp;
        private System.Windows.Forms.Panel pnlDgvEmp;
        private System.Windows.Forms.DataGridView dgvEmployee;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnSearchMainEmp;
        private FontAwesome.Sharp.IconButton btnClearSearchEmp;
        private System.Windows.Forms.TextBox txtSearchEmp;
        private System.Windows.Forms.Label lblEmployee;
        private FontAwesome.Sharp.IconButton btnRemoveEmp;
        private FontAwesome.Sharp.IconButton btnEditEmp;
        private FontAwesome.Sharp.IconButton btnInsertEmp;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpId;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpName;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpPass;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpPhnNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpSalary;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpJoiningDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Role;
        private FontAwesome.Sharp.IconButton btnRefreshEmp;
    }
}
