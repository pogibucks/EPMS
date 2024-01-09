using EPMSysLogin.FormUI;
using EPMSysLogin.MyUC;
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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btndashboard_Click(object sender, EventArgs e)
        {
            var dashboard = new MainForm();
            dashboard.Show();
            Close();
                }

        private void btnaddemployee_Click(object sender, EventArgs e)
        {
            var AddEmployee = new MyUC.AddEmployee();
            EPMSysLogin.MyClass.UIC.MC(PanelC, AddEmployee);
            
        }

        private void btnviewemployee_Click(object sender, EventArgs e)
        {
            var ViewEmployee = new MyUC.ViewEmployee();
            EPMSysLogin.MyClass.UIC.MC(PanelC, ViewEmployee);
        }

        private void btnemployeeleave_Click(object sender, EventArgs e)
        {
           // var EmployeeLeave = new MyUC.EmployeeLeave();
            //EPMSysLogin.MyClass.UIC.MC(PanelC, EmployeeLeave);
            var LeaveUC = new MyUC.LeaveUC() { Dock = DockStyle.Fill};
            this.PanelC.Controls.Clear();
            this.PanelC.Controls.Add(LeaveUC);
        }

        private void btnsettings_Click(object sender, EventArgs e)
        {
            var SecurityControl = new SecurityControl();
            SecurityControl.Show();
            
        }

        private void PanelC_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
          this.Close();
        }
    }
}
