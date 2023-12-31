﻿using DBlayer.Interfaces;
using EntitiesLayer;
using LogicLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBlayer
{
    public  class LocationDB : ILocationDB
    {
        SqlConnection conn = new SqlConnection("server  = mssqlstud.fhict.local;database= dbi499087;User Id = dbi499087; Password=2018Ayham.; ");


        public List<Location> GetAllLocations()
        {
            List < Location > locations = new List<Location>();


            return locations;
        }
        public List<Location> ReadLocations()
        {
            string sql = "SELECT * FROM pickupLocation ;";
            SqlCommand cmd = new SqlCommand(sql, this.conn);

            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            List < Location > location  = new List<Location>();
           

            while (dr.Read())
            {

                location.Add(new Location(Convert.ToInt32(dr[0]), Convert.ToString(dr[1]), Convert.ToString(dr[2])));

            }


            conn.Close();
            return location;
        }

        public void CreateLocation(Location location)
        {
            string sql = "insert into pickupLocation (name,address) values (@name,@address);";

            SqlCommand cmd = new SqlCommand(sql, this.conn);




            cmd.Parameters.AddWithValue("@name", location.Name);
            cmd.Parameters.AddWithValue("@address", location.Address);
          
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void DeleteLocation(Location location)
        {
            string sql = "DELETE FROM pickupLocation WHERE id = @id ;";

            SqlCommand cmd = new SqlCommand(sql, this.conn);
            cmd.Parameters.AddWithValue("@id", location.Id);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void UpdateLocation(Location location)
        {
            string sql = "UPDATE pickupLocation SET name = @name , address = @address WHERE Id = @id;";

            SqlCommand cmd = new SqlCommand(sql, this.conn);

            cmd.Parameters.AddWithValue("@id", location.Id);
            cmd.Parameters.AddWithValue("@name", location.Name);
            cmd.Parameters.AddWithValue("@address", location.Address);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

    }
}
