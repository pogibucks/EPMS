using EPMSysLogin.Controller;
using EPMSysLogin.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EPMSysLogin.MyUC
{
    public partial class LeaveUC : UserControl
    {
        public LeaveUC()
        {
            InitializeComponent();
            InitEmployee();
            InitData();
        }

        private void InitData()
        {
            leaveBindingSource.DataSource = LeaveController.Get();
        }

        private void InitEmployee()
        {
            employeeBindingSource.DataSource = Controller.EPMS.Get();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            leave_IDTextBox.Text = "";
            employee_IDComboBox.Text = "";
            dateTimePickerDate.Text = "";
            reasonTextBox.Text = "";
            otherTextBox.Text = "";


        }

        private void btnsave_Click(object sender, EventArgs e)
        {
           
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            var m = new Leave();
            m.Employee_ID = Convert.ToInt32(employee_IDComboBox.SelectedValue);
            m.Leave_ID = int.Parse(leave_IDTextBox.Text);
            m.Date = DateTime.Parse(dateTimePickerDate.Text);
            m.Reason = reasonTextBox.Text;
            m.other = otherTextBox.Text;


            if (LeaveController.Update(m))
            {
                MessageBox.Show("Operation Successful");
                InitData();
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (LeaveController.Delete(int.Parse(leave_IDTextBox.Text)))
            {
                MessageBox.Show(" Information Deleted");
                InitData();
            }
        }

        private void btnsave_Click_1(object sender, EventArgs e)
        {
            var m = new Leave();
            var eid = employee_IDComboBox.SelectedValue.ToString();
            m.Employee_ID = Convert.ToInt32(eid.ToString());
            // m.Leave_ID = int.Parse(leave_IDTextBox.Text);
            m.Date = DateTime.Parse(dateTimePickerDate.Text);
            m.Reason = reasonTextBox.Text;
            m.other = otherTextBox.Text;



            // MessageBox.Show(eid);
            if (LeaveController.Insert(m))
            {
                MessageBox.Show("New Information Successful");
                InitData();
            }
        }

        private void leaveDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
