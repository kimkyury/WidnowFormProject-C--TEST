using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using 명령어 추가
using System.IO;

namespace FileStreamTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //내용 입력을 위해, 해당 값을 초기화한 byte배열을(byte인 이유: Stream이 byte만 받아들임) 만든다
            byte[] data = { 010, 012, 011, 018, 019 };
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //파일스트림 fs 을 만들자. 이름과, 모드와, 쓰기허용을 보낸다
                FileStream fs = new FileStream(saveFileDialog1.FileName, FileMode.Create, FileAccess.Write);
                // 바이트배열인 data의 내용을 인덱스 0부터 끝까지 기록하도록 한다
                fs.Write(data, 0, data.Length);
                fs.Close();
                MessageBox.Show(saveFileDialog1.FileName + "내용을 기록하였습니다. ");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //내용 출력을 위해, 해당 값을 저장시킬 공간을 만든다
            byte[] data = new byte[8];
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    FileStream fs = new FileStream(openFileDialog1.FileName, FileMode.OpenOrCreate, FileAccess.Read);
                    fs.Read(data, 0, data.Length);
                    fs.Close();

                    string result = "";
                    for (int i = 0; i <data.Length; i++)
                    {
                        result += data[i].ToString() + ".";
                    }
                    MessageBox.Show(result, "파일 내용");
                }

            }
            catch(FileNotFoundException)
            {
                MessageBox.Show("지정한 파일이 없습니다.");
            }


        }
    }
}
