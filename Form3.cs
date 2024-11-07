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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
        public int fdilay, fidnv, fsl;
        public string TUkhoaz;
        private void oke_Click(object sender, EventArgs e)
        {
            try
            {
                fidnv = int.Parse(idnv.Text);
                fsl = int.Parse(sl.Text);
                fdilay =  int.Parse(dilay.Text);
                TUkhoaz = Tukhoa.Text;






            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi T {ex}");
                return;
            }
            Close();
        }
    }
}
