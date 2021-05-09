using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// 이걸 추가해주는구나.
using Emgu.CV;
using Emgu.CV.Structure;

namespace testEmguCV
{
    public partial class Form1 : Form
    {
        //Image 객체 선언
        Image<Bgr, byte> imgInput;

        public Form1()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //파일을 열면 Image객체를 초기화시키자
            OpenFileDialog ofd = new OpenFileDialog();
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                imgInput = new Image<Bgr, byte>(ofd.FileName);
                imageBox1.Image = imgInput;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //종료하면 끝이지
            if (MessageBox.Show("종료 하시겠습니까?", "System Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void cannyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ApplyCanny();
            return;
        }

        public void ApplyCanny(double thresh = 50.0, double threshLink = 20.0)
        {
            // 열기를 통해 이미지가 주어진 게 없으면 종료
            if (imgInput == null){
                return;
            }

            // 새로운 객체 imgCanny의 생성 및 초기화
            // Canny => Emgu에서 가져온 오픈소스
            Image<Gray, byte> imgCanny = new Image<Gray, byte>(imgInput.Width, imgInput.Height, new Gray(0));
            imgCanny = imgInput.Canny(thresh, threshLink);
            imageBox1.Image = imgCanny;
            return;
        }

        private void sobelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 열기를 통해 이미지가 주어진 게 없으면 종료
            if (imgInput == null)
            {
                return;
            }

            // 흑백화 시키기.
            // Sobel => Emgu에서 가져온 오픈소스
            Image<Gray, byte> imgGray = imgInput.Convert<Gray, byte>();
            Image<Gray, float> imgSobel = new Image<Gray, float>(imgInput.Width, imgInput.Height, new Gray(0));
            
            // Soble(x축), soble(y축)
            imgSobel = imgGray.Sobel(1, 0, 3).Add(imgGray.Sobel(0, 1, 3)).AbsDiff(new Gray(0.0));
            imageBox1.Image = imgSobel.Convert<Gray, byte>();
            return;
        }

        private void laplacianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 열기를 통해 이미지가 주어진 게 없으면 종료
            if (imgInput == null)
            {
                return;
            }

            // Laplacian => Emgu에서 가져온 오픈소스
            Image<Gray, byte> _imgGray = imgInput.Convert<Gray, byte>();
            Image<Gray, float> imgLaplacian = new Image<Gray, float>(imgInput.Width, imgInput.Height, new Gray(0));

            imgLaplacian = _imgGray.Laplace(7).AbsDiff(new Gray(0.0));
            imageBox1.Image = imgLaplacian.Convert<Gray, byte>();
            return;
        }


        //canny선택시 Form2 대화상자 이용
        private void cannyParametersToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form2 cp = new testEmguCV.Form2(this);
            cp.StartPosition = FormStartPosition.CenterParent;
            cp.Show();
        }
    }
}
