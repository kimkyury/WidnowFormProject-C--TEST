using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// using 명령어 추가
using System.IO;

namespace BinaryStreamTest
{
    public partial class Form1 : Form
    {
        //전역으로 Human 객체를 생성해놓자.  이름과 나이 정보를 가진다
        public Human Kim = new Human("김규리", 20);

        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //전역에서 생성한 Human객체에 대한 정보를 출력시키도록 하자
            FileStream fs = new FileStream(@"c:\temp\Kim.bin", FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            bw.Write(Kim.Name);
            bw.Write(Kim.Age);
            //kim.Wite(bw);

            fs.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "파일을 읽는 중";
            label1.Refresh();

            //사실 컴퓨터는 댑따 빠르지만 대기시간이 있는 척 Sleep걸어주자
            System.Threading.Thread.Sleep(1000);
            FileStream fs = new FileStream(@"c:\temp\Kim.bin", FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);

            // 불러온 정보를 Kim객체의 이름(String으로 변환), 나이(32비트로 변환)를 저장시키자.
            Kim = new Human(br.ReadString(), br.ReadInt32());
            fs.Close();
            label1.Text = Kim.ToString();
        }
    }

    public class Human
    {
        // public으로 하여 바로 뭐.. 출력시키도록 바꿔놓자. (원래는 private였지)
        public string Name;
        public int Age;
        private float Temp;

        public Human(string aName, int aAge)
        {
            Name = aName;
            Age = aAge;
            Temp = 1.23f;
        }

        public override string ToString()
        {
            Temp += 1;
            return "이름 : " + Name + ", 나이 : " + Age;
        }
    }
}
