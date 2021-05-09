using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testEmguCV
{
    public partial class Form2 : Form
    {
        Form1 form;
        public Form2()
        {
            InitializeComponent();
        }

        public Form2(Form1 fm)
        {
            InitializeComponent();
            form = fm; 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (form != null)
            {
                form.ApplyCanny((double)numericThreshold.Value, (double)numericThresholdLink.Value);
            }
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
