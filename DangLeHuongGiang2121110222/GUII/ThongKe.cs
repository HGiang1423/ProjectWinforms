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
using System.Windows.Forms.DataVisualization.Charting;

namespace GUII
{
    public partial class ThongKe : Form
    {
        private SqlConnection conn = new SqlConnection (@"Data Source=DESKTOP-62Q45KT\SQLEXPRESS01;Initial Catalog=QLSinhVien;Integrated Security=True");
        public ThongKe()
        {
            InitializeComponent();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            try 
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("select * from customer00", conn);
               
                conn.Open();
                
                da.Fill(dt);
                
                conn.Close();
                
                MessageBox.Show("Thành công!");

                // Tạo chuỗi dữ liệu 'malop'
                chart1.Series.Add("malop");
                chart1.Series["malop"].ChartType = SeriesChartType.Bar; // Chọn loại biểu đồ

                // Tạo chuỗi dữ liệu 'name'
                chart1.Series.Add("name");
                chart1.Series["name"].ChartType = SeriesChartType.Bar; // Chọn loại biểu đồ

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    chart1.Series["malop"].Points.AddXY(dt.Rows[i]["id"], dt.Rows[i]["malop"]);
                    chart1.Series["name"].Points.AddXY(dt.Rows[i]["id"], dt.Rows[i]["name"]);
                }
            }
            catch (Exception exp)
            {
                throw exp;
            }

        }
    }
}
