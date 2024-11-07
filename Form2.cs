using Kami.script;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kami
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        
        public int id, profile;
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.id = int.Parse(textBox1.Text);
                this.profile = int.Parse(idprofile.Text);
                if (this.id == null || this.profile == null)
                {
                    MessageBox.Show("Thiếu Dữ liệu Vui Lòng Kiểu Tra Lại ");
                    return;
                }
            }
            catch (Exception ex) {
                MessageBox.Show($"{textBox1.Text}   {idprofile.Text}");
            }

           Close();
        }
    }
}
