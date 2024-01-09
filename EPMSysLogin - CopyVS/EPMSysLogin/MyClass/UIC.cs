using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EPMSysLogin.MyClass
{
    public class UIC
    {
        public static void MC(Control PanelC, Control UC) 
        {
        PanelC.Controls.Clear();
        PanelC.Controls.Add(UC);
            UC.Dock = DockStyle.Fill;
        }

    }
}
