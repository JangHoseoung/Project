using KB.Windows.Pop;
using Counter.Window.Pop;
using Counter.Window.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Counter
{
    public enum eViewMode
    {
        login = 0,
        Product = 1,
        Member = 2,
        Orders = 3,
        Statics = 4
    }
    public partial class Counter_Main : Form
    {
        private Counter_login m_Counter_login = null;
        private Counter_Product m_Counter_product = null;
        private Counter_Member m_Counter_member = null;
        private Counter_Orders m_Counter_Orders = null;
        private Counter_Analyze m_Counter_Analyze = null;
        public Counter_Main()
        {
            InitializeComponent();
            CreateObject();
            InitializeObject();
        }

        private void CreateObject()
        {
            m_Counter_login = new Counter_login();
            m_Counter_product = new Counter_Product();
            m_Counter_member = new Counter_Member();
            m_Counter_Orders = new Counter_Orders();
            m_Counter_Analyze = new Counter_Analyze();
        }

        private void InitializeObject()
        {
            //m_Counter_login.Parent = WorkZonePanel;
            //m_Counter_login.Dock = DockStyle.Fill;

            //m_Counter_product.Parent = WorkZonePanel;
            //m_Counter_product.Dock = DockStyle.Fill;

            //m_Counter_member.Parent = WorkZonePanel;
            //m_Counter_member.Dock = DockStyle.Fill;

            //m_Counter_Orders.Parent = WorkZonePanel;
            //m_Counter_Orders.Dock = DockStyle.Fill;

            //m_Counter_Analyze.Parent = WorkZonePanel;
            //m_Counter_Analyze.Dock = DockStyle.Fill;

            //ShowView(eViewMode.Product);
        }

        private void ShowView(eViewMode amode)
        {
            if(amode == eViewMode.Product)
            {
                m_Counter_Analyze.Visible = false;
                m_Counter_member.Visible = false;
                m_Counter_Orders.Visible = false;
                m_Counter_product.Show();
                this.Text = "카운터 [제품관리]";
            }
            else if(amode == eViewMode.Member)
            {
                m_Counter_Analyze.Visible = false;
                m_Counter_Orders.Visible = false;
                m_Counter_product.Visible = false;
                m_Counter_member.Show();
                this.Text = "카운터 [사원관리]";
            }
            else if(amode == eViewMode.Orders)
            {
                m_Counter_Analyze.Visible = false;
                m_Counter_member.Visible= false;
                m_Counter_product.Visible = false;
                m_Counter_Orders.Show();
                this.Text = "카운터 [주문]";
            }
            else
            {
                m_Counter_Analyze.Show();
                m_Counter_member.Visible = false;
                m_Counter_product.Visible = false;
                m_Counter_Orders.Visible=false;
                this.Text = "카운터 [분석]";
            }
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripDropDownButton2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {

        }

        private void 상품관리ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowView(eViewMode.Product);
        }

        private void 로그인ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void dB환경설정ToolStripMenuItem_Click(object sender, EventArgs e)
        {
              
        }

        private void 사원관리ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowView(eViewMode.Member);
        }

        private void 주문확인ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowView(eViewMode.Orders);
        }

        private void 통계조회ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowView(eViewMode.Statics);
        }

        private void WorkZonePanel_Paint(object sender, PaintEventArgs e)
        {
            ShowView(eViewMode.login);
        }

        private void dB환경설정ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ConnectSettingPop _pop = new ConnectSettingPop();
            _pop.ShowDialog();
        }
    }
}
