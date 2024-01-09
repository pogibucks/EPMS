using EPMSysLogin.Model;
using EPMSysLogin.MyClass;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EPMSysLogin.Controller
{
    public static class LeaveController
    {
        public static bool Insert(Leave m)
        {
            var result = false;
            var sql = "INSERT INTO [dbo].[Leave] ([Date],[Reason],[other],[Employee_ID]) VALUES (@Date,@Reason,@other, @empId)";
            var param = new Dictionary<string, object>();
            param.Add("@Date", m.Date);
            param.Add("@Reason", m.Reason);
            param.Add("@other", m.other);
            param.Add("@empId", m.Employee_ID);
            try
            {
                result = DBHelper.ExecuteCommand(sql, param, System.Data.CommandType.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return result;

        }


        public static bool Update(Leave m)
        {
            var result = false;
            var sql = "UPDATE [dbo].[Leave] SET  [Date] = @Date,[Reason] = @Reason,[other] = @other ,[Employee_ID] = @Employee_ID  WHERE [Leave_ID] = @leaveId";
            var param = new Dictionary<string, object>();
            param.Add("@leaveId", m.Leave_ID);
            param.Add("@Date", m.Date);
            param.Add("@Reason", m.Reason);
            param.Add("@other", m.other);
            param.Add("@Employee_ID", m.Employee_ID);
            try
            {
                result = DBHelper.ExecuteCommand(sql, param, System.Data.CommandType.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return result;

        }

        public static bool Delete(int id)
        {
            var result = false;
            var sql = "DELETE FROM [dbo].[Leave] WHERE [Leave_ID] = @leaveId ";
            var param = new Dictionary<string, object>();
            param.Add("@leaveId", id);
            try
            {
                result = DBHelper.ExecuteCommand(sql, param, System.Data.CommandType.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return result;
        }


        public static List<Leave> Get()
        {
            var listOfLeave = new List<Leave>();
            foreach (DataRow i in DBHelper.GetData("SELECT * FROM [dbo].[Leave]", CommandType.Text).Rows)
            {
                var m = new  Leave();
                m.Leave_ID = int.Parse(i["Leave_ID"].ToString());
               m.Employee_ID = int.Parse(i["Employee_ID"].ToString());
                m.Date = DateTime.Parse(i["Date"].ToString());
                m.Reason = i["Reason"].ToString();
                m.other = i["other"].ToString();

                listOfLeave.Add(m);

            }
            
                return listOfLeave;
        }


    }
}
