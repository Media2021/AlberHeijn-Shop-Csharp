
using LogicLayer;
using System.Data.SqlClient;

namespace DBlayer
{
    public class PersonDB
    {
        SqlConnection conn = new SqlConnection("server  = mssqlstud.fhict.local;database= dbi499087;User Id = dbi499087; Password=2018Ayham.; ");
        public List<Employee> GetAllEMP()
        {
            List<Employee> employees = new List<Employee>();
            return employees;

        }
        public List<User> GetAllUser()
        {
            List<User> users = new List<User>();
            return users;

        }
        public void CreateEMP(Employee person)
        {
            string sql = "insert into MyEMP (name,surname,username,password,role) values ( @name,@surname,@username,@password,@role);";
            SqlCommand cmd = new SqlCommand(sql, this.conn);
            cmd.Parameters.AddWithValue("@name", person.Name);
            cmd.Parameters.AddWithValue("@surname", person.Surname);
            cmd.Parameters.AddWithValue("@username", person.Username);
            cmd.Parameters.AddWithValue("@password", person.Password);
            cmd.Parameters.AddWithValue("@role", person.Role);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

        }
    
        public void DeleteEMP(Employee person)
        {
            string sql = "Delete FROM MyEMP WHERE id = @id;";
            SqlCommand cmd = new SqlCommand(sql, this.conn);
            cmd.Parameters.AddWithValue("@id", person.Id);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public List<Employee> ReadEMP()
        {
            string sql = " SELECT * FROM MyEMP ;";
            SqlCommand cmd = new SqlCommand(sql, this.conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            List<Employee> ReadPeopel = new List<Employee>();
            while (dr.Read())
            {
                ReadPeopel.Add(new Employee(Convert.ToInt32(dr[0]), Convert.ToString(dr[1]), Convert.ToString(dr[2]), Convert.ToString(dr[3]), Convert.ToString(dr[4]), Convert.ToString(dr[5])));
            }
            conn.Close();
            return ReadPeopel;
        }   
        public void CreateUser(User user )
        {
            string sql = "insert into Customer (name,surname,username,password) values ( @name,@surname,@username,@password);";
            SqlCommand cmd = new SqlCommand(sql, this.conn);
            cmd.Parameters.AddWithValue("@name", user.Name);
            cmd.Parameters.AddWithValue("@surname", user.Surname);
            cmd.Parameters.AddWithValue("@username", user.Username);
            cmd.Parameters.AddWithValue("@password", user.Password);
         
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

        }
        public void DeleteUser(User user )
        {
            string sql = "Delete FROM Customer WHERE id = @id;";
            SqlCommand cmd = new SqlCommand(sql, this.conn);
            cmd.Parameters.AddWithValue("@id", user.Id);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public List<User> ReadUser()
        {
            string sql = " SELECT * FROM Customer  ;";
            SqlCommand cmd = new SqlCommand(sql, this.conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            List<User> ReadUsers = new List<User>();

            while (dr.Read())
            {
                ReadUsers.Add(new User(Convert.ToInt32(dr[0]), Convert.ToString(dr[1]), Convert.ToString(dr[2]), Convert.ToString(dr[3]), Convert.ToString(dr[4])));
            }
            conn.Close();
            return ReadUsers;
        }
    }
}