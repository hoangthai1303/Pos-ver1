using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Net;
using System.Data.Common;
using System.Data.OleDb;
using System.Configuration;

namespace Helpers.BlankConnection
{
    public class ETDataConnection
    {
        private SqlConnection mConn = null;
        private DbConnection objConnection;
        private DbCommand objCommand;
        private DbDataAdapter objAdapter;
        private DbProviderFactory objFactory = null;
        public ETDataConnection(string conStr)
        {
            try
            {
                mConn = new SqlConnection(conStr);
                if (mConn.State == ConnectionState.Closed)
                    mConn.Open();
                this.connectDB(conStr);
            }
            catch//(Exception ex)
            {
                //throw (ex);
                //Environment.Exit(1);
            }
        }
        public SqlConnection Conn
        {
            get { return mConn; }
            set { mConn = value; }
        }
        public void Open()
        {
            if (mConn.State == ConnectionState.Closed)
                mConn.Open();
        }

        public void Close()
        {
            if (mConn.State == ConnectionState.Open)
                mConn.Close();
        }
        public object ExecuteScalar(string strSql)
        {
            object objReturn = null;
            try
            {
                SqlCommand command = new SqlCommand(strSql, mConn);

                command.CommandTimeout = 60000;
                objReturn = command.ExecuteScalar();
                if (objReturn == null)
                    objReturn = "0";

                command.Dispose();
            }
            catch (Exception ex)
            {
                this.InsertNewLog(ex, strSql);
                return null;
            }
            if (objReturn.GetType() == typeof(System.DBNull))
                objReturn = null;
            return objReturn;
        }
        public bool ExecuteNoneQuery(string strSql)
        {
            try
            {
                SqlCommand command = new SqlCommand(strSql, mConn);
                command.CommandTimeout = 60000;
                command.ExecuteNonQuery();
                command.Dispose();
            }
            catch (Exception ex)
            {

                this.InsertNewLog(ex, strSql);

                return false;
            }
            return true;
        }
        public long ExecuteNoneQueryWithResult(string strSql)
        {
            long mintResult;
            try
            {
                SqlCommand command = new SqlCommand(strSql, mConn);
                mintResult = Convert.ToInt64(command.ExecuteScalar());
                command.Dispose();
            }
            catch
            {
                return -1;
            }
            return mintResult;
        }
        public DataTable GetDataTable(string strSql)
        {
            SqlDataAdapter da = null;
            DataTable tTable = new DataTable();
            try
            {

                //da = new SqlDataAdapter(strSql, mConn);
                da = new SqlDataAdapter();

                SqlCommand command = new SqlCommand(strSql, mConn);
                command.CommandTimeout = 50000;
                da.SelectCommand = command;

                da.Fill(tTable);

            }
            catch (Exception ex)
            {
                this.InsertNewLog(ex, strSql);
            }
            finally
            {
                da.Dispose();
            }
            return tTable;
        }
        public bool ExecuteStoreProcedure(string strStoreProcName, SqlParameter[] ParamsList)
        {
            SqlCommand sqlCMD = null;

            try
            {
                sqlCMD = new SqlCommand(strStoreProcName, mConn);

                sqlCMD.CommandType = CommandType.StoredProcedure;
                foreach (SqlParameter para in ParamsList)
                    sqlCMD.Parameters.Add(para);
                sqlCMD.ExecuteNonQuery();
            }
            catch
            {
                return false;
            }
            finally
            {
                sqlCMD.Dispose();
            }
            return true;
        }

        public void ClearParameter()
        {
            if (objCommand != null)
            {
                objCommand.Parameters.Clear();
            }
        }

        private void connectDB(string connectionstring)
        {
            try
            {
                objFactory = SqlClientFactory.Instance;
                string providername = ConfigurationManager.ConnectionStrings["connectionstring"].ProviderName;
                objFactory = SqlClientFactory.Instance;
            
                objConnection = objFactory.CreateConnection();
                objCommand = objFactory.CreateCommand();
                //Chinh sua tang thoi gian xuat excel khi goi store len 20 phut
                objCommand.CommandTimeout = 1200;
                objConnection.ConnectionString = connectionstring;
                objCommand.Connection = objConnection;
                objCommand.Parameters.Clear();
            }
            catch (Exception ex)
            {
                //log.Fatal(ex.ToString());
            }
        }

        public int AddParameter(string name, object value)
        {
            DbParameter p = objFactory.CreateParameter();
            p.ParameterName = name;
            p.Value = value;
            return objCommand.Parameters.Add(p);
        }

        public DataTable ExecuteDataTable(string query, CommandType commandtype)
        {
            DbDataAdapter adapter = objFactory.CreateDataAdapter();
            objCommand.CommandText = query;
            objCommand.CommandType = commandtype;
            adapter.SelectCommand = objCommand;
            DataTable dt = new DataTable();
            try
            {
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {

            }
            finally
            {
                objCommand.Parameters.Clear();
                if (objConnection.State == System.Data.ConnectionState.Open)
                {
                    objConnection.Close();
                }
            }
            return dt;
        }
        public void InsertNewLog(Exception ex, string description)
        {
            //Log olog = new Log();
            //olog.HelpLink = ex.HelpLink;
            //olog.Message = ex.Message;
            //olog.Source = ex.Source;
            //olog.StackTrace = ex.StackTrace;
            //olog.Logger = "GDataConnection";
            //olog.Description = description;
            //olog.InsertNewLog();

            // GDataConnection gConn = new GDataConnection(this.g);
            //Bug oBug = new Bug(this);
            //oBug.HelpLink = ex.HelpLink;
            //oBug.Message = ex.Message;
            //oBug.Description = description;
            //oBug.Source = ex.Source;
            //oBug.StackTrace = ex.StackTrace;
            //oBug.Logger = "Tự động";
            //oBug.CreateDate = DateTime.Now;
            //oBug.BugStatus = BugStatusEN.NotFix;
            //oBug.BugType = BugTypeEN.ProgramBug;
            //oBug.FixDate = Convert.ToDateTime("1/1/1900");
            //oBug.HostName = Dns.GetHostName();
            //oBug.AddNew();
        }
    }
}
