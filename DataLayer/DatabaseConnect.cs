using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.IO;

namespace DataLayer
{
    public class DataConnector
    {
        public string ErrorMessage = "";
        protected OleDbDataAdapter DataAdapter1 = new OleDbDataAdapter();
        public DataConnector(string ConnectionString)
        {
            OleDbConnection Connection1 = new OleDbConnection(ConnectionString);
            this.DataAdapter1.SelectCommand = new OleDbCommand("", Connection1);
            this.DataAdapter1.InsertCommand = new OleDbCommand("", Connection1);

        }
        public DataTable DataSelect(string query)
        {
            DataTable dt = new DataTable();
            try
            {
                DataAdapter1.SelectCommand.CommandText = query;
                DataAdapter1.SelectCommand.Connection.Open();
                DataAdapter1.Fill(dt);
                DataAdapter1.SelectCommand.Connection.Close();
                ErrorMessage = "";
            }
            catch(Exception err)
            {
                ErrorMessage = err.Message;
                DataAdapter1.SelectCommand.Connection.Close();
            }
            return dt;
        }
        public string DataScalar(string query)
        {
            string Scalar = "";
            try
            {
                query = query.Replace("GetDate()", "Now()");
                query = query.Replace("!=", "<>");
                DataAdapter1.SelectCommand.CommandText = query;
                DataAdapter1.SelectCommand.Connection.Open();
                object test = DataAdapter1.SelectCommand.ExecuteScalar();
                if(test != null)
                {
                    Scalar = test.ToString();
                }
                DataAdapter1.SelectCommand.Connection.Close();

                ErrorMessage = "";
            }
            catch (Exception err)
            {
                Scalar = "";
                ErrorMessage = err.Message;
                DataAdapter1.SelectCommand.Connection.Close();
            }
            return Scalar;
        }
        public int DataInsert(string query)
        {
            int Result = 0;
            try
            {
                DataAdapter1.InsertCommand.CommandText = query;
                DataAdapter1.InsertCommand.Connection.Open();
                Result = DataAdapter1.InsertCommand.ExecuteNonQuery();
                DataAdapter1.InsertCommand.Connection.Close();
                ErrorMessage = "";
                return Result;
            }
            catch (Exception err)
            {
                ErrorMessage = err.Message;
                DataAdapter1.InsertCommand.Connection.Close();
            }
            return Result;
        }
        public int DataUpdate(string query)
        {
            return DataInsert(query);
        }
        public int DataDelete(string query)
        {
            return DataInsert(query);
        }
    }
}
