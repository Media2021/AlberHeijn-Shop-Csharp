﻿
using DBlayer.Interfaces;
using EntitiesLayer;
using LogicLayer;
using System.Data.SqlClient;

namespace DBlayer
{
    public class PersonDB : IPersonDB
    {
        SqlConnection conn = new SqlConnection("server  = mssqlstud.fhict.local;database= dbi499087;User Id = dbi499087; Password=2018Ayham.; ");
      
     
      
    
        public void CreateUser(User user )
        {
            string sql = "insert into MyUsers1 (name,surname,username,password,roleId,salt) values ( @name,@surname,@username,@password,@roleId,@salt);";
            SqlCommand cmd = new SqlCommand(sql, this.conn);
            cmd.Parameters.AddWithValue("@name", user.Name);
            cmd.Parameters.AddWithValue("@surname", user.Surname);
            cmd.Parameters.AddWithValue("@username", user.Username);
            cmd.Parameters.AddWithValue("@password", user.Password);
            cmd.Parameters.AddWithValue("@roleId",(int) user.UserRole);
            cmd.Parameters.AddWithValue("@salt", user.Salt);




            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

        }
        public List<User> ReadUser()
        {
            string sql = " SELECT * FROM MyUsers1 ;";
            SqlCommand cmd = new SqlCommand(sql, this.conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            List<User> ReadUsers = new List<User>();
           
           

            while (dr.Read())
            {
                ReadUsers.Add(new User(Convert.ToInt32(dr[0]), Convert.ToString(dr[1]), Convert.ToString(dr[2]), Convert.ToString(dr[3]), Convert.ToString(dr[4]), (UserRole)Convert.ToInt32(dr[5]), Convert.ToString(dr[6])));
            }
            conn.Close();
            return ReadUsers;
        }

        //public void UpdateUser(User user)
        //{
        //    string sql = "UPDATE MyUsers1 SET name =  @name  , surname = @surname, username = @username , password = @password , roleId = @roleId , salt =  @salt  WHERE Id = @id;";


        //    SqlCommand cmd = new SqlCommand(sql, this.conn);
        //    cmd.Parameters.AddWithValue("@name", user.Name);
        //    cmd.Parameters.AddWithValue("@surname", user.Surname);
        //    cmd.Parameters.AddWithValue("@username", user.Username);
        //    cmd.Parameters.AddWithValue("@password", user.Password);
        //    cmd.Parameters.AddWithValue("@roleId", (int)user.UserRole);
        //    cmd.Parameters.AddWithValue("@salt", user.Salt);



        //    conn.Open();
        //    cmd.ExecuteNonQuery();
        //    conn.Close();
        //}
    }
}