using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class TTAccountDAL : DBConnection
    {
        public List<AccountDTO> ReadAreaList()
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from TableTaiKhoan", conn);
            SqlDataReader reader = cmd.ExecuteReader();

            List<AccountDTO> lstCus = new List<AccountDTO>();
            //TTAreaDAL are = new TTAreaDAL();
            while (reader.Read())
            {
                AccountDTO cus = new AccountDTO();
                cus.MaTK = reader["MaTk"].ToString();
                cus.TaiKhoan = reader["TaiKhoan"].ToString();
                cus.MatKhau = reader["MatKhau"].ToString();
                lstCus.Add(cus);
            }
            conn.Close();
            return lstCus;
        }

        public void DeleteAccount(AccountDTO cus)
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("delete from TableTaiKhoan where MaTK = @id", conn);
            cmd.Parameters.Add(new SqlParameter("@id", cus.MaTK));
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void NewAccount(AccountDTO cus)
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into TableTaiKhoan (MaTk, TaiKhoan, MatKhau) values (@id, @name, @mk)", conn);
            cmd.Parameters.Add(new SqlParameter("@id", cus.MaTK));
            cmd.Parameters.Add(new SqlParameter("@name", cus.TaiKhoan));
            cmd.Parameters.Add(new SqlParameter("@mk", cus.MatKhau));


            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void EditAccount(AccountDTO cus)
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("update TableTaiKhoan set TaiKhoan = @name, MatKhau= @mk where MaTK = @id", conn);
            cmd.Parameters.Add(new SqlParameter("@id", cus.MaTK));
            cmd.Parameters.Add(new SqlParameter("@name", cus.TaiKhoan));
            cmd.Parameters.Add(new SqlParameter("@mk", cus.MatKhau));

            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
