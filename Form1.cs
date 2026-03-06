namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // 사진에 마우스가 올라가면 테두리 스타일을 변경하도록 이벤트 연결
            this.pictureBox1.MouseEnter += pictureBox1_MouseEnter;
            this.pictureBox1.MouseLeave += pictureBox1_MouseLeave;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        // 마우스가 PictureBox 위로 들어올 때 테두리 표시
        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
        }

        // 마우스가 PictureBox에서 떠날 때 테두리 제거
        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.BorderStyle = BorderStyle.None;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            this.BackColor = Color.FromArgb(rand.Next(200), rand.Next(200), rand.Next(256));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // System.Diagnostics.Process.Start("URL주소");를 사용해서 해보려 했으나, 오류발생.

            var psi = new System.Diagnostics.ProcessStartInfo // 프로세스 시작 정보 객체 생성
            {
                FileName = "https://github.com/d10F-xy", // 열고자 하는 URL 주소
                UseShellExecute = true // 브라우저에서 실행하기 위해서는 이 문장이 필요함.(사용하지 않을 시에는 문자열로 인식하여 오류가 발생함.)
            };
            System.Diagnostics.Process.Start(psi); // 프로세스 시작하는 명령어
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.thepoles; //리소스 파일에 내가 원하는 이미지를 추가한 후, pictureBox1의 이미지로 설정하는 코드.
        }
    }
}
