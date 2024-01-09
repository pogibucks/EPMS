using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPMSysLogin.Model
{
    public class Employee
    {
        public int Employee_ID { get; set; }
        public string FName { get; set; }
        public string Mname { get; set; }
        public string Lname { get; set; }
        public int Contact { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }
        public DateTime DoBirth { get; set; }
        public string Department_ID { get; set; }
       

    }
}
