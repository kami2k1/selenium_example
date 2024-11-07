using Kami.app;
using Kami.script;
using static System.Net.Mime.MediaTypeNames;
using System.Threading.Tasks;

namespace Kami
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            //string textInput = toolStripTextBox1.Text;


            //MessageBox.Show("Bạn đã nhập: " + textInput);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    // Code cho xử lý sự kiện ở đây
        //}
        public int dilayfb, profilefb;
        public Form2 f;
        public Fb fb;

        private void button2_Click(object sender, EventArgs e)
        {
            if (f == null)
            {
                this.f = new Form2();

            }

            f.ShowDialog();
            dilayfb = f.id;
            profilefb = f.profile;
            log($" {this.dilayfb} P , {profilefb}");

        }
        public async void FBNVrung(int id, int dilay, int cout = 0, string tukhoa = null)
        {
            await Task.Run(async () => await fb.Nv(id, this.dilayfb, cout, tukhoa));

        }
        private async void button3_Click(object sender, EventArgs e)
        {
            if (this.dilayfb == 0 && this.profilefb == 0)
            {
                button2_Click(sender, e);
            }

            if (fb == null)
            {
                Chrome C = new Chrome(this, this.profilefb);
                fb = new Fb(C);
                fb.ch.print("Chữa ");
            }
            fb.ch.print("rồi ");
            FBNVrung(0, this.dilayfb);


        }
        private async void button1_Click(object sender, EventArgs e)
        {
            int sartfile = int.Parse(textBox4.Text);
            int endfile = int.Parse(textBox3.Text);

            int profile = int.Parse(textBox1.Text);
            if (profile == null || sartfile == null || endfile == null)
            {
                MessageBox.Show("Thiếu Dữ liệu Vui Lòng Kiểu Tra Lại ");
                return;
            }
            else
            {

                Chrome chrome = new Chrome(this, profile);


                yt Y = new yt(chrome, sartfile, endfile);
                await Task.Run(async () => await Y.Runing());


            }
        }


        private void NewButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nút mới đã được nhấn!");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }
        public void log(string msg)
        {
            textBox2.Text += "\r\nSV log : -> " + msg + "\r\n";

        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show(); // Hiển thị lại form
            this.WindowState = FormWindowState.Normal; // Trở về trạng thái bình thường
            this.BringToFront(); // Đưa form lên phía trước
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        public Form3 FM;

        private void button4_Click(object sender, EventArgs e)
        {
            if (fb == null)
            {
                button3_Click(sender, e);

            }
            if (FM == null)
            {
                FM = new Form3();
            }
            FM.ShowDialog();
            FBNVrung(FM.fidnv, FM.fdilay, FM.fsl,FM.TUkhoaz);



        }
    }
}
