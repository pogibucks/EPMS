using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPMSysLogin.Model
{
    public class Leave
    {
        public int Leave_ID { get; set; }
        public int Employee_ID { get; set; }
        public DateTime Date { get; set; }
        public string Reason { get; set; }
        public string other { get; set; }
     }
        

    }

