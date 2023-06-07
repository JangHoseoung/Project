using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace KB.Window.UC
{
    public partial class GoodsButton : UserControl
    {
        public delegate int evtButtonClick(object sender, EventArgs e);
        public event evtButtonClick OnGoodsClick;
        private int m_ucode;
        private int m_price;
        private string m_picture = "";

        // Control의 속성값을 정의
        [Category("UserProperty"), Description("GoodsImage")]
        public Image GoodsImage
        {
            get { return pbox_goods.BackgroundImage; }
            set { pbox_goods.BackgroundImage = value; }
        }

        [Category("UserProperty"), Description("GoodsName")]
        public string GoodsName
        {
            get
            {
                return this.label_name.Text;
            }
            set
            {
                this.label_name.Text = value;
            }
        }

        [Category("UserProperty"), Description("GoodsPrice")]
        public int GoodsPrice
        {
            get
            {
                return m_price;
            }
            set
            {
                m_price = value;
                this.label_price.Text = string.Format("{0:N0}원", m_price);
            }
        }


        [Category("UserProperty"), Description("GoodsUcode")]
        public int GoodsUcode
        {
            get
            {
                return m_ucode;
            }
            set
            {
                m_ucode = value;
            }
        }
        public GoodsButton()
        {
            InitializeComponent();
        }

        private void label_price_Click(object sender, EventArgs e)
        {
            if (OnGoodsClick != null)
            {
                this.OnGoodsClick(this, null);
            }
        }

        private void label_name_Click(object sender, EventArgs e)
        {

            if (OnGoodsClick != null)
            {
                this.OnGoodsClick(this, null);
            }
        }

        private void pbox_goods_Click(object sender, EventArgs e)
        {

            if (OnGoodsClick != null)
            {
                this.OnGoodsClick(this, null);
            }
        }
    }
}
