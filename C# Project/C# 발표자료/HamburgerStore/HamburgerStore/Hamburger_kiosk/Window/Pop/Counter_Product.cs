using Lib.Manager;
using Lib.Windows.Frame;
using System;
using System.Data;
using System.Windows.Forms;

namespace Counter.Window.View
{
    public partial class Counter_Product : Form
    {
        public Counter_Product()
        {
            InitializeComponent();
            cbox_category.SelectedIndex = 0;
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Counter_Product_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            DoSearch();
        }
        private void DoSearch()
        {
            int _category = cbox_category.SelectedIndex;
            string _name = tbox_name.Text;

            DataTable _db_table = App.Instance().DBManager.ReadGoods(_category, _name);

            DataTable _dp_table = DisplaySet.Tables["dp_goods"];
            _dp_table.Rows.Clear();
            foreach (DataRow _db_row in _db_table.Rows)
            {
                DataRow _dp_row = _dp_table.NewRow();
                _dp_row["goods_name"] = _db_row["goods_name"];
                _dp_row["goods_number"] = _db_row["goods_number"];
                _dp_row["goods_price"] = _db_row["goods_price"];
                _dp_row["goods_description"] = _db_row["goods_description"];
                _dp_row["goods_regdate"] = _db_row["goods_regdate"];
                _dp_row["goods_moddate"] = _db_row["goods_moddate"];
                _dp_row["ctr_typenumber"] = _db_row["ctr_typenumber"];
                _dp_row["goods_picture"] = _db_row["goods_picture"];
                _dp_table.Rows.Add(_dp_row);
            }
        }

        private void btn_add_goods_Click(object sender, EventArgs e)
        {
            Counter_Product_Add _pop = new Counter_Product_Add();
            DialogResult _result = _pop.ShowDialog(ePopMode.add, null);
            if (_result == DialogResult.OK)
            {
                MessageBox.Show("저장성공");
            }
            else if (_result == DialogResult.Cancel)
            {
                MessageBox.Show("저장실패");

            }

        }

        private void btn_modify_goods_Click(object sender, EventArgs e)
        {

            if (grid_goods.SelectedRows.Count > 0)
            {
                DataRow _dp_row = GridManager.SelectedRow(grid_goods);
                //int _index = grid_goods.SelectedRows[0].Index;
                //DataRow _dp_row = DisplaySet.Tables["dp_goods"].Rows[_index];
                //string _msg = string.Format("{0},{1}", _dp_row["goods_number"], _dp_row["goods_name"]);
                //MessageBox.Show(_msg);

                Counter_Product_Add _pop = new Counter_Product_Add();
                _pop.ShowDialog(ePopMode.modify, _dp_row);
            }
            else
            {
                MessageBox.Show("선택된 행이 없습니다.");
            }
        }

        private void btn_delete_goods_Click(object sender, EventArgs e)
        {

            if (grid_goods.SelectedRows.Count > 0)
            {
                DataRow _dp_row = GridManager.SelectedRow(grid_goods);
                int goods_number = Convert.ToInt32(_dp_row["goods_number"]);
                string _goods_name = Convert.ToString(_dp_row["goods_name"]);
                if (MessageBox.Show(String.Format("상품({0})을 삭제하시겠습니까?", _goods_name), "확인", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int result = App.Instance().DBManager.DeleteProduct(goods_number);
                    if (result > 0)
                    {
                        MessageBox.Show("삭제성공");
                    }
                    else if (result == -999)
                    {
                        MessageBox.Show("접속실패");
                    }
                    else
                    {
                        MessageBox.Show("삭제실패");
                    }
                }
            }
            else
            {
                MessageBox.Show("선택된 행이 없습니다.");
            }

            /*
            if (grid_goods.SelectedRows.Count > 0)
            {
                int goods_number = Convert.ToInt32(grid_goods.SelectedRows[0].Cells["goods_number"].Value);
                int result = App.Instance().DBManager.DeleteProduct(goods_number);
                if (result == 0)
                {
                    MessageBox.Show("상품 삭제에 실패하였습니다.");
                }
                else
                {
                    MessageBox.Show("상품 삭제가 완료되었습니다.");
                    // 삭제된 상품 정보를 DataTable에서도 삭제
                    DataRow selectedRow = GridManager.SelectedRow(grid_goods);
                    DataTable dataTable = DisplaySet.Tables["dp_goods"];
                    dataTable.Rows.Remove(selectedRow);
                }
            }
            else
            {
                MessageBox.Show("선택된 행이 없습니다.");
            }*/
        }

        private void grid_goods_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbox_category_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
