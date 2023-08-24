using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUII._3Class
{
    public partial class HeThong : Form
    {
        public HeThong()
        {
            InitializeComponent();
        }

        private void liênHệToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LienHe lh = new LienHe();
            this.Hide();
            lh.ShowDialog();
            this.Show();
        }

        private void thôngTinSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerGUI cGUI = new CustomerGUI();
            this.Hide();
            cGUI.ShowDialog();
            this.Show();
        }

        private void thôngTinGiảngViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TeacherGUI tGUI = new TeacherGUI();
            this.Hide();
            tGUI.ShowDialog();
            this.Show();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn có đồng ý thoát?", "Thông báo", MessageBoxButtons.OK);
            Application.Exit();
        }

        private void lacustomer_Click(object sender, EventArgs e)
        {
            CustomerGUI cGUI = new CustomerGUI();
            this.Hide();
            cGUI.ShowDialog();
            this.Show();
        }

        private void lateacher_Click(object sender, EventArgs e)
        {
            TeacherGUI tGUI = new TeacherGUI();
            this.Hide();
            tGUI.ShowDialog();
            this.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn có đồng ý thoát?", "Thông báo", MessageBoxButtons.OK);
            Application.Exit();
        }

        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TTAccount ttacc = new TTAccount();
            this.Hide();
            ttacc.ShowDialog();
            this.Show();
        }
    }
}
