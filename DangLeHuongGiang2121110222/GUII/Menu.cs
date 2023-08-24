using GUII;
using GUII.Login;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUII
{
    public partial class Menu : Form
    {

        public Menu()
        {
            InitializeComponent();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.ShowDialog();
        }


        private void button4_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn có đồng ý thoát?", "Thông báo", MessageBoxButtons.OK);
            Application.Exit();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Form20 frm20 = new Form20();
            frm20.ShowDialog();
        }

        private void button29_Click(object sender, EventArgs e)
        {
            ADO dtb = new ADO();
            dtb.ShowDialog();
        }

        private void button30_Click(object sender, EventArgs e)
        {
            ThongTinCSDL ttCSDL = new ThongTinCSDL();
            ttCSDL.ShowDialog();
        }

        private void button31_Click(object sender, EventArgs e)
        {
            DangNhap dn = new DangNhap();
            dn.ShowDialog();
        }
    }
}
