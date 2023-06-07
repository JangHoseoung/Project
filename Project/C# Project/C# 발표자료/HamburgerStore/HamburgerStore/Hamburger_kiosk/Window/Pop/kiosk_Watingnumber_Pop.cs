using Lib.Windows.Frame;
using System;
using System.Windows.Forms;
namespace Hamburger_kiosk.Window.Pop
{
    public partial class kiosk_Watingnumber_Pop : MasterPop
    {
        public kiosk_Watingnumber_Pop()
        {
            InitializeComponent();
        }
        public override DialogResult ShowDialog(ePopMode aMode, object aParam)
        {
            Initialize(aMode, aParam);
            return base.ShowDialog(aMode, aParam);
        }

        private void Initialize(ePopMode aPopMode, object aParam)
        {
            if (aPopMode == ePopMode.add)
            {
            }
            else if (aPopMode == ePopMode.none)
            {
                if (aParam != null && aParam is int)
                {
                    int _wait_num = (int)aParam;
                    waiting_label.Text = _wait_num.ToString();
                }
            }
        }
        private void kiosk_Watingnumber_Pop_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
