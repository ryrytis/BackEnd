namespace API0103
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Pass { get; set; }
        public string Role { get; set; }

        public User()
        {
        }

        public User(string name, string pass, string role)
        {
            UserName = name;
            Pass = pass;
            Role = role;
        }
    }
}