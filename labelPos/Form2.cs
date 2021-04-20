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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        // X좌표 입출력
        public int LabelX{
           //여기에는 Lable X의 값을 Form1에서 받아오는 코드를 쓴다
            get{ return Convert.ToInt32(textBox1.Text);} // [전송] textBox1 값, Form에서는 위치를 숫자로 인식하니 Int로 변환
            set{ textBox1.Text = value.ToString();} // [저장] 입력 값, text니까 ToString으로 받아주자.
        }

        // Y좌표 입출력
        public int LabelY{
            //여기에는 Lable Y의 값을 Form2에서 받아오는 코드를 쓴다
            get{return Convert.ToInt32(textBox1.Text);} // [전송]
            set{textBox2.Text = value.ToString();} // [저장]
        }

        // 문자열 입출력
        public string LabelText
        {
            get { return textBox3.Text; } 
            set { textBox3.Text = value; } //어차피 문자열일테니까 형변환 안 시켜줘도 되는 거지.
        }
    }
}
