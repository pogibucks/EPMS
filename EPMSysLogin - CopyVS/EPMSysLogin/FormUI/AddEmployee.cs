using EPMSysLogin.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EPMSysLogin.FormUI
{
    public partial class AddEmployee : Form
    {
        public AddEmployee()
        {
            InitializeComponent();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            Model.Employee emp = new Model.Employee();
            emp.Employee_ID = int.Parse(textBox1.Text);
            emp.FName = textBox2.Text;
            emp.Mname = textBox3.Text;
            emp.Lname = textBox4.Text;
            emp.Contact = Convert.ToInt32(textBox5.Text);
            emp.Address = textBox6.Text;
            emp.Gender = comboBox1.Text;
            emp.DoBirth = DateTime.Parse(dateTimePicker1.Text);
            emp.Department_ID = textBox8.Text;

            if (EPMS.Insert(emp))
            {
                MessageBox.Show("Your Account was saved!");
                Close();
            }

        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddEmployee_Load(object sender, EventArgs e)
        {

        }
    }
}
