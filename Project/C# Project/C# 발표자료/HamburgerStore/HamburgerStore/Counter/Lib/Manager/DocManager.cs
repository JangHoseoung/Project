using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib.Manager
{
    class DBInfo{
        public string _Addr;
        public int  _Port;
        public string _Id;
        public string _Pwd;
        public string _DataBase;
    }

    class DocManager
    {
        private IniManager m_IniManager;
        private DBInfo m_DBInfo;

        public DocManager() { 
            m_IniManager = new IniManager();
            m_IniManager.Path = System.IO.Directory.GetCurrentDirectory() + "/information.ini";

            m_DBInfo = new DBInfo();
        }
        public DBInfo ReadDBInfo()
        {
            m_DBInfo._Addr = m_IniManager.ReadString("db", "addr", "localhost");
            m_DBInfo._Port = m_IniManager.ReadInteger("db", "port", 1521);
            m_DBInfo._Id = m_IniManager.ReadString("db", "id", "KB");
            m_DBInfo._Pwd = m_IniManager.ReadString("db", "pwd", "kb602");
            m_DBInfo._DataBase = m_IniManager.ReadString("db", "database", "xe");
            return m_DBInfo;
        }

        public void SaveDBInfo() {
            m_IniManager.WriteString("db", "addr", m_DBInfo._Addr);
            m_IniManager.WriteInteger("db", "port", m_DBInfo._Port);
            m_IniManager.WriteString("db", "id", m_DBInfo._Id);
            m_IniManager.WriteString("db", "pwd", m_DBInfo._Pwd);
            m_IniManager.WriteString("db", "database", m_DBInfo._DataBase);
        }

    }
}
