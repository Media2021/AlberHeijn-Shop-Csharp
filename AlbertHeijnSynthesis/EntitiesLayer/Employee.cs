namespace LogicLayer
{
    public class Employee
    {
        private int id;
        private string name;
        private string surname;
        private string username;
        private string password;
        private string role;

        public Employee(int id, string name, string surname, string username, string password, string role)
        {
            this.id = id;
            this.name = name;
            this.surname = surname;
            this.username = username;
            this.password = password;
            this.role = role;
        }
        public Employee(string name, string surname, string username, string password, string role)
        {

            this.name = name;
            this.surname = surname;
            this.username = username;
            this.password = password;
            this.role = role;
        }
        public Employee()
        {

        }

        //public Employee(string name, string surname, string username, string password)
        //{
        //    this.name = name;
        //    this.surname = surname;
        //    this.username = username;
        //    this.password = password;
        //}

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Role { get => role; set => role = value; }

        public bool Login(string password)
        {
            if (this.Password == password)
            {
                return true;
            }
            return false;
        }

        public virtual string Info()
        {
            return $"My id is {id} ,My name is  {name} ";
        }
    }
}