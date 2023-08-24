using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;
using GUII._3Class;

namespace GUII.Login
{
    public partial class DangNhap : Form
    {
        AccountDTO taikhoanDTO = new AccountDTO();
        AccountBUS taikhoanBUS = new AccountBUS();
        public DangNhap()
        {
            InitializeComponent();
        }

        private void btDangNhap_Click(object sender, EventArgs e)
        {
            taikhoanDTO.TaiKhoan = txtTaiKhoan.Text;
            taikhoanDTO.MatKhau = txtMatKhau.Text;

            string getuser = taikhoanBUS.CheckLogic(taikhoanDTO);

            // Thể hiện trả lại kết quả nếu nghiệp vụ không đúng
            switch (getuser)
            {
                case "requeid_taikhoan":
                    MessageBox.Show("Tài khoản không được để trống");
                    return;

                case "requeid_password":
                    MessageBox.Show("Mật khẩu không được để trống");
                    return;

                case "Tài khoản hoặc mật khẩu không chính xác!":
                    MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác!");
                    return;
            }

            MessageBox.Show("Xin chúc mừng bạn đã đăng nhập thành công hệ thống!");
            HeThong hethong = new HeThong();
            this.Hide();
            hethong.ShowDialog();
            this.Show();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn có đồng ý thoát?", "Thông báo", MessageBoxButtons.OK);
            Application.Exit();
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {

        }

        private void DangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát chương trình?", "Thông báo!", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
    }
}
