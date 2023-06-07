
//using BookPlus.Manager;
using Lib.Manager;
using Lib.Windows.Frame;
using System;
using System.Windows.Forms;

namespace KB.Windows.Pop
{
    public partial class ConnectSettingPop : MasterPop
    {
        //ini파일 관리용 클래스
        private IniManager m_IniManager = null;

        //db접속정보를 저장하는 변수
        private string m_addr;
        private string m_database;
        private string m_id;
        private string m_pwd;
        private int m_port;

        public string Addr { get { return tbox_addr.Text; } }
        public string Database { get { return tbox_database.Text; } }
        public string Id { get { return tbox_id.Text; } }
        public string Pwd { get { return tbox_pwd.Text; } }
        public int Port { get { return int.Parse(tbox_port.Text); } }



        public ConnectSettingPop()
        {
            InitializeComponent();
            CreateObject();
            InitializeObject();
        }

        private void CreateObject()
        {
            m_IniManager = new IniManager();
        }
        private void InitializeObject()
        {
            m_IniManager.Path =
                System.IO.Directory.GetCurrentDirectory() + "/information.ini";

            string _tempo = m_IniManager.Path;
            ReadDBInformation();
            DisplayDBInformation();
        }

        private void btn_test_Click(object sender, EventArgs e)
        {
            OracleManager _OracleManager = new OracleManager(Addr, Port, Id, Pwd, Database);
            bool _bConnect = _OracleManager.TestConnection();
            if (_bConnect)
            {
                MessageBox.Show("오라클 접속 성공");
            }
            else
            {
                MessageBox.Show("오라클 접속 실패");
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            WriteDBInformation();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void ConnectSettingPop_Load(object sender, EventArgs e)
        {

        }

        private void ReadDBInformation()
        {
            m_addr = m_IniManager.ReadString("db", "addr", "localhost");
            m_database = m_IniManager.ReadString("db", "database", "xe");
            m_id = m_IniManager.ReadString("db", "id", "KB");
            m_pwd = m_IniManager.ReadString("db", "pwd", "kb602");
            m_port = m_IniManager.ReadInteger("db", "port", 1521);
        }
        private void DisplayDBInformation()
        {
            tbox_addr.Text = m_addr;
            tbox_port.Text = m_port.ToString();
            tbox_id.Text = m_id;
            tbox_pwd.Text = m_pwd;
            tbox_database.Text = m_database;
        }
        private void WriteDBInformation()
        {
            m_IniManager.WriteString("db", "addr", Addr);
            m_IniManager.WriteString("db", "id", Id);
            m_IniManager.WriteString("db", "pwd", Pwd);
            m_IniManager.WriteString("db", "database", Database);
            m_IniManager.WriteInteger("db", "port", Port);

        }
    }
}
