﻿using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace GUII._3Class
{
    public partial class TTAccount : Form
    {
        TTAccountBUS cusBAL = new TTAccountBUS();
        //TTArea areaBAL = new TTArea();

        public TTAccount()
        {
            InitializeComponent();
        }

        private void TTAccount_Load(object sender, EventArgs e)
        {
            List<AccountDTO> lstCus = cusBAL.ReadAreaList();
            foreach (AccountDTO cus in lstCus)
            {
                dgvTTAdmin.Rows.Add(cus.MaTK, cus.TaiKhoan, cus.MatKhau);
            }
            
        }

        private void dgvTTAdmin_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int idx = e.RowIndex;
            DataGridViewRow row = dgvTTAdmin.Rows[idx];
            if (row.Cells[0].Value != null)
            {
                tbId.Text = row.Cells[0].Value.ToString();
                tbName.Text = row.Cells[1].Value.ToString();
                tbmk.Text = row.Cells[2].Value.ToString();
            }
        }

        //kiểm tra id 
        private bool kiemtraID(string id)
        {
            foreach (DataGridViewRow row in dgvTTAdmin.Rows)
            {
                if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() == id)
                {
                    return true;
                }
            }
            return false;
        }

        private void btNew_Click(object sender, EventArgs e)
        {
            string newId = tbId.Text;
            if (kiemtraID(newId))
            {
                MessageBox.Show("ID đã tồn tại, vui lòng nhập id khác.");
                return;
            }
            AccountDTO cus = new AccountDTO();
            cus.MaTK = tbId.Text;
            cus.TaiKhoan = tbName.Text;
            cus.MatKhau = tbmk.Text;

            cusBAL.NewAccount(cus);

            dgvTTAdmin.Rows.Add(cus.MaTK, cus.TaiKhoan, cus.MatKhau);
            MessageBox.Show("Thêm thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvTTAdmin.CurrentRow;
            if (row != null)
            {
                string currentId = row.Cells[0].Value.ToString();
                string newId = tbId.Text;

                // Kiểm tra xem ID mới đã tồn tại chưa (nếu khác ID cũ)
                if (currentId != newId && kiemtraID(newId))
                {
                    MessageBox.Show("ID đã tồn tại, vui lòng nhập id khác.");
                    return;
                }

                AccountDTO cus = new AccountDTO();
                cus.MaTK = tbId.Text;
                cus.TaiKhoan = tbName.Text;
                cus.MatKhau = tbmk.Text;

                cusBAL.EditAccount(cus);

                row.Cells[0].Value = cus.MaTK;
                row.Cells[1].Value = cus.TaiKhoan;
                row.Cells[2].Value = cus.MatKhau;
                MessageBox.Show("Sửa thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa tài khoản này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                AccountDTO cus = new AccountDTO();
                cus.MaTK = tbId.Text;
                cus.TaiKhoan = tbName.Text;
                cus.MatKhau = tbmk.Text;

                cusBAL.DeleteAccount(cus);

                int idx = dgvTTAdmin.CurrentCell.RowIndex;
                dgvTTAdmin.Rows.RemoveAt(idx);
                MessageBox.Show("Xóa thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void liênHệToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LienHe lh = new LienHe();
            this.Hide();
            lh.ShowDialog();
            this.Show();
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Tìm kiếm
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = tbSearch.Text.ToLower(); // Từ khóa tìm kiếm

            // Lặp qua tất cả các hàng trong DataGridView để tìm kiếm
            foreach (DataGridViewRow row in dgvTTAdmin.Rows)
            {
                if (row.Cells[1].Value != null && row.Cells[2].Value != null)
                {
                    string name = row.Cells[1].Value.ToString().ToLower();
                    string area = row.Cells[2].Value.ToString().ToLower();

                    // Kiểm tra xem từ khóa có tồn tại trong tên hoặc khu vực không
                    if (name.Contains(keyword) || area.Contains(keyword))
                    {
                        row.Visible = true; // Hiển thị hàng thỏa mãn tìm kiếm
                    }
                    else
                    {
                        row.Visible = false; // Ẩn hàng không thỏa mãn tìm kiếm
                    }
                }
            }
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn có đồng ý thoát?", "Thông báo", MessageBoxButtons.OK);
            Application.Exit();
        }

        private void thôngTinGiảngViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TeacherGUI tGUI = new TeacherGUI();
            this.Hide();
            tGUI.ShowDialog();
            this.Show();
        }

        private void thôngTinSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerGUI cGUI = new CustomerGUI();
            this.Hide();
            cGUI.ShowDialog();
            this.Show();
        }
    }
}
