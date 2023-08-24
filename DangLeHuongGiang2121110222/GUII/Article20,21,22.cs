﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using System.Reflection;

namespace GUII
{
    public partial class Form20 : Form
    {
        List<Employee> lst;
        private void btFile_Click(object sender, EventArgs e)
        {
            picImage.SizeMode = PictureBoxSizeMode.StretchImage;
            picImage.ImageLocation = @"D:\bong.jpg";
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = "Open Image";
            dlg.Filter = "JPEG files (*.jpg) | *.jpg";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                picImage.ImageLocation = dlg.FileName;
            }
        }
        //ArrayList 1stEm
        public Form20()
        {
            InitializeComponent();
        }
        private void Form20_Load(object sender, EventArgs e)
        {
            lst = GetData();
            foreach (Employee em in lst)
            {
                dgvEmployee.Rows.Add(em.Id, em.Name, em.Age, em.Gender/*, em.Ngaysinh*/);
            }

            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            //if (tbId.Text == "" || tbName.Text == "" || tbAge.Text == "" || dgvEmployee.CurrentCell == null)
            //{
            //    MessageBox.Show("Sửa thất bại", "Thông báo", MessageBoxButtons.OK);
            //}
            //else
            //{
                int idx = e.RowIndex;
                tbId.Text = dgvEmployee.Rows[idx].Cells[0].Value.ToString();
                tbName.Text = dgvEmployee.Rows[idx].Cells[1].Value.ToString();
                tbAge.Text = dgvEmployee.Rows[idx].Cells[2].Value.ToString();
                ckGender.Checked = bool.Parse(dgvEmployee.Rows[idx].Cells[3].Value.ToString());
            //    MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK);
            //}
            
        }


        private void btAddNew_Click(object sender, EventArgs e)
        {
            if (tbId.Text == "" || tbName.Text == "" || tbAge.Text == "" || dgvEmployee.CurrentCell == null)
            {
                MessageBox.Show("Thêm thất bại", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                dgvEmployee.Rows.Add(tbId.Text, tbName.Text, tbAge.Text, ckGender.Checked);
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK);
            }    
               
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Xóa nhé!", "Thông báo", MessageBoxButtons.OK);
            int idx = dgvEmployee.CurrentCell.RowIndex;
            dgvEmployee.Rows.RemoveAt(idx);
        }


        public List<Employee> GetData()
        {
            List<Employee> lst = new List<Employee>();
            Employee em = new Employee();
            em.Id = "53418";
            em.Name = "Trần Tiến";
            em.Age = 20;
            lst.Add(em);

            em = new Employee();
            em.Id = "53416";
            em.Name = "Nguyễn Cường";
            em.Age = 25;
            lst.Add(em);

            em = new Employee();
            em.Id = "53417";
            em.Name = "Nguyễn Hảo";
            em.Age = 23;
            lst.Add(em);
            return lst;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            if (tbId.Text == "" || tbName.Text == "" || tbAge.Text == "" || dgvEmployee.CurrentCell == null)
            {
                MessageBox.Show("Sửa thất bại", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                int idx = dgvEmployee.CurrentCell.RowIndex;
                dgvEmployee.Rows[idx].Cells[0].Value = tbId.Text;
                dgvEmployee.Rows[idx].Cells[1].Value = tbName.Text;
                dgvEmployee.Rows[idx].Cells[2].Value = tbAge.Text;
                dgvEmployee.Rows[idx].Cells[3].Value = ckGender.Checked;
                MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void dgvEmployee_SelectionChanged_1(object sender, EventArgs e)
        {
            int idx = dgvEmployee.CurrentCell.RowIndex;
            //DataTable Id = (DataTable)dgvEmployee.DataSource;
            //if (dgvEmployee.Rows.Count > 0)
            {
                tbId.Text = dgvEmployee.Rows[idx].Cells[0].Value.ToString();
                tbName.Text = dgvEmployee.Rows[idx].Cells[1].Value.ToString();
                tbAge.Text = dgvEmployee.Rows[idx].Cells[2].Value.ToString();
                //ckGender.Text = dgvEmployee.Rows[idx].Cells[3.Value.ToString();
            }
        }

        private void ckGender_CheckedChanged(object sender, EventArgs e)
        {
            if (ckGender.Checked)
                MessageBox.Show("Giới tính nam", "Thông báo", MessageBoxButtons.OK);
            else
                MessageBox.Show("Giới tính nữ", "Thông báo", MessageBoxButtons.OK);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void tbNs_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        //private void btFile_Click(object sender, EventArgs e)
        //{
        //    picImage.SizeMode = PictureBoxSizeMode.StretchImage;
            
        //}

        private void picImage_Click(object sender, EventArgs e)
        {

        }
    }
}
