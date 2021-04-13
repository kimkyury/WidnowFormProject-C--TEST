
namespace mixControl
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.메뉴MToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.사각형ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.원형ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.자유곡선ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.대화상자ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.메뉴MToolStripMenuItem,
            this.대화상자ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 메뉴MToolStripMenuItem
            // 
            this.메뉴MToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.사각형ToolStripMenuItem,
            this.원형ToolStripMenuItem,
            this.자유곡선ToolStripMenuItem});
            this.메뉴MToolStripMenuItem.Name = "메뉴MToolStripMenuItem";
            this.메뉴MToolStripMenuItem.Size = new System.Drawing.Size(91, 29);
            this.메뉴MToolStripMenuItem.Text = "메뉴(M)";
            // 
            // 사각형ToolStripMenuItem
            // 
            this.사각형ToolStripMenuItem.Name = "사각형ToolStripMenuItem";
            this.사각형ToolStripMenuItem.Size = new System.Drawing.Size(186, 34);
            this.사각형ToolStripMenuItem.Text = "사각형";
            // 
            // 원형ToolStripMenuItem
            // 
            this.원형ToolStripMenuItem.Name = "원형ToolStripMenuItem";
            this.원형ToolStripMenuItem.Size = new System.Drawing.Size(186, 34);
            this.원형ToolStripMenuItem.Text = "원형";
            // 
            // 자유곡선ToolStripMenuItem
            // 
            this.자유곡선ToolStripMenuItem.Name = "자유곡선ToolStripMenuItem";
            this.자유곡선ToolStripMenuItem.Size = new System.Drawing.Size(186, 34);
            this.자유곡선ToolStripMenuItem.Text = "자유곡선";
            // 
            // 대화상자ToolStripMenuItem
            // 
            this.대화상자ToolStripMenuItem.Name = "대화상자ToolStripMenuItem";
            this.대화상자ToolStripMenuItem.Size = new System.Drawing.Size(100, 29);
            this.대화상자ToolStripMenuItem.Text = "대화상자";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 메뉴MToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 사각형ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 원형ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 자유곡선ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 대화상자ToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

