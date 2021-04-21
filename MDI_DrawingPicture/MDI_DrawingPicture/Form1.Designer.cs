
namespace MDI_DrawingPicture
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.파일ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.새파일ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.명암ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.밝게ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.어둡게ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.효과ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.흑백ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.이진화ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.닫기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일ToolStripMenuItem,
            this.명암ToolStripMenuItem,
            this.효과ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 파일ToolStripMenuItem
            // 
            this.파일ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.새파일ToolStripMenuItem,
            this.닫기ToolStripMenuItem});
            this.파일ToolStripMenuItem.Name = "파일ToolStripMenuItem";
            this.파일ToolStripMenuItem.Size = new System.Drawing.Size(64, 29);
            this.파일ToolStripMenuItem.Text = "파일";
            // 
            // 새파일ToolStripMenuItem
            // 
            this.새파일ToolStripMenuItem.Name = "새파일ToolStripMenuItem";
            this.새파일ToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.새파일ToolStripMenuItem.Text = "새파일";
            this.새파일ToolStripMenuItem.Click += new System.EventHandler(this.새파일ToolStripMenuItem_Click);
            // 
            // 명암ToolStripMenuItem
            // 
            this.명암ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.밝게ToolStripMenuItem,
            this.어둡게ToolStripMenuItem});
            this.명암ToolStripMenuItem.Name = "명암ToolStripMenuItem";
            this.명암ToolStripMenuItem.Size = new System.Drawing.Size(64, 29);
            this.명암ToolStripMenuItem.Text = "명암";
            // 
            // 밝게ToolStripMenuItem
            // 
            this.밝게ToolStripMenuItem.Name = "밝게ToolStripMenuItem";
            this.밝게ToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.밝게ToolStripMenuItem.Text = "밝게";
            this.밝게ToolStripMenuItem.Click += new System.EventHandler(this.밝게ToolStripMenuItem_Click);
            // 
            // 어둡게ToolStripMenuItem
            // 
            this.어둡게ToolStripMenuItem.Name = "어둡게ToolStripMenuItem";
            this.어둡게ToolStripMenuItem.Size = new System.Drawing.Size(168, 34);
            this.어둡게ToolStripMenuItem.Text = "어둡게";
            // 
            // 효과ToolStripMenuItem
            // 
            this.효과ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.흑백ToolStripMenuItem,
            this.이진화ToolStripMenuItem});
            this.효과ToolStripMenuItem.Name = "효과ToolStripMenuItem";
            this.효과ToolStripMenuItem.Size = new System.Drawing.Size(64, 29);
            this.효과ToolStripMenuItem.Text = "효과";
            // 
            // 흑백ToolStripMenuItem
            // 
            this.흑백ToolStripMenuItem.Name = "흑백ToolStripMenuItem";
            this.흑백ToolStripMenuItem.Size = new System.Drawing.Size(168, 34);
            this.흑백ToolStripMenuItem.Text = "흑백";
            // 
            // 이진화ToolStripMenuItem
            // 
            this.이진화ToolStripMenuItem.Name = "이진화ToolStripMenuItem";
            this.이진화ToolStripMenuItem.Size = new System.Drawing.Size(168, 34);
            this.이진화ToolStripMenuItem.Text = "이진화";
            // 
            // 닫기ToolStripMenuItem
            // 
            this.닫기ToolStripMenuItem.Name = "닫기ToolStripMenuItem";
            this.닫기ToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.닫기ToolStripMenuItem.Text = "닫기";
            this.닫기ToolStripMenuItem.Click += new System.EventHandler(this.닫기ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 파일ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 새파일ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 명암ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 밝게ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 어둡게ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 효과ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 흑백ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 이진화ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 닫기ToolStripMenuItem;
    }
}

