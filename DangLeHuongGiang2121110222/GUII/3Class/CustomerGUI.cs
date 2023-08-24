using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;
using GUII._3Class;
//using Excel = Microsoft.Office.Interop.Excel;

using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace GUII
{
    public partial class CustomerGUI : Form
    {
        CustomerBAL cusBAL = new CustomerBAL();
        AreaBAL areaBAL = new AreaBAL();
        public CustomerGUI()
        {
            InitializeComponent();
        }

        private void CustomerGUI_Load(object sender, EventArgs e)
        {
            List<CustomerBEL> lstCus = cusBAL.ReadCustomer();
            foreach (CustomerBEL cus in lstCus)
            {
                dgvCustomer.Rows.Add(cus.Id, cus.Name, cus.AreaName, cus.Malop);
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
            foreach (DataGridViewRow row in dgvCustomer.Rows)
            {
                if (row.Cells[0].Value != null && int.Parse(row.Cells[0].Value.ToString()) == id)
                {
                    return true;
                }
            }
            return false;
        }

        private void btNew_Click(object sender, EventArgs e)
        {
            int newId = int.Parse(tbId.Text);
            if (kiemtraID(newId))
            {
                MessageBox.Show("ID đã tồn tại, vui lòng nhập id khác.");
                return;
            }
            CustomerBEL cus = new CustomerBEL();
            cus.Id = int.Parse(tbId.Text); 
            cus.Name = tbName.Text;
            cus.Area = (AreaBEL)cbArea.SelectedItem;
            cus.Malop = tbmalop.Text;
           
            cusBAL.NewCustomer(cus);

            dgvCustomer.Rows.Add(cus.Id, cus.Name, cus.Area.Name, cus.Malop);
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvCustomer.CurrentRow;
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

                CustomerBEL cus = new CustomerBEL();
                cus.Id = int.Parse(tbId.Text);
                cus.Name = tbName.Text;
                cus.Area = (AreaBEL)cbArea.SelectedItem;
                cus.Malop = tbmalop.Text;
                
                cusBAL.EditCustomer(cus);

                row.Cells[0].Value = cus.Id;
                row.Cells[1].Value = cus.Name;
                row.Cells[2].Value = cus.AreaName;
                row.Cells[3].Value = cus.Malop;
                
            }    
            
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            CustomerBEL cus = new CustomerBEL();
            cus.Id = int.Parse(tbId.Text);
            cus.Name = tbName.Text;
            cus.Area = (AreaBEL)cbArea.SelectedItem;
            cus.Malop = tbmalop.Text;
            cusBAL.DeleteCustomer(cus);

            int idx = dgvCustomer.CurrentCell.RowIndex;
            dgvCustomer.Rows.RemoveAt(idx);
        }

        private void tbId_Click(object sender, EventArgs e)
        {

        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dgvCustomer_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int idx = e.RowIndex;
            DataGridViewRow row = dgvCustomer.Rows[idx];
            if (row.Cells[0].Value !=null)
            {
                tbId.Text = row.Cells[0].Value.ToString();
                tbName.Text = row.Cells[1].Value.ToString();
                cbArea.Text = row.Cells[2].Value.ToString();
                tbmalop.Text = row.Cells[3].Value.ToString();
            }
        }

        private void liênHệToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LienHe lh = new LienHe();
            this.Hide();
            lh.ShowDialog();
            this.Show();
        }

        private void thôngTinGiảngViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TeacherGUI tGUI = new TeacherGUI();
            this.Hide();
            tGUI.ShowDialog();
            this.Show();
        }

        //Tìm kiếm
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = tbSearch.Text.ToLower(); // Từ khóa tìm kiếm

            // Lặp qua tất cả các hàng trong DataGridView để tìm kiếm
            foreach (DataGridViewRow row in dgvCustomer.Rows)
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

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Lấy hình
        private void btFile_Click(object sender, EventArgs e)
        {
            pbImage.SizeMode = PictureBoxSizeMode.StretchImage;
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = "Open Image";
            dlg.Filter = "JPEG files (*.jpg)|*.jpg";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                pbImage.ImageLocation = dlg.FileName;
            }    
        }

        //Xuất dữ liệu excel
        private void btnexcel_Click(object sender, EventArgs e)
        {
            //ThongKe tk = new ThongKe();
            //tk.ShowDialog();


            //DataTable dataTable = new DataTable();

            //DataColumn col1 = new DataColumn("id");
            //DataColumn col2 = new DataColumn("name");
            //DataColumn col3 = new DataColumn("id_erea");
            //DataColumn col4 = new DataColumn("malop");

            //dataTable.Columns.Add(col1);
            //dataTable.Columns.Add(col2);
            //dataTable.Columns.Add(col3);
            //dataTable.Columns.Add(col4);

            //foreach (DataGridViewRow dtgvRow in dgvCustomer.Rows)
            //{
            //    DataRow dtrow = dataTable.NewRow();

            //    dtrow[0] = dtgvRow.Cells[0].Value;
            //    dtrow[1] = dtgvRow.Cells[1].Value;
            //    dtrow[2] = dtgvRow.Cells[2].Value;
            //    dtrow[3] = dtgvRow.Cells[3].Value;

            //    dataTable.Rows.Add(dtrow);
            //}
            //ExportFile(dataTable, "Danh sach", "DANH SÁCH SINH VIÊN");
        }




        //public void ExportFile(DataTable dataTable, string sheetName, string title)
        //{
        //    //Tạo các đối tượng Excel

        //    Microsoft.Office.Interop.Excel.Application oExcel = new Microsoft.Office.Interop.Excel.Application();

        //    Microsoft.Office.Interop.Excel.Workbooks oBooks;

        //    Microsoft.Office.Interop.Excel.Sheets oSheets;

        //    Microsoft.Office.Interop.Excel.Workbook oBook;

        //    Microsoft.Office.Interop.Excel.Worksheet oSheet;

        //    //Tạo mới một Excel WorkBook 

        //    oExcel.Visible = true;

        //    oExcel.DisplayAlerts = false;

        //    oExcel.Application.SheetsInNewWorkbook = 1;

        //    oBooks = oExcel.Workbooks;

        //    oBook = (Microsoft.Office.Interop.Excel.Workbook)(oExcel.Workbooks.Add(Type.Missing));

        //    oSheets = oBook.Worksheets;

        //    oSheet = (Microsoft.Office.Interop.Excel.Worksheet)oSheets.get_Item(1);

        //    oSheet.Name = sheetName;

        //    // Tạo phần Tiêu đề
        //    Microsoft.Office.Interop.Excel.Range head = oSheet.get_Range("A1", "G1");

        //    head.MergeCells = true;

        //    head.Value2 = title;

        //    head.Font.Bold = true;

        //    head.Font.Name = "Times New Roman";

        //    head.Font.Size = "20";

        //    head.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

        //    // Tạo tiêu đề cột 

        //    Microsoft.Office.Interop.Excel.Range cl1 = oSheet.get_Range("A3", "A3");

        //    cl1.Value2 = "Mã";

        //    cl1.ColumnWidth = 12;

        //    Microsoft.Office.Interop.Excel.Range cl2 = oSheet.get_Range("B3", "B3");

        //    cl2.Value2 = "Họ tên";

        //    cl2.ColumnWidth = 25.0;

        //    Microsoft.Office.Interop.Excel.Range cl3 = oSheet.get_Range("C3", "C3");

        //    cl3.Value2 = "Giới Tính";
        //    cl3.ColumnWidth = 12.0;

        //    Microsoft.Office.Interop.Excel.Range cl4 = oSheet.get_Range("D3", "D3");

        //    cl4.Value2 = "Mã Lớp";

        //    cl4.ColumnWidth = 10.5;

        //    Microsoft.Office.Interop.Excel.Range rowHead = oSheet.get_Range("A3", "G3");

        //    rowHead.Font.Bold = true;

        //    // Kẻ viền

        //    rowHead.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;

        //    // Thiết lập màu nền

        //    rowHead.Interior.ColorIndex = 6;
        //    rowHead.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

        //    // Tạo mảng theo datatable

        //    object[,] arr = new object[dataTable.Rows.Count, dataTable.Columns.Count];

        //    //Chuyển dữ liệu từ DataTable vào mảng đối tượng

        //    for (int row = 0; row < dataTable.Rows.Count; row++)
        //    {
        //        DataRow dataRow = dataTable.Rows[row];

        //        for (int col = 0; col < dataTable.Columns.Count; col++)
        //        {
        //            arr[row, col] = dataRow[col];
        //        }
        //    }

        //    //Thiết lập vùng điền dữ liệu

        //    int rowStart = 4;

        //    int columnStart = 1;

        //    int rowEnd = rowStart + dataTable.Rows.Count - 2;

        //    int columnEnd = dataTable.Columns.Count;

        //    // Ô bắt đầu điền dữ liệu

        //    Microsoft.Office.Interop.Excel.Range c1 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowStart, columnStart];

        //    // Ô kết thúc điền dữ liệu

        //    Microsoft.Office.Interop.Excel.Range c2 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, columnEnd];

        //    // Lấy về vùng điền dữ liệu

        //    Microsoft.Office.Interop.Excel.Range range = oSheet.get_Range(c1, c2);

        //    //Điền dữ liệu vào vùng đã thiết lập

        //    range.Value2 = arr;

        //    // Kẻ viền

        //    range.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;

        //    // Căn giữa cột mã 

        //    //Microsoft.Office.Interop.Excel.Range c3 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, columnStart];

        //    //Microsoft.Office.Interop.Excel.Range c4 = oSheet.get_Range(c1, c3);

        //    //Căn giữa cả bảng 
        //    oSheet.get_Range(c1, c2).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
        //}

    }
}

