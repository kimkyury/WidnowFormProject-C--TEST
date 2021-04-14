using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mixControl
{
    public partial class Form2 : Form
    {
        //리턴할 때만 필요한 private속성의 int자료형 하나를 선언해두자
        private int iDialogShape;
        public Form2()
        {
            InitializeComponent();
        }

        public int Shape
        {
            //현재 지정값에 대한 정보를 보내줄 수 있도록 하자
            get
            {
                if (radioButton1.Checked) iDialogShape = 0;
                if (radioButton2.Checked) iDialogShape = 1;
                if (radioButton3.Checked) iDialogShape = 2;
                return iDialogShape;
            }

            set
            {
                iDialogShape = value;
                if (iDialogShape == 0) radioButton1.Checked = true;
                if (iDialogShape == 1) radioButton2.Checked = true;
                if (iDialogShape == 2) radioButton3.Checked = true;
            }
        }




        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
