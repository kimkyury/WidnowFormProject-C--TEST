using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawLines_FileIO
{
    public partial class Form2 : Form
    {
        public int iDialogPenWidth { get; set; }
        public Color DialogPenColor { get; set; }

        public Form2()
        {
            InitializeComponent();
        }


        private void Form2_Load(object sender, EventArgs e)
        {
            for (int i = 2; i <= 10; i += 2)
            {
                comboBox1.Items.Add(i);
            }
            //comboBox1.SelectedIndex = iDialogPenWidth / 2 - 1;
            comboBox1.Text = iDialogPenWidth.ToString();
            hScrollBar1.Value = DialogPenColor.R;
            hScrollBar2.Value = DialogPenColor.G;
            hScrollBar3.Value = DialogPenColor.B;
            textBox1.Text = DialogPenColor.R.ToString();
            textBox2.Text = DialogPenColor.G.ToString();
            textBox3.Text = DialogPenColor.B.ToString();
        }

        private void label5_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawLine(new Pen(DialogPenColor, iDialogPenWidth), 0, label5.Height / 2, label5.Width, label5.Height / 2);
        }


        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            DialogPenColor = Color.FromArgb(hScrollBar1.Value, hScrollBar2.Value, hScrollBar3.Value);
            textBox1.Text = hScrollBar1.Value.ToString();
            textBox2.Text = hScrollBar2.Value.ToString();
            textBox3.Text = hScrollBar3.Value.ToString();
            label5.Invalidate();
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            iDialogPenWidth = int.Parse(comboBox1.Text);
            label5.Invalidate();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            iDialogPenWidth = (((ComboBox)sender).SelectedIndex + 1) * 2;
            label5.Invalidate();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
