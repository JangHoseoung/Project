using Lib.Windows.Frame;
using System;
using System.Windows.Forms;

namespace Hamburger_kiosk.Window.Pop
{
    public partial class Kiosk_Card_Pop : MasterPop
    {
        public Kiosk_Card_Pop()
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
            else if (aPopMode == ePopMode.modify)
            {

            }
            else if (aPopMode == ePopMode.none)
            {
                CardTimer.Start();
            }

        }

        int m_timer_counter = 0;
        private void CardTimer_Tick(object sender, EventArgs e)
        {
            if (m_timer_counter == 0)
            {
                panel_message0.Visible = true;
            }
            else if (m_timer_counter == 26)
            {
                label_message.Text = "카드 정보를 읽고 있습니다.";
                //panel_message1.Visible = true;
            }
            else if (m_timer_counter == 50)
            {
                label_message.Text = "카드 승인 대기중.";
                //panel_message2.Visible = true;
            }
            else if (m_timer_counter == 100)
            {
                label_message.Text = "결제완료.";
                //panel_message3.Visible = true;
            }
            else if (m_timer_counter == 120)
            {
                CardTimer.Stop();
                DialogResult = DialogResult.OK;
            }
            if (m_timer_counter <= 100)
            {
                progress_card.Value = m_timer_counter;
            }
            m_timer_counter += 2;
        }

        private void progress_card_Click(object sender, EventArgs e)
        {

        }
    }
}
