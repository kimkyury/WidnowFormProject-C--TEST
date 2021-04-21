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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public Image Image { get; set; }
        
        
        private void Form2_Load(object sender, EventArgs e)
        {
            this.ClientSize = new Size(Image.Width, Image.Height);
        }

        private void Form2_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(Image, 0, 0, Image.Width, Image.Height);
        }
    }
}
