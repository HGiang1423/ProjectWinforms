using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
        public class SqlConnectionData
        {
            // Tạo chuỗi kết nối cơ sở dữ liệu
            public static SqlConnection Connect()
            {
                string strcon = @"Data Source=DESKTOP-62Q45KT\SQLEXPRESS01;Initial Catalog=QLSinhVien;Integrated Security=True";
                SqlConnection conn = new SqlConnection(strcon); // khởi tạo connect
                return conn;
            }
        }

    public class DatabaseAccess
    {
        public static string CheckLogicDTO(AccountDTO taikhoan)
        {
            string user = null;
            // Hàm connect tới CSDL
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            SqlCommand command = new SqlCommand("PROCLOGIN", conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@user", taikhoan.TaiKhoan);
            command.Parameters.AddWithValue("@pass", taikhoan.MatKhau);
            // Kiểm tra quyền thêm 1 cái parameter...
            command.Connection = conn;
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    user = reader.GetString(0);
                }
                reader.Close();
                conn.Close();
            }
            else
            {
                return "Tài khoản hoặc mật khẩu không chính xác!";
            }

            return user;
        }
    }
}
