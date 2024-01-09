using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EPMSysLogin
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if(textBox1.Text=="")
                {
                   // textBox1.Text = "Enter Username";
                    return;
                }
               textBox1.ForeColor = Color.MidnightBlue;
                panel5.Visible = false;
                
            }
            catch { }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textBox2.Text == "")
                {
                   // textBox2.Text = "Password";
                    return;
                }
                textBox2.ForeColor = Color.MidnightBlue;
                textBox2.PasswordChar = '*'; //convert text into *
                panel7.Visible = false;
               
            }
            catch { }
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.SelectAll();
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.SelectAll();
        }

        private void btnlogin_MouseEnter(object sender, EventArgs e)
        {
            btnlogin.ForeColor = Color.White;
        }

        private void btnlogin_MouseLeave(object sender, EventArgs e)
        {
            btnlogin.ForeColor = Color.MidnightBlue;
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
              string Username, Password;
            Username = textBox1.Text;
            Password = textBox2.Text;
            if (Username == "User1" && Password == "123")

            {
              var frm = new MainForm();
              frm.Show();
              this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Credentials!");
                //var frm = new MainForm;
                //frm.Show();
            }
            
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
