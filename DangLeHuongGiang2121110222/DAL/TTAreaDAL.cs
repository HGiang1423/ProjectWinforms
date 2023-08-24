using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class TTAreaDAL:DBConnection
    {
        public List<AccountDTO> ReadAreaList()
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from TableTaiKhoan", conn);
            SqlDataReader reader = cmd.ExecuteReader();

            List<AccountDTO> lstArea = new List<AccountDTO>();
            while (reader.Read())
            {
                AccountDTO area = new AccountDTO();
                area.MaTK = reader["MaTK"].ToString();
                area.TaiKhoan = reader["TaiKhoan"].ToString();
                lstArea.Add(area);
            }
            conn.Close();
            return lstArea;
        }
        public AccountDTO ReadArea(int id)
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from TableQuyen where id=" + id.ToString(), conn);
            SqlDataReader reader = cmd.ExecuteReader();
            AccountDTO area = new AccountDTO();
            if (reader.HasRows && reader.Read())
            {
                area.MaTK = reader["MaTK"].ToString();
                area.TaiKhoan = reader["TaiKhoan"].ToString();
            }
            conn.Close();
            return area;
        }
    }
}
