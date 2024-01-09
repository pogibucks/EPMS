namespace EPMSysLogin.MyUC
{
    partial class LeaveUC
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label dateLabel;
            System.Windows.Forms.Label leave_IDLabel;
            System.Windows.Forms.Label otherLabel;
            System.Windows.Forms.Label reasonLabel;
            System.Windows.Forms.Label employee_IDLabel1;
            this.leaveBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.leaveDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leave_IDTextBox = new System.Windows.Forms.TextBox();
            this.otherTextBox = new System.Windows.Forms.TextBox();
            this.reasonTextBox = new System.Windows.Forms.TextBox();
            this.employee_IDComboBox = new System.Windows.Forms.ComboBox();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            dateLabel = new System.Windows.Forms.Label();
            leave_IDLabel = new System.Windows.Forms.Label();
            otherLabel = new System.Windows.Forms.Label();
            reasonLabel = new System.Windows.Forms.Label();
            employee_IDLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.leaveBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leaveDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dateLabel.Location = new System.Drawing.Point(183, 115);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new System.Drawing.Size(36, 15);
            dateLabel.TabIndex = 2;
            dateLabel.Text = "Date:";
            // 
            // leave_IDLabel
            // 
            leave_IDLabel.AutoSize = true;
            leave_IDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            leave_IDLabel.Location = new System.Drawing.Point(162, 56);
            leave_IDLabel.Name = "leave_IDLabel";
            leave_IDLabel.Size = new System.Drawing.Size(58, 15);
            leave_IDLabel.TabIndex = 6;
            leave_IDLabel.Text = "Leave ID:";
            // 
            // otherLabel
            // 
            otherLabel.AutoSize = true;
            otherLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            otherLabel.Location = new System.Drawing.Point(183, 167);
            otherLabel.Name = "otherLabel";
            otherLabel.Size = new System.Drawing.Size(38, 15);
            otherLabel.TabIndex = 8;
            otherLabel.Text = "other:";
            // 
            // reasonLabel
            // 
            reasonLabel.AutoSize = true;
            reasonLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            reasonLabel.Location = new System.Drawing.Point(170, 141);
            reasonLabel.Name = "reasonLabel";
            reasonLabel.Size = new System.Drawing.Size(53, 15);
            reasonLabel.TabIndex = 10;
            reasonLabel.Text = "Reason:";
            // 
            // employee_IDLabel1
            // 
            employee_IDLabel1.AutoSize = true;
            employee_IDLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            employee_IDLabel1.Location = new System.Drawing.Point(146, 86);
            employee_IDLabel1.Name = "employee_IDLabel1";
            employee_IDLabel1.Size = new System.Drawing.Size(80, 15);
            employee_IDLabel1.TabIndex = 11;
            employee_IDLabel1.Text = "Employee ID:";
            // 
            // leaveBindingSource
            // 
            this.leaveBindingSource.DataSource = typeof(EPMSysLogin.Model.Leave);
            // 
            // leaveDataGridView
            // 
            this.leaveDataGridView.AllowUserToAddRows = false;
            this.leaveDataGridView.AllowUserToDeleteRows = false;
            this.leaveDataGridView.AutoGenerateColumns = false;
            this.leaveDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.leaveDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.leaveDataGridView.DataSource = this.leaveBindingSource;
            this.leaveDataGridView.Location = new System.Drawing.Point(73, 202);
            this.leaveDataGridView.Name = "leaveDataGridView";
            this.leaveDataGridView.ReadOnly = true;
            this.leaveDataGridView.Size = new System.Drawing.Size(545, 220);
            this.leaveDataGridView.TabIndex = 1;
            this.leaveDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.leaveDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Leave_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Leave_ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Employee_ID";
            this.dataGridViewTextBoxColumn2.HeaderText = "Employee_ID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Date";
            this.dataGridViewTextBoxColumn3.HeaderText = "Date";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Reason";
            this.dataGridViewTextBoxColumn4.HeaderText = "Reason";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "other";
            this.dataGridViewTextBoxColumn5.HeaderText = "other";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // leave_IDTextBox
            // 
            this.leave_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.leaveBindingSource, "Leave_ID", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.leave_IDTextBox.Enabled = false;
            this.leave_IDTextBox.Location = new System.Drawing.Point(237, 53);
            this.leave_IDTextBox.Name = "leave_IDTextBox";
            this.leave_IDTextBox.Size = new System.Drawing.Size(381, 20);
            this.leave_IDTextBox.TabIndex = 7;
            // 
            // otherTextBox
            // 
            this.otherTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.leaveBindingSource, "other", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.otherTextBox.Location = new System.Drawing.Point(237, 164);
            this.otherTextBox.Name = "otherTextBox";
            this.otherTextBox.Size = new System.Drawing.Size(381, 20);
            this.otherTextBox.TabIndex = 9;
            // 
            // reasonTextBox
            // 
            this.reasonTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.leaveBindingSource, "Reason", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.reasonTextBox.Location = new System.Drawing.Point(237, 137);
            this.reasonTextBox.Name = "reasonTextBox";
            this.reasonTextBox.Size = new System.Drawing.Size(381, 20);
            this.reasonTextBox.TabIndex = 11;
            // 
            // employee_IDComboBox
            // 
            this.employee_IDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.leaveBindingSource, "Employee_ID", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.employee_IDComboBox.DataSource = this.employeeBindingSource;
            this.employee_IDComboBox.DisplayMember = "FName";
            this.employee_IDComboBox.FormattingEnabled = true;
            this.employee_IDComboBox.Location = new System.Drawing.Point(237, 83);
            this.employee_IDComboBox.Name = "employee_IDComboBox";
            this.employee_IDComboBox.Size = new System.Drawing.Size(381, 21);
            this.employee_IDComboBox.TabIndex = 12;
            this.employee_IDComboBox.ValueMember = "Employee_ID";
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataSource = typeof(EPMSysLogin.Model.Employee);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.GhostWhite;
            this.panel1.Controls.Add(this.dateTimePickerDate);
            this.panel1.Controls.Add(this.btndelete);
            this.panel1.Controls.Add(this.btnupdate);
            this.panel1.Controls.Add(this.btnsave);
            this.panel1.Controls.Add(this.btn);
            this.panel1.Controls.Add(this.reasonTextBox);
            this.panel1.Controls.Add(this.leaveDataGridView);
            this.panel1.Controls.Add(employee_IDLabel1);
            this.panel1.Controls.Add(reasonLabel);
            this.panel1.Controls.Add(this.employee_IDComboBox);
            this.panel1.Controls.Add(this.otherTextBox);
            this.panel1.Controls.Add(dateLabel);
            this.panel1.Controls.Add(otherLabel);
            this.panel1.Controls.Add(this.leave_IDTextBox);
            this.panel1.Controls.Add(leave_IDLabel);
            this.panel1.Location = new System.Drawing.Point(108, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(853, 444);
            this.panel1.TabIndex = 13;
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.leaveBindingSource, "Date", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.dateTimePickerDate.Location = new System.Drawing.Point(237, 115);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(381, 20);
            this.dateTimePickerDate.TabIndex = 17;
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btndelete.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btndelete.FlatAppearance.BorderSize = 2;
            this.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btndelete.Location = new System.Drawing.Point(634, 378);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(186, 44);
            this.btndelete.TabIndex = 16;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnupdate.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btnupdate.FlatAppearance.BorderSize = 2;
            this.btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnupdate.Location = new System.Drawing.Point(634, 320);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(186, 44);
            this.btnupdate.TabIndex = 15;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnsave.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btnsave.FlatAppearance.BorderSize = 2;
            this.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnsave.Location = new System.Drawing.Point(634, 261);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(186, 44);
            this.btnsave.TabIndex = 14;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click_1);
            // 
            // btn
            // 
            this.btn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btn.FlatAppearance.BorderSize = 2;
            this.btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn.Location = new System.Drawing.Point(634, 203);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(186, 44);
            this.btn.TabIndex = 13;
            this.btn.Text = "New";
            this.btn.UseVisualStyleBackColor = false;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(106, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(380, 22);
            this.label1.TabIndex = 18;
            this.label1.Text = "APPLICATION FOR LEAVE OF ABSENCE";
            // 
            // LeaveUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "LeaveUC";
            this.Size = new System.Drawing.Size(1063, 506);
            ((System.ComponentModel.ISupportInitialize)(this.leaveBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leaveDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource leaveBindingSource;
        private System.Windows.Forms.DataGridView leaveDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.TextBox leave_IDTextBox;
        private System.Windows.Forms.TextBox otherTextBox;
        private System.Windows.Forms.TextBox reasonTextBox;
        private System.Windows.Forms.ComboBox employee_IDComboBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private System.Windows.Forms.DateTimePicker dateTimePickerDate;
        private System.Windows.Forms.Label label1;
    }
}
