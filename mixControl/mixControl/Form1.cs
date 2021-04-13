using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace mixControl   
{
    public partial class Form1 : Form
    {
        // 그림을 그릴 수 있는 그림판이고 이에 사용될 전역변수들을 선언해주자

        // 1. LinkedList를 이용한 선그리기 기능을 만들어주자
        //      - 그럴려면, CMyDATA (클래스)를 작성해야지 작성하러 가자 => 2
        //      - LinkedList에 넣을 수 있게 myData객체도 만들어준다
        private LinkedList<CMyData> total_lines;
        private CMyData myData;

        // 좌표 변수, 현재 모양/색상/크기 변수 적어주자
        private Point p;
        private int iCurrentShape;
        private Color iCurrentColor;
        private int iCurrentWidth = 1;

        public Form1()
        {
            // 3. Form1이 열렸을 때 기본적으로 갖고 있을 모양을 말해주자
            //  - 초기 색상을 말해주기
            //  - 선언했던 total_lines를 해당 형식의 LinkedList로 초기화해주기
            iCurrentColor = Color.FromArgb(255, 0, 0);
            total_lines = new LinkedList<CMyData>();
            InitializeComponent();
        }

        //그림판은 언제 동작하냐면, 내가 마우스로 그릴 때다. -> 마우스를 클릭할 때. 이벤트로 만들자
        // 4. 마우스다운 이벤트
        //  - 처음에는, 빨간/사각/1size의 점을 그리도록 한다
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            // 4-1. 마우스 [오른쪽/왼쪽]있으니, 왼쪽을 클릭할 때라고 조건문을 걸자
            if(e.Button == MouseButtons.Left)
            {
                //4-2. 전역에서 선언한 maDaya를 초기화시켜주자
                myData = new CMyData();
                myData.Shape = iCurrentShape;

                // 모양/넓이, 색상 를 정해주자
                // 4-3. iCurrentShape는 0(사각형)/1(원형)/2(자유곡선)이 있다
                //  -자유곡선의 크기는 현재 크기 그대로 유지하도록 한다
                //  -원형/사각형의 크기는 실선보다 굵기가 굵어야하니, 그 10배로 수정해준다
                if (iCurrentShape == 2)
                    myData.Width = iCurrentWidth;
                else
                    myData.Width = 10 * iCurrentWidth;

                // 4-4. 색상
                myData.Color = iCurrentColor;

                // 4-5. 위치 조정
                //  - 내 마우스의 좌표를 받아 LinkedList에 넣도록 할 것이다
                //  - myData의 함수를 호출하여 좌표값을 저장한다
                p = new Point(e.X, e.Y);
                myData.AR.Add(p);  //이게 이해가 직관적으로 안 되었는데, myData.AR로 배열을 리턴받아 그 배열, ar에 포인터p값을 저장하는 걸로 생각하면 되는 거였다

                // 4-6. 브러쉬 조정
                // - 브러쉬 객체를 만들자
                // - 그려낼 graphics 필드를 만들어주자
                SolidBrush b = new SolidBrush(iCurrentColor);
                Graphics g = this.CreateGraphics();

                // - 만약, 현재 모양이 0(사각형)/1(원향) 이라면 (브러쉬, x좌표, y좌표, 높이, 너비)를 설정해줘야한다
                // - 테두리가 있기때문에, 색상이 꽉찬 도형과 테투리만 가진 도형 두 개를 그려낸다.
                if(iCurrentShape == 0)
                {
                    g.FillRectangle(b, e.X, e.Y, 10 * iCurrentWidth, 10 * iCurrentWidth);
                    g.DrawRectangle(new Pen(Color.Black), e.X, e.Y, 10 * iCurrentWidth, 10*iCurrentWidth);
                }
                if (iCurrentShape == 1)
                {
                    g.FillEllipse(b, e.X, e.Y, 10 * iCurrentWidth, 10 * iCurrentWidth);
                    g.DrawEllipse(new Pen(Color.Black), e.X, e.Y, 10 * iCurrentWidth, 10*iCurrentWidth);
                }
            }
        }


        //5. 자유도형(선)을 그릴 때는 마우스를 누른채로 이동하다. mouseMove 이벤트 핸들러를 사용하자
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            // 조건이 세 개 필요하다. [(1)마우스 왼쪽을, (2)누른채로, (3)자유도형]일 때.
            if(e.Button == MouseButtons.Left && Capture && iCurrentShape ==2)
            {
                // 5-1. 눌렀을 때 뿐만아니라, 누르고 있는 도중에도 그릴 수 있는 판이 존재해야하니까. G를 또 만들어주자
                Graphics G = CreateGraphics();
                // 선그리기(사용할 펜, 위치X, 위치Y, 마우스X, 마우스Y)
                G.DrawLine(new Pen(myData.Color, myData.Width), p.X, p.Y, e.X, e.Y);  // g 클래스가 가지고 있는 DrawLine함수를 통해 그려주자.
                p = new Point(e.X, e.Y);
                myData.AR.Add(p);

                // 어 근데 왜 얘 왜 Dispose 해주는 거야
                G.Dispose();
            }
        }



        //6. 하나의 도형을 마치는 기준은 마우스를 뗄 때다. mouseUp 이벤트 핸들러를 이용하자
        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            //링크드리스트의 마지막에 나의 myData를 집어놓고, 다음 나의 myData를 위해 초기화(new)를 새로 해준다
            //  -myData를 집어넣었다는 건, 내가 지금 그리는 도형의 (색상/위치/크기/배열)정보를 넘겼다는 거다
            total_lines.AddLast(myData);
            myData = new CMyData();
        }



        // 7. 이제 이렇게 포인터를 담은 ar를 이용한 paint, 즉 칠하기를 해보자
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            // 브러쉬 만들고, total_lines에 저장된 내 그림들을 다 그려주도록 하자
            SolidBrush b = new SolidBrush(iCurrentColor);
            foreach (CMyData line in total_lines)
            {
                // 그릴 경우의 수는 3가지, 사각/원/자유
                b = new SolidBrush(line.Color);
                if(line.Shape == 0)
                {
                    e.Graphics.FillRectangle(b, ((Point)line.AR[0]).X, ((Point)line.AR[0]).Y, line.Width, line.Width);
                    e.Graphics.DrawRectangle(new Pen(Color.Black), ((Point)line.AR[0]).X, ((Point)line.AR[0]).Y, line.Width, line.Width);

                }
                else if(line.Shape == 1)
                {
                    e.Graphics.FillEllipse(b, ((Point)line.AR[0]).X, ((Point)line.AR[0]).Y, line.Width, line.Width);
                    e.Graphics.DrawEllipse(new Pen(Color.Black), ((Point)line.AR[0]).X, ((Point)line.AR[0]).Y, line.Width, line.Width);

                }
                else //선 그릴 때!
                {
                    for(int i=1; i<line.AR.Count; i++)
                    {
                        // i를 일부러 1부터 시작해서 시작점과 끝이 제대로 나올 수 있게끔 for문을 작성하였다
                        e.Graphics.DrawLine(new Pen(line.Color, line.Width), (Point)line.AR[i - 1], (Point)line.AR[i]);
                    }
                }

            }
        }
    }


    // 2. CMydata 클래스를 작성하자 (색상, 크기, 모양, 배열을 갖고 있다)
    public class CMyData
    {
        private Color color;
        private int width;
        private int shape;

        // arr는 내가 그린 자료들을 저장하고 있어야한다
        private ArrayList ar;

        // 2-1. 생성자 함수를 작성하자. CMyData가 생성되면 기본적으로 갖고 있어야할 것?
        // 계속해서 그릴 수 있도록 ArrayList를 초기화 해줘야한다
        public CMyData()
        {
            ar = new ArrayList();
        }

        // 2-2. Color를 [리턴, 저장]할 수 있는 color 함수를 작성하자
        public Color Color
        {
            get { return color; }
            set { color = value; }
        }

        // 2-3. Width를 [리턴, 저장]할 수 있는 함수 작성
        public int Width
        {
            get { return width; }
            set { width = value; }
        }

        //2-4. shape를 [리턴, 저장]할 수 있는 함수 작성
        public int Shape
        {
            get { return shape; }
            set { shape = value; }

        }

        //2-5. array를 [리턴]할 수 있는 함수 작성
        public ArrayList AR
        {
            get { return ar; }
        }
    }
}
