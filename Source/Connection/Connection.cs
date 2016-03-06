using System.Data;
using System.Data.SqlClient;

namespace Connection
{
    public class Connection
    {
        public int commandTimeout = 300;
        private System.Data.SqlClient.SqlConnection conn = null;
        private System.Data.SqlClient.SqlTransaction transaction = null;

        public void BeginTransaction()
        {
            transaction = conn.BeginTransaction("TMT");
        }

        public void Commit()
        {
            if (transaction != null)
                transaction.Commit();
        }

        public void RollBack()
        {
            if (transaction != null)
                transaction.Rollback();
        }

        public string ConnectionString()
        {
            if (conn != null)
            {
                return conn.ConnectionString;
            }
            return "";
        }

        public Connection(string connectionString)
        {
            conn = new SqlConnection(connectionString);
        }

        public void Close()
        {
            if (conn != null && conn.State == System.Data.ConnectionState.Open)
                conn.Close();
            if (transaction != null)
                transaction = null;
        }

        public int ExecuteNonQuerySQL(string sql)
        {
            SqlCommand command = new SqlCommand();
            command.CommandTimeout = commandTimeout;
            command = new SqlCommand(sql, conn);
            if (transaction != null)
                command.Transaction = transaction;
            command.CommandType = CommandType.Text;
            return command.ExecuteNonQuery();
        }

        public DataTable ExecuteNonQueryData(string strProc)
        {
            DataTable dt = new DataTable();
            SqlCommand command = new SqlCommand();
            command.CommandTimeout = commandTimeout;
            SqlDataAdapter adapter = null;

            command = new SqlCommand(strProc, conn);
            command.CommandType = CommandType.StoredProcedure;
            adapter = new SqlDataAdapter(command);
            adapter.Fill(dt);
            return dt;
        }

        public DataTable ExecuteNonQueryData(string strProc, System.Collections.Generic.List<SqlParameter> lsParaInput)
        {
            DataTable dt = new DataTable();
            SqlCommand command = new SqlCommand();
            command.CommandTimeout = commandTimeout;
            SqlDataAdapter adapter = null;

            command = new SqlCommand(strProc, conn);
            command.CommandType = CommandType.StoredProcedure;
            if (lsParaInput != null && lsParaInput.Count > 0)
                foreach (var item in lsParaInput)
                    command.Parameters.Add(item);
            adapter = new SqlDataAdapter(command);
            adapter.Fill(dt);
            return dt;
        }

        public int ExecuteNonQuery(string strProc, System.Collections.Generic.List<SqlParameter> lsParaInput)
        {
            SqlCommand command = new SqlCommand();
            command.CommandTimeout = commandTimeout;
            command = new SqlCommand(strProc, conn);
            command.CommandType = CommandType.StoredProcedure;

            if (lsParaInput != null && lsParaInput.Count > 0)
                foreach (var item in lsParaInput)
                    command.Parameters.Add(item);
            return command.ExecuteNonQuery();
        }

        public object ExecuteScalar(string strProc, System.Collections.Generic.List<SqlParameter> lsParaInput)
        {
            SqlCommand command = new SqlCommand();
            command.CommandTimeout = commandTimeout;
            command = new SqlCommand(strProc, conn);
            command.CommandType = CommandType.StoredProcedure;

            if (lsParaInput != null && lsParaInput.Count > 0)
                foreach (var item in lsParaInput)
                    command.Parameters.Add(item);
            return command.ExecuteScalar();
        }

        public void Open()
        {
            if (conn != null && conn.State != System.Data.ConnectionState.Open)
                conn.Open();
        }

        public System.Data.DataTable Select(string sql)
        {
            DataTable dt = new DataTable();
            SqlCommand command = new SqlCommand();
            command.CommandTimeout = commandTimeout;
            SqlDataAdapter adapter = null;
            command.Connection = conn;
            command.CommandType = CommandType.Text;
            command.CommandText = sql;
            if (transaction != null)
                command.Transaction = transaction;
            adapter = new SqlDataAdapter(command);
            adapter.Fill(dt);
            return dt;
        }

        public System.Data.DataSet SelectDataSet(string sql)
        {
            DataSet ds = new DataSet();
            SqlCommand command = new SqlCommand();
            command.CommandTimeout = commandTimeout;
            SqlDataAdapter adapter = null;
            command.Connection = conn;
            command.CommandType = CommandType.Text;
            command.CommandText = sql;
            if (transaction != null)
                command.Transaction = transaction;
            adapter = new SqlDataAdapter(command);
            adapter.Fill(ds);
            return ds;
        }

        public int Update(DataTable dt, string sql)
        {
            SqlDataAdapter adapter = null;
            adapter = new SqlDataAdapter(sql, conn);
            SqlCommandBuilder command = new SqlCommandBuilder(adapter);
            return adapter.Update(dt);
        }

        public DataSet SelectDataSet(string strProc, System.Collections.Generic.List<SqlParameter> lsParaInput)
        {
            DataSet ds = new DataSet();
            SqlCommand command = new SqlCommand();
            command.CommandTimeout = commandTimeout;
            SqlDataAdapter adapter = null;
            command = new SqlCommand(strProc, conn);
            command.CommandType = CommandType.StoredProcedure;

            if (lsParaInput != null && lsParaInput.Count > 0)
                foreach (var item in lsParaInput)
                    command.Parameters.Add(item);

            adapter = new SqlDataAdapter(command);
            adapter.Fill(ds);
            return ds;
        }

        public DataTable Select(string strProc, System.Collections.Generic.List<SqlParameter> lsParaInput)
        {
            DataTable dt = new DataTable();
            SqlCommand command = new SqlCommand();
            command.CommandTimeout = commandTimeout;
            SqlDataAdapter adapter = null;
            command = new SqlCommand(strProc, conn);
            command.CommandType = CommandType.StoredProcedure;

            if (lsParaInput != null && lsParaInput.Count > 0)
                foreach (var item in lsParaInput)
                    command.Parameters.Add(item);

            adapter = new SqlDataAdapter(command);
            adapter.Fill(dt);
            return dt;
        }
    }
}