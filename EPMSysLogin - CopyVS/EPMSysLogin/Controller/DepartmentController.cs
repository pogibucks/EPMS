using EPMSysLogin.Model;
using EPMSysLogin.MyClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPMSysLogin.Controller
{
    internal class DepartmentController
    {
        public static bool Insert(Department m)
        {
            var sql = "INSERT INTO [dbo].[Department]([Department_ID],[Name]  " + " Values(@Department_ID,@Name)";
            var param = new Dictionary<string, object>();
            param.Add("@Department_ID", m.DepartmentID);
            param.Add("@Nname", m.Name);


            return DBHelper.ExecuteCommand(sql, param, System.Data.CommandType.Text);
        }

        public static bool Update(Department m)
        {
            var sql = "UPDATE [dbo].[Department]SET [Department_ID] = <Department_ID,[Name] = <Name,WHERE <Search Conditions>";
            var param = new Dictionary<string, object>();
            param.Add("@DepartmentID", m.DepartmentID);
            param.Add("@Name", m.Name);


            return DBHelper.ExecuteCommand(sql, param, System.Data.CommandType.Text);

        }
        public static bool Delete( Department m)
        {
            var sql = "DELETE FROM [dbo].[Department]WHERE <Search Conditions>";
            var param = new Dictionary<string, object>();
            param.Add("@DepartmentID", m.DepartmentID);
            param.Add("@Nname", m.Name);

            return DBHelper.ExecuteCommand(sql, param, System.Data.CommandType.Text);

        }
    }
}