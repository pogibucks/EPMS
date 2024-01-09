using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EPMSysLogin.MyClass
{
    public static class ServerConfig
    {
        public static string ConnectionString => "Data Source=LAPTOP-4BQBNBMB;Initial Catalog=HGB_DB; Integrated Security=True";
    }
    public static class DBHelper
    {
        public static SqlParameter[] ParameterBuilder(Dictionary<string, object> param)
        {
            return param.Select((KeyValuePair<string, object> x) => new SqlParameter($"{x.Key}", x.Value)).ToArray();
        }
        /// <summary>
        /// Metthod for executing Insert, Update and Delete
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="parameters"></param>
        /// <param name="commandType"></param>
        /// <returns></returns>
        public static bool ExecuteCommand(string sql, Dictionary<string, object> parameters, CommandType commandType)
        {
            bool result = false;
            //Connnection
            using (SqlConnection conn = new SqlConnection(ServerConfig.ConnectionString))
            {
                if (conn.State == System.Data.ConnectionState.Closed)
                {
                    conn.Open();
                }
                try
                {
                    SqlCommand cmd = new SqlCommand(sql, conn);

                    cmd.CommandType = commandType;
                    cmd.CommandTimeout = 0;
                    cmd.Parameters.AddRange(ParameterBuilder(parameters));
                    cmd.ExecuteNonQuery();
                    result = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            return result;
        }

        /// <summary>
        /// Method for getting data from database
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="commandType"></param>
        /// <param name="param"></param>
        /// <returns></returns>
        public static DataTable GetData(string sql, CommandType commandType, Dictionary<string, object> param = null)
        {
            var dt = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(ServerConfig.ConnectionString))
                {
                    if (conn.State == System.Data.ConnectionState.Closed)
                        conn.Open();

                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.CommandType = commandType;
                    cmd.CommandTimeout = 0;
                    if (param != null)
                    {
                        cmd.Parameters.AddRange(ParameterBuilder(param));
                    }
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        dt.Load(reader);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dt;
        }
    }
}

