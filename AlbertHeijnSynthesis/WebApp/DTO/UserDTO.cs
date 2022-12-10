namespace WebAppSynthesis.DTO
{
    public class UserDTO
    {
        string name;
        string surname;
        string userame;
        string password;


        public UserDTO()
        {
        }
        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public string Username { get => userame; set => userame = value; }
        public string Password { get => password; set => password = value; }
      
    }
}
