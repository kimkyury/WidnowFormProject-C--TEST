using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labelPos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 1. Press버튼을 누르면 Form2가 열리도록 작성하자
            Form2 dlg = new Form2();
            
            // 2. Form1이 가진 정보를 dlg(Form2)에게 전송해주자
            // 이러기 위해서 Form2의 코드에 함수 LabelX, LabelY, LabelText를 미리 작성했지.
            dlg.LabelX = label1.Left;
            dlg.LabelY = label1.Top;
            dlg.LabelText = label1.Text;

            // 3. dlg.showDialog()하면 대화상자가 열리며, 열린 창에서 DialogResult.OK가 들어오면 아래 정보가 넘어가도록 작성하자
            //      -Form2 디자이너에서, Button1의 [속성-DialogResult]값을 [OK] 라고 설정하였음을 전제로 한다
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                label1.Left = dlg.LabelX;
                label1.Top = dlg.LabelY;
                label1.Text = dlg.LabelText;
            }

            // 끝나면 dlg 닫기.
            dlg.Dispose();
        }
    }
}
