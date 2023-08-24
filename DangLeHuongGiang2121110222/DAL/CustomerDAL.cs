﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class CustomerDAL:DBConnection 
    {
        public List<CustomerBEL> ReadCustomer()
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from customer00", conn);
            SqlDataReader reader = cmd.ExecuteReader();

            List<CustomerBEL> lstCus = new List<CustomerBEL>();
            AreaDAL are = new AreaDAL();
            while (reader.Read())
            {
                CustomerBEL cus = new CustomerBEL();
                cus.Id = int.Parse(reader["id"].ToString());
                cus.Name = reader["name"].ToString();
                cus.Area = are.ReadArea(int.Parse(reader["id_area"].ToString()));
                cus.Malop = reader["malop"].ToString();
                lstCus.Add(cus);
            }
            conn.Close();
            return lstCus;
        }

        public void DeleteCustomer(CustomerBEL cus)
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("delete from customer00 where id = @id", conn);
            cmd.Parameters.Add(new SqlParameter("@id", cus.Id));
            cmd.ExecuteNonQuery();
            conn.Close ();
        }

        public void NewCustomer(CustomerBEL cus)
        {
            SqlConnection conn = CreateConnection();
            conn.Open ();
            SqlCommand cmd = new SqlCommand("insert into customer00 values(@id, @name, @id_area, @malop)", conn);
            cmd.Parameters.Add(new SqlParameter("@id", cus.Id));
            cmd.Parameters.Add(new SqlParameter("@name", cus.Name));
            cmd.Parameters.Add(new SqlParameter("@id_area", cus.Area.Id));
            cmd.Parameters.Add(new SqlParameter("@malop", cus.Malop));
            
            cmd.ExecuteNonQuery ();
            conn.Close ();
        }

        public void EditCustomer(CustomerBEL cus)
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("update customer00 set name = @name, id_area = @id_area, malop = @malop where id = @id", conn);
            cmd.Parameters.Add(new SqlParameter("@id", cus.Id));
            cmd.Parameters.Add(new SqlParameter("@name", cus.Name));
            cmd.Parameters.Add(new SqlParameter("@id_area", cus.Area.Id));
            cmd.Parameters.Add(new SqlParameter("@malop", cus.Malop));
            
            cmd.ExecuteNonQuery();
            conn.Close();
        }       
    }
}
