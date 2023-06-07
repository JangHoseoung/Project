using System;
using System.Windows.Forms;

namespace Lib.Windows.Frame
{
    public partial class MasterView : Form
    {
        public MasterView()
        {
            this.Visible = false;
            this.TopLevel = false;
            this.Left = 0;
            this.Top = 0;
            InitializeComponent();
        }

        private void MasterView_Load(object sender, EventArgs e)
        {

        }
    }
}
