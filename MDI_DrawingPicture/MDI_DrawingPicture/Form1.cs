using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDI_DrawingPicture
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void 새파일ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            if(op.ShowDialog() == DialogResult.OK)
            {
                //Form2 객체를 만들고, 그 객체의 부모가 Form1이라는 것을 알리자. 그리고 Child를 연다
                Image I = Image.FromFile(op.FileName);

                Form2 Child = new Form2();
                Child.BackgroundImage = I;
                Child.MdiParent = this;
                Child.Show();

            }


        }

        private void 닫기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //현재 활성화된 Form2 객체에 대해 작동하도록 한다
            Form Child = this.ActiveMdiChild;
            if (Child != null)
            {
                Child.Close();
            }
        }

        private void 밝게ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 Child = (Form2)this.ActiveMdiChild;
            if(Child != null)
            {
                Image I = Child.Image;

                Bitmap B = new Bitmap(I);
                for ( int y =0; y<B.Height; y++)
                {
                    for (int x = 0; x < B.Width; x++)
                    {
                        Color color = B.GetPixel(x, y);
                        int r = color.R;
                        int g = color.G;
                        int b = color.B;

                        //Saturation
                        if(((ToolStripMenuItem)sender).Text.Equals("밝게")){
                            r = r + 50 > 255 ? 255 : r + 50;
                            g = g + 50 > 255 ? 255 : g + 50;
                            b = b + 50 > 255 ? 255 : b + 50;


                        }
                        else {
                            r = r - 50 < 0 ? 0 : r - 50;
                            g = g - 50 < 0 ? 0 : g - 50;
                            b = b - 50 < 0 ? 0 : b - 50;
                        }
                        B.SetPixel(x, y, Color.FromArgb(r, g, b));


                    }
                    Child = new Form2();
                    Child.Image = B;
                    Child.MdiParent = this;
                    Child.Show();

                }
            }
        }
    }
}
