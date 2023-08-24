using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUII
{
    public partial class ADO : Form
    {
        public ADO()
        {
            InitializeComponent();
        }

        private void ADO_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-62Q45KT\\SQLEXPRESS01; Initial Catalog=sale; User Id=sa; Password=141123");
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from customer00", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    dgvCustomer.Rows.Add(reader.GetInt32(0), reader.GetString(1));

                }
            }
            conn.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btNew_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-62Q45KT\\SQLEXPRESS01; Initial Catalog=sale; User Id=sa; Password=141123");
            conn.Open();
            //SqlCommand cmd = new SqlCommand("insert into customer values("+tbId.Text+",'"+tbName.Text+"')", conn);
            SqlCommand cmd = new SqlCommand("insert into customer00 values(@id, @name)", conn);
            cmd.Parameters.Add(new SqlParameter("@id", tbId.Text));
            cmd.Parameters.Add(new SqlParameter("@name", tbName.Text));
            cmd.ExecuteNonQuery();
            conn.Close();

            dgvCustomer.Rows.Add(tbId.Text, tbName.Text);  
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-62Q45KT\\SQLEXPRESS01; Initial Catalog=sale; User Id=sa; Password=141123");
            conn.Open();
            //SqlCommand cmd = new SqlCommand("delete from customer where id =" + tbId.Text, conn);
            SqlCommand cmd = new SqlCommand("delete from customer00 where id = @id", conn);
            cmd.Parameters.Add(new SqlParameter("@id", tbId.Text));
            cmd.ExecuteNonQuery();
            conn.Close();

            int idx = dgvCustomer.CurrentCell.RowIndex;
            dgvCustomer.Rows.RemoveAt(idx);
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-62Q45KT\\SQLEXPRESS01; Initial Catalog=sale; User Id=sa; Password=141123");
            conn.Open();
            //SqlCommand cmd = new SqlCommand("update customer set name='" + tbName.Text + "' where id =" + tbId.Text, conn);
            SqlCommand cmd = new SqlCommand("update customer00 set name= @name where id =@id", conn);
            cmd.Parameters.Add(new SqlParameter("@id", tbId.Text));
            cmd.Parameters.Add(new SqlParameter("@name", tbName.Text));
            cmd.ExecuteNonQuery();
            conn.Close();

            //int idx = dgvEmployee.CurrentCell.RowIndex;
            int idx = dgvCustomer.CurrentCell.RowIndex;
            dgvCustomer.Rows[idx].Cells[1].Value=tbName.Text;
        }

        private void btRead_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-62Q45KT\\SQLEXPRESS01; Initial Catalog=sale; User Id=sa; Password=141123");
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from customer00", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    dgvCustomer.Rows.Add(reader.GetInt32(0), reader.GetString(1));

                }
            }
            conn.Close();
        }

        private void dgvCustomer_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int idx = e.RowIndex;
            //if { ... }
            tbId.Text = dgvCustomer.Rows[idx].Cells[0].Value.ToString();
            tbName.Text = dgvCustomer.Rows[idx].Cells[1].Value.ToString();
        }

    }
}
