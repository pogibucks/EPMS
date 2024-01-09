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
    public partial class ViewEmployee : UserControl
    {
        public ViewEmployee()
        {
            InitializeComponent();
            InitData();
        }

        private void InitData()
        {
            employeeBindingSource.DataSource = Controller.EPMS.Get();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            var m = new Employee();
            m.Employee_ID = int.Parse(textBox1.Text);
            m.FName = textBox2.Text;
            m.Mname = textBox3.Text;
            m.Lname = textBox4.Text;
            m.Contact = int.Parse(textBox5.Text);
            m.Address = textBox6.Text;
            m.Gender = comboBox1.Text;
            m.DoBirth = DateTime.Parse(dateTimePicker1.Text);
            m.Department_ID = textBox8.Text;

            if (Controller.EPMS.Update(m))
                {
                MessageBox.Show("Employee Saved!");
                InitData();
            }
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            var m = new FormUI.AddEmployee();
            m.ShowDialog();
            InitData();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (Controller.EPMS.Delete(int.Parse(textBox1.Text)))
            {
                MessageBox.Show("Employee Deleted!");
                InitData();
            }
        }

        private void ViewEmployee_Load(object sender, EventArgs e)
        {

        }
    }
}
