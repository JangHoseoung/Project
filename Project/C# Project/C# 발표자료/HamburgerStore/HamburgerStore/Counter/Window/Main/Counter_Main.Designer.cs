namespace Counter
{
    partial class Counter_Main
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Counter_Main));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.상품관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.사원관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.주문확인ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.통계조회ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.로그인ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dB환경설정ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.WorkZonePanel = new System.Windows.Forms.Panel();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripDropDownButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1142, 39);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.상품관리ToolStripMenuItem,
            this.사원관리ToolStripMenuItem,
            this.주문확인ToolStripMenuItem,
            this.통계조회ToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Margin = new System.Windows.Forms.Padding(10, 10, 20, 10);
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(44, 19);
            this.toolStripDropDownButton1.Text = "메뉴";
            this.toolStripDropDownButton1.Click += new System.EventHandler(this.toolStripDropDownButton1_Click);
            // 
            // 상품관리ToolStripMenuItem
            // 
            this.상품관리ToolStripMenuItem.Name = "상품관리ToolStripMenuItem";
            this.상품관리ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.상품관리ToolStripMenuItem.Text = "상품관리";
            this.상품관리ToolStripMenuItem.Click += new System.EventHandler(this.상품관리ToolStripMenuItem_Click);
            // 
            // 사원관리ToolStripMenuItem
            // 
            this.사원관리ToolStripMenuItem.Name = "사원관리ToolStripMenuItem";
            this.사원관리ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.사원관리ToolStripMenuItem.Text = "사원관리";
            this.사원관리ToolStripMenuItem.Click += new System.EventHandler(this.사원관리ToolStripMenuItem_Click);
            // 
            // 주문확인ToolStripMenuItem
            // 
            this.주문확인ToolStripMenuItem.Name = "주문확인ToolStripMenuItem";
            this.주문확인ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.주문확인ToolStripMenuItem.Text = "주문확인";
            this.주문확인ToolStripMenuItem.Click += new System.EventHandler(this.주문확인ToolStripMenuItem_Click);
            // 
            // 통계조회ToolStripMenuItem
            // 
            this.통계조회ToolStripMenuItem.Name = "통계조회ToolStripMenuItem";
            this.통계조회ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.통계조회ToolStripMenuItem.Text = "통계조회";
            this.통계조회ToolStripMenuItem.Click += new System.EventHandler(this.통계조회ToolStripMenuItem_Click);
            // 
            // toolStripDropDownButton2
            // 
            this.toolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.로그인ToolStripMenuItem,
            this.dB환경설정ToolStripMenuItem});
            this.toolStripDropDownButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton2.Image")));
            this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton2.Margin = new System.Windows.Forms.Padding(10, 10, 20, 10);
            this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            this.toolStripDropDownButton2.Size = new System.Drawing.Size(44, 19);
            this.toolStripDropDownButton2.Text = "설정";
            this.toolStripDropDownButton2.Click += new System.EventHandler(this.toolStripDropDownButton2_Click);
            // 
            // 로그인ToolStripMenuItem
            // 
            this.로그인ToolStripMenuItem.Name = "로그인ToolStripMenuItem";
            this.로그인ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.로그인ToolStripMenuItem.Text = "로그인";
            this.로그인ToolStripMenuItem.Click += new System.EventHandler(this.로그인ToolStripMenuItem_Click);
            // 
            // dB환경설정ToolStripMenuItem
            // 
            this.dB환경설정ToolStripMenuItem.Name = "dB환경설정ToolStripMenuItem";
            this.dB환경설정ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dB환경설정ToolStripMenuItem.Text = "DB환경설정";
            this.dB환경설정ToolStripMenuItem.Click += new System.EventHandler(this.dB환경설정ToolStripMenuItem_Click_1);
            // 
            // WorkZonePanel
            // 
            this.WorkZonePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WorkZonePanel.Location = new System.Drawing.Point(0, 39);
            this.WorkZonePanel.Name = "WorkZonePanel";
            this.WorkZonePanel.Size = new System.Drawing.Size(1142, 710);
            this.WorkZonePanel.TabIndex = 1;
            // 
            // Counter_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 749);
            this.Controls.Add(this.WorkZonePanel);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Counter_Main";
            this.Text = "Form1";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem 상품관리ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 사원관리ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 통계조회ToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
        private System.Windows.Forms.ToolStripMenuItem 로그인ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dB환경설정ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 주문확인ToolStripMenuItem;
        private System.Windows.Forms.Panel WorkZonePanel;
    }
}

