using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.AutoGeneratedCode;

namespace DataLayer.DataBaseManager
{
    public class ExceptionLog
    {
        public static void LogDBException(ExceptionModel exceptionModel)
        {
            DataSet ds = new DataSet();
            string connectionString = string.Empty;
            try
            {
                using (FTSContext ft = new FTSContext())
                {
                    connectionString = ft.TblConnectionStrings.FirstOrDefault(x => x.Name == "LocalDBString").Value;
                    //connectionString = "data source = SUMIT; initial catalog = FTS; integrated security = True;";
                }

                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    sqlCon.Open();
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = sqlCon;
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.CommandText = "spLogDBException";
                        cmd.Parameters.Add("@ExceptionMsg", System.Data.SqlDbType.VarChar).Value = exceptionModel.Exception.Message.ToString();
                        cmd.Parameters.Add("@ExceptionType", System.Data.SqlDbType.VarChar).Value = exceptionModel.Exception.GetType().Name.ToString();
                        cmd.Parameters.Add("@ExceptionSource", System.Data.SqlDbType.VarChar).Value = exceptionModel.Exception.StackTrace.ToString();
                        cmd.Parameters.Add("@ExceptionURL", System.Data.SqlDbType.VarChar).Value = exceptionModel.ExceptionURL;
                        cmd.Parameters.Add("@UserId", System.Data.SqlDbType.VarChar).Value = exceptionModel.UserId;

                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            da.Fill(ds);
                        }
                    }
                }
            }
            catch (Exception ex)
            { }


        }
    }
}
