using System;

using System.Data;
using System.Data.Common;
using System.Data.OracleClient;

namespace Lib.Manager
{
    class OracleManager
    {
        private String m_connectString = "";
        protected OracleConnection m_sqlConnection = null;
        public OracleManager()
        {
            m_connectString = "";
        }

        public OracleManager(String aHost, int aPort, string aID, string aPWD, string aDatabase)
        {
            m_connectString = string.Format(@"Data Source={0}:{1}/{2};User ID={3};Password={4}", aHost, aPort, aDatabase, aID, aPWD);
            m_sqlConnection = new OracleConnection(m_connectString);

        }
        public String MakeConnectString(string aHost, int aPort, string aID, string aPWD, string aDatabase)
        {
            if (aPort < 0)
            {
                aPort = 1521;
            }

            m_connectString = String.Format(@"Data Source={0}:{1}/{2};User ID={3};Password={4}", aHost, aPort, aDatabase, aID, aPWD);

            //string sql = "Data Source=127.0.0.1:1521/xe;User ID=hr;Password=hr";
            return m_connectString;
        }

        public bool TestConnection()
        {
            bool _success = false;
            try
            {
                m_sqlConnection.Open();
                _success = true;
                m_sqlConnection.Close();
            }
            catch { _success = false; }

            return _success;
        }

        public DbConnection NewConnection()
        {

            OracleConnection _connection = null;

            try
            {
                _connection = GetNewConnection();
                _connection.Open();
                _connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (_connection != null)
                {
                    _connection.Close();
                }
            }

            return _connection as DbConnection;
        }

        public OracleConnection GetNewConnection()
        {
            return new OracleConnection(m_connectString);
        }

        public DataTable SelectQuery(DbConnection _db_connection,
            string aQuery, string TableName)
        {
            OracleConnection connection = _db_connection as OracleConnection;

            DataTable _DataTable = new DataTable();
            try
            {
                if (connection == null)
                {
                    connection = GetNewConnection();
                }
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                OracleDataAdapter _SqlAdapter
                    = new OracleDataAdapter(aQuery, connection);

                int _count = _SqlAdapter.Fill(_DataTable);
            }
            catch (OracleException ex)
            {
                Console.WriteLine(ex.Message);

            }
            finally
            {
                connection.Close();
            }

            try
            {
                if (TableName.Length > 0)
                {
                    _DataTable.TableName = TableName;
                }
                else { }
            }
            catch { }
            return _DataTable;
        }

        public int ExcuteQuery(string aQuery)
        {
            int _count = 1;
            OracleConnection _connection = GetNewConnection();
            _connection.Open();
            OracleTransaction _trans = _connection.BeginTransaction();
            try
            {
                OracleCommand _cmd = new OracleCommand();
                _cmd.Connection = _connection;
                _cmd.Transaction = _trans;
                _cmd.CommandText = aQuery;
                _cmd.ExecuteNonQuery();
                _trans.Commit();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                _trans.Rollback();
                _count = -1;
            }
            finally
            {
                _connection.Close();
            }

            return _count;
        }


    }
}
