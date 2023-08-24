using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class TeacherDAL:DBConnection
    {
        public List<TeacherBEL> ReadTeacher()
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from teacher", conn);
            SqlDataReader reader = cmd.ExecuteReader();

            List<TeacherBEL> lstCus = new List<TeacherBEL>();
            AreaDAL are = new AreaDAL();
            while (reader.Read())
            {
                TeacherBEL cus = new TeacherBEL();
                cus.Id = int.Parse(reader["id"].ToString());
                cus.Name = reader["name"].ToString();
                cus.Area = are.ReadArea(int.Parse(reader["id_area"].ToString()));
                cus.Malop = reader["malop"].ToString();
                cus.Sdt = reader["sdt"].ToString();
                cus.Email = reader["email"].ToString();
                lstCus.Add(cus);
            }
            conn.Close();
            return lstCus;
        }
        public void DeleteTeacher(TeacherBEL cus)
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("delete from teacher where id = @id" , conn);
            cmd.Parameters.Add(new SqlParameter("@id" , cus.Id));
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void NewTeacher(TeacherBEL cus)
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into teacher values(@id , @name , @id_area , @malop , @sdt , @email)", conn);
            cmd.Parameters.Add(new SqlParameter("@id" , cus.Id));
            cmd.Parameters.Add(new SqlParameter("@name" , cus.Name));
            cmd.Parameters.Add(new SqlParameter("@id_area" , cus.Area.Id));
            cmd.Parameters.Add(new SqlParameter("@malop" , cus.Malop));
            cmd.Parameters.Add(new SqlParameter("@sdt" , cus.Sdt));
            cmd.Parameters.Add(new SqlParameter("@email" , cus.Email));
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void EditTeacher(TeacherBEL cus)
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("update teacher set name = @name , id_area = @id_area , malop = @malop, sdt = @sdt , email = @email where id = @id", conn);
            cmd.Parameters.Add(new SqlParameter("@id" , cus.Id));
            cmd.Parameters.Add(new SqlParameter("@name" , cus.Name));
            cmd.Parameters.Add(new SqlParameter("@id_area" , cus.Area.Id));
            cmd.Parameters.Add(new SqlParameter("@malop" , cus.Malop));
            cmd.Parameters.Add(new SqlParameter("@sdt" , cus.Sdt));
            cmd.Parameters.Add(new SqlParameter("@email" , cus.Email));

            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
