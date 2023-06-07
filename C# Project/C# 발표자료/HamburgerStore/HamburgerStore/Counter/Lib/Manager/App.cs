using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib.Manager
{
    class App
    {
        private static App m_instance;

        protected App() { }

        public static App Instance()
        {
            if(m_instance == null)
            {
                m_instance = new App();
            }
            return m_instance;
        }

        private DBManager m_DBManager;
        public DBManager DBManager
        {
            get { return m_DBManager; }
            set { m_DBManager = value; }
        }

        private DocManager m_DocManager;
        public DocManager DocManager { 
            get { return m_DocManager; }
            set { m_DocManager = value; }
        }
    }
}
