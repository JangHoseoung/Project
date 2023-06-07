using System.Windows.Forms;

namespace Lib.Windows.Frame
{

    public enum ePopMode { none, add, modify, };
    public partial class MasterPop : Form
    {
        protected ePopMode m_popMode;
        public MasterPop()
        {
            InitializeComponent();
            m_popMode = ePopMode.none;
        }

        public virtual DialogResult
            ShowDialog(ePopMode aMode, object aParam)
        {
            m_popMode = aMode;
            return this.ShowDialog();
        }

    }
}
