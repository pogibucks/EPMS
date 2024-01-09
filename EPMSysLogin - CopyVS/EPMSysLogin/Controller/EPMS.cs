using EPMSysLogin.Model;
using EPMSysLogin.MyClass;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPMSysLogin.Controller
{
    public class EPMS
    {
        public static bool Insert (Employee m)
        {
            var sql = "INSERT INTO [dbo].[Employee] ([Employee_ID],[Fname],[Mname],[Lname],[Contact],[Address],[Gender],[DoBirth],[Department_ID])  " +
                "VALUES (@Employee_ID,@Fname,@Mname,@Lname,@Contact,@Address,@Gender,@DoBirth, @Department_ID)";
            var param = new Dictionary<string, object>();
            param.Add("@Employee_ID", m.Employee_ID);
            param.Add("@Fname", m.FName);
            param.Add("@Mname", m.Mname);
            param.Add("@Lname", m.Lname);
            param.Add("@Contact", m.Contact);
            param.Add("@Address", m.Address);
            param.Add("@Gender", m.Gender);
            param.Add("@DoBirth", m.DoBirth);
            param.Add("@Department_ID", m.Department_ID);

            return DBHelper.ExecuteCommand(sql, param, System.Data.CommandType.Text) ;
        }

        public static bool Update(Employee m)
        {
            var sql = "UPDATE [dbo].[Employee]   SET [Fname] = @Fname,[Mname] = @Mname,[Lname] = @Lname,[Contact] = @Contact,[Address] = @Address," +
                "[Gender] = @Gender,[DoBirth] = @DoBirth,[Department_ID] = @Department_ID WHERE [Employee_ID] = @Employee_ID ";
            var param = new Dictionary<string, object>();
            param.Add("@Employee_ID", m.Employee_ID);
            param.Add("@Fname", m.FName);
            param.Add("@Mname", m.Mname);
            param.Add("@Lname", m.Lname);
            param.Add("@Contact", m.Contact);
            param.Add("@Address", m.Address);
            param.Add("@Gender", m.Gender);
            param.Add("@DoBirth", m.DoBirth);
            param.Add("@Department_ID", m.Department_ID);




            return DBHelper.ExecuteCommand(sql, param, System.Data.CommandType.Text);

        }

        public static bool Delete(int employeeId)
        {
            var sql = "DELETE FROM [dbo].[Employee] WHERE [Employee_ID] = @id";
            var param = new Dictionary<string, object>();
            param.Add("@id", employeeId);
            return DBHelper.ExecuteCommand(sql, param, System.Data.CommandType.Text);

        }

        public static List<Employee> Get()
        {
            var listOfEmployees = new List<Employee>();
            var sql = "SELECT * FROM [dbo].[Employee]";
            foreach (DataRow  i in DBHelper.GetData(sql, CommandType.Text).Rows)
            {
                var m = new Employee();
                m.Employee_ID = int.Parse(i["Employee_ID"].ToString());
                m.FName = i["Fname"].ToString();
                m.Mname = i["Mname"].ToString();
                m.Lname = i["Lname"].ToString();
                m.Contact = int.Parse(i["Contact"].ToString());
                m.Address = i["address"].ToString();
                m.Gender = i["Gender"].ToString();
                m.DoBirth = DateTime.Parse(i["DoBirth"].ToString());
                m.Department_ID = i["Department_ID"].ToString();




                listOfEmployees.Add(m);
            }
            return listOfEmployees;
        }
    }
}
