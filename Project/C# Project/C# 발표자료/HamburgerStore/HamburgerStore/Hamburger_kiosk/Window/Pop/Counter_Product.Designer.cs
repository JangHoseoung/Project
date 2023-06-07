namespace Counter.Window.View
{
    partial class Counter_Product
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.grid_goods = new System.Windows.Forms.DataGridView();
            this.goodsnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodsnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodspriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodsdescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodsregdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodsmoddateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodspictureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ctr_typenumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DisplaySet = new System.Data.DataSet();
            this.dataTable1 = new System.Data.DataTable();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataColumn2 = new System.Data.DataColumn();
            this.dataColumn3 = new System.Data.DataColumn();
            this.dataColumn4 = new System.Data.DataColumn();
            this.dataColumn5 = new System.Data.DataColumn();
            this.dataColumn6 = new System.Data.DataColumn();
            this.dataColumn7 = new System.Data.DataColumn();
            this.dataColumn8 = new System.Data.DataColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btn_search = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.tbox_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.cbox_category = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_delete_goods = new System.Windows.Forms.Button();
            this.btn_modify_goods = new System.Windows.Forms.Button();
            this.btn_add_goods = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_goods)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DisplaySet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.grid_goods);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(981, 707);
            this.panel1.TabIndex = 0;
            // 
            // grid_goods
            // 
            this.grid_goods.AllowUserToAddRows = false;
            this.grid_goods.AllowUserToDeleteRows = false;
            this.grid_goods.AutoGenerateColumns = false;
            this.grid_goods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_goods.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.goodsnumberDataGridViewTextBoxColumn,
            this.goodsnameDataGridViewTextBoxColumn,
            this.goodspriceDataGridViewTextBoxColumn,
            this.goodsdescriptionDataGridViewTextBoxColumn,
            this.goodsregdateDataGridViewTextBoxColumn,
            this.goodsmoddateDataGridViewTextBoxColumn,
            this.goodspictureDataGridViewTextBoxColumn,
            this.ctr_typenumber});
            this.grid_goods.DataMember = "dp_goods";
            this.grid_goods.DataSource = this.DisplaySet;
            this.grid_goods.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_goods.Location = new System.Drawing.Point(0, 65);
            this.grid_goods.Name = "grid_goods";
            this.grid_goods.ReadOnly = true;
            this.grid_goods.RowHeadersWidth = 21;
            this.grid_goods.RowTemplate.Height = 23;
            this.grid_goods.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_goods.Size = new System.Drawing.Size(981, 576);
            this.grid_goods.TabIndex = 3;
            this.grid_goods.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_goods_CellContentClick);
            // 
            // goodsnumberDataGridViewTextBoxColumn
            // 
            this.goodsnumberDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.goodsnumberDataGridViewTextBoxColumn.DataPropertyName = "goods_number";
            this.goodsnumberDataGridViewTextBoxColumn.HeaderText = "상품항목";
            this.goodsnumberDataGridViewTextBoxColumn.Name = "goodsnumberDataGridViewTextBoxColumn";
            this.goodsnumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.goodsnumberDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // goodsnameDataGridViewTextBoxColumn
            // 
            this.goodsnameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.goodsnameDataGridViewTextBoxColumn.DataPropertyName = "goods_name";
            this.goodsnameDataGridViewTextBoxColumn.HeaderText = "상품이름";
            this.goodsnameDataGridViewTextBoxColumn.Name = "goodsnameDataGridViewTextBoxColumn";
            this.goodsnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // goodspriceDataGridViewTextBoxColumn
            // 
            this.goodspriceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.goodspriceDataGridViewTextBoxColumn.DataPropertyName = "goods_price";
            this.goodspriceDataGridViewTextBoxColumn.HeaderText = "상품가격";
            this.goodspriceDataGridViewTextBoxColumn.Name = "goodspriceDataGridViewTextBoxColumn";
            this.goodspriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // goodsdescriptionDataGridViewTextBoxColumn
            // 
            this.goodsdescriptionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.goodsdescriptionDataGridViewTextBoxColumn.DataPropertyName = "goods_description";
            this.goodsdescriptionDataGridViewTextBoxColumn.HeaderText = "상품설명";
            this.goodsdescriptionDataGridViewTextBoxColumn.Name = "goodsdescriptionDataGridViewTextBoxColumn";
            this.goodsdescriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // goodsregdateDataGridViewTextBoxColumn
            // 
            this.goodsregdateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.goodsregdateDataGridViewTextBoxColumn.DataPropertyName = "goods_regdate";
            this.goodsregdateDataGridViewTextBoxColumn.HeaderText = "상품등록일";
            this.goodsregdateDataGridViewTextBoxColumn.Name = "goodsregdateDataGridViewTextBoxColumn";
            this.goodsregdateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // goodsmoddateDataGridViewTextBoxColumn
            // 
            this.goodsmoddateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.goodsmoddateDataGridViewTextBoxColumn.DataPropertyName = "goods_moddate";
            this.goodsmoddateDataGridViewTextBoxColumn.HeaderText = "상품수정일";
            this.goodsmoddateDataGridViewTextBoxColumn.Name = "goodsmoddateDataGridViewTextBoxColumn";
            this.goodsmoddateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // goodspictureDataGridViewTextBoxColumn
            // 
            this.goodspictureDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.goodspictureDataGridViewTextBoxColumn.DataPropertyName = "goods_picture";
            this.goodspictureDataGridViewTextBoxColumn.HeaderText = "goods_picture";
            this.goodspictureDataGridViewTextBoxColumn.Name = "goodspictureDataGridViewTextBoxColumn";
            this.goodspictureDataGridViewTextBoxColumn.ReadOnly = true;
            this.goodspictureDataGridViewTextBoxColumn.Visible = false;
            // 
            // ctr_typenumber
            // 
            this.ctr_typenumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ctr_typenumber.DataPropertyName = "ctr_typenumber";
            this.ctr_typenumber.HeaderText = "상품목록번호";
            this.ctr_typenumber.Name = "ctr_typenumber";
            this.ctr_typenumber.ReadOnly = true;
            // 
            // DisplaySet
            // 
            this.DisplaySet.DataSetName = "NewDataSet";
            this.DisplaySet.Tables.AddRange(new System.Data.DataTable[] {
            this.dataTable1});
            // 
            // dataTable1
            // 
            this.dataTable1.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn1,
            this.dataColumn2,
            this.dataColumn3,
            this.dataColumn4,
            this.dataColumn5,
            this.dataColumn6,
            this.dataColumn7,
            this.dataColumn8});
            this.dataTable1.TableName = "dp_goods";
            // 
            // dataColumn1
            // 
            this.dataColumn1.ColumnName = "goods_number";
            this.dataColumn1.DataType = typeof(int);
            // 
            // dataColumn2
            // 
            this.dataColumn2.ColumnName = "goods_name";
            // 
            // dataColumn3
            // 
            this.dataColumn3.ColumnName = "goods_price";
            this.dataColumn3.DataType = typeof(int);
            // 
            // dataColumn4
            // 
            this.dataColumn4.ColumnName = "goods_description";
            // 
            // dataColumn5
            // 
            this.dataColumn5.ColumnName = "goods_regdate";
            this.dataColumn5.DataType = typeof(System.DateTime);
            // 
            // dataColumn6
            // 
            this.dataColumn6.ColumnName = "goods_moddate";
            this.dataColumn6.DataType = typeof(System.DateTime);
            // 
            // dataColumn7
            // 
            this.dataColumn7.ColumnName = "goods_picture";
            // 
            // dataColumn8
            // 
            this.dataColumn8.ColumnName = "ctr_typenumber";
            this.dataColumn8.DataType = typeof(int);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.panel8);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(981, 65);
            this.panel3.TabIndex = 2;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.btn_search);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel8.Location = new System.Drawing.Point(314, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(122, 63);
            this.panel8.TabIndex = 4;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(10, 18);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(104, 32);
            this.btn_search.TabIndex = 0;
            this.btn_search.Text = "조회";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.tbox_name);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(160, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(154, 63);
            this.panel6.TabIndex = 2;
            // 
            // tbox_name
            // 
            this.tbox_name.Location = new System.Drawing.Point(4, 29);
            this.tbox_name.Name = "tbox_name";
            this.tbox_name.Size = new System.Drawing.Size(134, 21);
            this.tbox_name.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(10);
            this.label2.Size = new System.Drawing.Size(154, 63);
            this.label2.TabIndex = 2;
            this.label2.Text = "이름";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.cbox_category);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(10);
            this.panel5.Size = new System.Drawing.Size(160, 63);
            this.panel5.TabIndex = 1;
            // 
            // cbox_category
            // 
            this.cbox_category.Cursor = System.Windows.Forms.Cursors.No;
            this.cbox_category.FormattingEnabled = true;
            this.cbox_category.Items.AddRange(new object[] {
            "전체",
            "세트",
            "햄버거",
            "음료",
            "사이드",
            "베스트"});
            this.cbox_category.Location = new System.Drawing.Point(9, 30);
            this.cbox_category.Name = "cbox_category";
            this.cbox_category.Size = new System.Drawing.Size(135, 20);
            this.cbox_category.TabIndex = 0;
            this.cbox_category.SelectedIndexChanged += new System.EventHandler(this.cbox_category_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 43);
            this.label1.TabIndex = 1;
            this.label1.Text = "카테고리";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.btn_delete_goods);
            this.panel4.Controls.Add(this.btn_modify_goods);
            this.panel4.Controls.Add(this.btn_add_goods);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(634, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(345, 63);
            this.panel4.TabIndex = 0;
            // 
            // btn_delete_goods
            // 
            this.btn_delete_goods.Location = new System.Drawing.Point(226, 17);
            this.btn_delete_goods.Name = "btn_delete_goods";
            this.btn_delete_goods.Size = new System.Drawing.Size(104, 32);
            this.btn_delete_goods.TabIndex = 3;
            this.btn_delete_goods.Text = "삭제";
            this.btn_delete_goods.UseVisualStyleBackColor = true;
            this.btn_delete_goods.Click += new System.EventHandler(this.btn_delete_goods_Click);
            // 
            // btn_modify_goods
            // 
            this.btn_modify_goods.Location = new System.Drawing.Point(116, 17);
            this.btn_modify_goods.Name = "btn_modify_goods";
            this.btn_modify_goods.Size = new System.Drawing.Size(104, 32);
            this.btn_modify_goods.TabIndex = 2;
            this.btn_modify_goods.Text = "수정";
            this.btn_modify_goods.UseVisualStyleBackColor = true;
            this.btn_modify_goods.Click += new System.EventHandler(this.btn_modify_goods_Click);
            // 
            // btn_add_goods
            // 
            this.btn_add_goods.Location = new System.Drawing.Point(3, 17);
            this.btn_add_goods.Name = "btn_add_goods";
            this.btn_add_goods.Size = new System.Drawing.Size(104, 32);
            this.btn_add_goods.TabIndex = 1;
            this.btn_add_goods.Text = "등록";
            this.btn_add_goods.UseVisualStyleBackColor = true;
            this.btn_add_goods.Click += new System.EventHandler(this.btn_add_goods_Click);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 641);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(981, 66);
            this.panel2.TabIndex = 1;
            // 
            // Counter_Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 707);
            this.Controls.Add(this.panel1);
            this.Name = "Counter_Product";
            this.Text = "상품관리";
            this.Load += new System.EventHandler(this.Counter_Product_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_goods)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DisplaySet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox tbox_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ComboBox cbox_category;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btn_search;
        private System.Data.DataSet DisplaySet;
        private System.Data.DataTable dataTable1;
        private System.Data.DataColumn dataColumn1;
        private System.Data.DataColumn dataColumn2;
        private System.Data.DataColumn dataColumn3;
        private System.Data.DataColumn dataColumn4;
        private System.Data.DataColumn dataColumn5;
        private System.Data.DataColumn dataColumn6;
        private System.Data.DataColumn dataColumn7;
        private System.Windows.Forms.DataGridView grid_goods;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button btn_delete_goods;
        private System.Windows.Forms.Button btn_modify_goods;
        private System.Windows.Forms.Button btn_add_goods;
        private System.Data.DataColumn dataColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodsnumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodsnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodspriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodsdescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodsregdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodsmoddateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodspictureDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ctr_typenumber;
    }
}