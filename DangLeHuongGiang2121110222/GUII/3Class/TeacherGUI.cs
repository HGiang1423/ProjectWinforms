using BUS;
using DTO;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Application = System.Windows.Forms.Application;

namespace GUII._3Class
{
    public partial class TeacherGUI : Form
    {
        TeacherBAL cusBAL = new TeacherBAL();
        AreaBAL areaBAL = new AreaBAL();
        public TeacherGUI()
        {
            InitializeComponent();
        }

        private void TeacherGUI_Load(object sender, EventArgs e)
        {
            List<TeacherBEL> lstCus = cusBAL.ReadTeacher();
            foreach (TeacherBEL cus in lstCus)
            {
                dgvTeacher.Rows.Add(cus.Id, cus.Name, cus.AreaName, cus.Malop, cus.Sdt, cus.Email);
            }
            List<AreaBEL> lstArea = areaBAL.ReadAreaList();
            foreach (AreaBEL area in lstArea)
            {
                cbArea.Items.Add(area);
            }
            cbArea.DisplayMember = "name";
        }

        //kiểm tra id 
        private bool kiemtraID(int id)
        {
            foreach (DataGridViewRow row in dgvTeacher.Rows)
            {
                if (row.Cells[0].Value != null && int.Parse(row.Cells[0].Value.ToString()) == id)
                {
                    return true;
                }
            }
            return false;
        }

        private void dgvTeacher_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int idx = e.RowIndex;
            DataGridViewRow row = dgvTeacher.Rows[idx];
            if (row.Cells[0].Value != null)
            {
                tbId.Text = row.Cells[0].Value.ToString();
                tbName.Text = row.Cells[1].Value.ToString();
                cbArea.Text = row.Cells[2].Value.ToString();
                tbmalop.Text = row.Cells[3].Value.ToString();
                tbsdt.Text = row.Cells[4].Value.ToString();
                tbemail.Text = row.Cells[5].Value.ToString();
            }
        }

        private void btNew_Click(object sender, EventArgs e)
        {
            int newId = int.Parse(tbId.Text);
            if (kiemtraID(newId))
            {
                MessageBox.Show("ID đã tồn tại, vui lòng nhập id khác.");
                return;
            }
            TeacherBEL cus = new TeacherBEL();
            cus.Id = int.Parse(tbId.Text);
            cus.Name = tbName.Text;
            cus.Area = (AreaBEL)cbArea.SelectedItem;
            cus.Malop = tbmalop.Text;
            cus.Sdt = tbsdt.Text;
            cus.Email = tbemail.Text;

            cusBAL.NewTeacher(cus);

            dgvTeacher.Rows.Add(cus.Id, cus.Name, cus.Area.Name, cus.Malop, cus.Sdt, cus.Email);
            MessageBox.Show("Thêm thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvTeacher.CurrentRow;
            if (row != null)
            {
                int currentId = int.Parse(row.Cells[0].Value.ToString());
                int newId = int.Parse(tbId.Text);

                // Kiểm tra xem ID mới đã tồn tại chưa (nếu khác ID cũ)
                if (currentId != newId && kiemtraID(newId))
                {
                    MessageBox.Show("ID đã tồn tại, vui lòng nhập id khác.");
                    return;
                }

                TeacherBEL cus = new TeacherBEL();
                cus.Id = int.Parse(tbId.Text);
                cus.Name = tbName.Text;
                cus.Area = (AreaBEL)cbArea.SelectedItem;
                cus.Malop = tbmalop.Text;
                cus.Sdt = tbsdt.Text;
                cus.Email = tbemail.Text;

                cusBAL.EditTeacher(cus);

                row.Cells[0].Value = cus.Id;
                row.Cells[1].Value = cus.Name;
                row.Cells[2].Value = cus.AreaName;
                row.Cells[3].Value = cus.Malop;
                row.Cells[4].Value = cus.Sdt;
                row.Cells[5].Value = cus.Email;
                MessageBox.Show("Sửa thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            TeacherBEL cus = new TeacherBEL();
            cus.Id = int.Parse(tbId.Text);
            cus.Name = tbName.Text;
            cus.Area = (AreaBEL)cbArea.SelectedItem;
            cus.Malop = tbmalop.Text;
            cus.Sdt = tbsdt.Text;
            cus.Email = tbemail.Text;

            cusBAL.DeleteTeacher(cus);

            int idx = dgvTeacher.CurrentCell.RowIndex;
            dgvTeacher.Rows.RemoveAt(idx);
            MessageBox.Show("Xóa thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void liênHệToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LienHe lh = new LienHe();
            this.Hide();
            lh.ShowDialog();
            this.Show();
        }

        //Tìm kiếm
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = tbSearch.Text.ToLower(); // Từ khóa tìm kiếm

            // Lặp qua tất cả các hàng trong DataGridView để tìm kiếm
            foreach (DataGridViewRow row in dgvTeacher.Rows)
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

        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TTAccount ttacc = new TTAccount();
            ttacc.ShowDialog();
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn có đồng ý thoát?", "Thông báo", MessageBoxButtons.OK);
            Application.Exit();
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

