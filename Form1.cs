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
        private async void button1_Click(object sender, EventArgs e)
        {
            string txt = textBox1.Text;
            if (string.IsNullOrWhiteSpace(txt))
            {
                MessageBox.Show("Bạn chưa nhập gì cả");
                return;
            }
            else
            {
                Chrome chrome = new Chrome(1,this, 3);
                yt y = new yt(chrome);

                try
                {
                    await Task.Run(async () => await y.upshort());
                }
                catch (Exception ex)
                {
                    log($"Đã xảy ra lỗi: {ex.Message}");
                }
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
        public  void log(string msg)
        {
            textBox2.Text += "\r\nSV log : -> " + msg + "\r\n";

        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show(); // Hiển thị lại form
            this.WindowState = FormWindowState.Normal; // Trở về trạng thái bình thường
            this.BringToFront(); // Đưa form lên phía trước
        }
    }
}
