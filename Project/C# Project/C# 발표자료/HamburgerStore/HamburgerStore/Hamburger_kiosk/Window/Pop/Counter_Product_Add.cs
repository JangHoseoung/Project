using Lib.Manager;
using Lib.Windows.Frame;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Counter.Window.View
{
    public partial class Counter_Product_Add : MasterPop
    {
        private int m_goods_number = -1;
        public Counter_Product_Add()
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
                label_title.Text = "메뉴 추가";
                cbox_category.SelectedIndex = 0;
                tbox_name.Text = "새상품";
                tbox_price.Text = "0";
                tbox_description.Text = "";

            }
            else if (aPopMode == ePopMode.modify)
            {

                label_title.Text = "메뉴 수정";
                if (aParam is DataRow)
                {
                    DataRow _dp_row = (DataRow)aParam;

                    m_goods_number = Convert.ToInt32(_dp_row["goods_number"]);
                    if (_dp_row["ctr_typenumber"] != System.DBNull.Value)
                    {
                        cbox_category.SelectedIndex = Convert.ToInt32(_dp_row["ctr_typenumber"]) - 1;

                    }
                    else
                    {

                        cbox_category.SelectedIndex = 0;
                    }

                    tbox_name.Text = Convert.ToString(_dp_row["goods_name"]);// "새상품";
                    tbox_price.Text = Convert.ToString(_dp_row["goods_price"]);
                    tbox_description.Text = Convert.ToString(_dp_row["goods_description"]);

                    string _goods_picture = Convert.ToString(_dp_row["goods_picture"]);
                    if (_goods_picture.Length > 0)
                    {
                        byte[] _byte = HexStringToByteArray(_goods_picture);
                        pbox_goods.Image = new Bitmap(new MemoryStream(_byte));
                        pbox_goods.Tag = _goods_picture;

                    }

                }

            }

        }
        private byte[] HexStringToByteArray(string hex)
        {
            int NumberChars = hex.Length;
            byte[] bytes = new byte[NumberChars / 2];
            if (NumberChars % 2 == 0)
            {
                for (int i = 0; i < NumberChars; i += 2)
                {
                    bytes[i / 2] = Convert.ToByte(hex.Substring(i, 2), 16);
                }
            }
            return bytes;
        }


        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (m_popMode == ePopMode.add)
            {
                Save4Add();
            }
            else if (m_popMode == ePopMode.modify)
            {
                Save4Modify();
            }
        }

        private void Save4Add()
        {
            int _category = cbox_category.SelectedIndex + 1;
            string _name = tbox_name.Text;
            int _price = 0;
            int.TryParse(tbox_price.Text, out _price);
            string _description = tbox_description.Text;
            string _goods_picture = pbox_goods.Tag as string;

            // 유효성 체크
            if (_name.Trim().Length == 0)
            {
                MessageBox.Show("상품명을 입력해주세요.");
                return;
            }
            if (_price <= 0)
            {
                MessageBox.Show("상품 가격은 0보다 큰 값을 입력해주세요.");
                return;
            }

            int _result = App.Instance().DBManager.SaveProduct(_category, _name, _price, _description, _goods_picture);
            if (_result > 0)
            {
                MessageBox.Show("저장성공");
                tbox_name.Text = "새상품";
                tbox_price.Text = "0";
                tbox_description.Text = "";
                DialogResult = DialogResult.OK;
            }
            else if (_result == 0)
            {
                MessageBox.Show("저장실패");
            }
            else if (_result == -999)
            {
                MessageBox.Show("접속실패");
            }
            else if (_result == -1)
            {
                MessageBox.Show("쿼리 실행 중 오류가 발생했습니다.");
            }
        }

        private void Save4Modify()
        {
            int _category = cbox_category.SelectedIndex + 1;
            string _name = tbox_name.Text;
            int _price = Convert.ToInt32(tbox_price.Text);
            string _description = tbox_description.Text;
            string _goods_picture = pbox_goods.Tag as string;
            int _result = App.Instance().DBManager.ModifyProduct(m_goods_number, _category, _name, _price, _description, _goods_picture);
            if (_result > 0)
            {
                MessageBox.Show("수정성공");
                tbox_name.Text = "새상품";
                tbox_price.Text = "0";
                tbox_description.Text = "";
                DialogResult = DialogResult.OK;
            }
            else if (_result == -999)
            {
                MessageBox.Show("접속실패");
            }
            else
            {
                MessageBox.Show("수정실패");
            }
        }

        private void Counter_Product_Add_Load(object sender, EventArgs e)
        {

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
        private void btn_upload_Click(object sender, EventArgs e)
        {
            string _image_file = string.Empty;
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "PNG|*.png|JPG|*.jpg|BMP|*.bmp|all files|*.*";
            ofd.InitialDirectory = Application.StartupPath;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                _image_file = ofd.FileName;
                pbox_goods.Image = Bitmap.FromFile(_image_file);


                FileStream fs = new FileStream(_image_file, FileMode.Open, FileAccess.Read);
                byte[] bImage = new byte[fs.Length];
                fs.Read(bImage, 0, (int)fs.Length);

                StringBuilder hex = new StringBuilder(bImage.Length * 2);
                foreach (byte b in bImage)
                {
                    hex.AppendFormat("{0:X2}", b);
                }
                string _hex_image = hex.ToString();
                pbox_goods.Tag = _hex_image;
            }

        }
    }
}
