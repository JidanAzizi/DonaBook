namespace DonaBookApi.Model
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Password { get; set; }
        public string Contact { get; set; }
        public string Role { get; set; }

        // Constructor kosong untuk deserialisasi JSON
        public User() { }

        // Constructor lengkap untuk manual instansiasi
        public User(int id, string name, string email, string address, string password, string contact, string role)
        {
            Id = id;
            Name = name;
            Email = email;
            Address = address;
            Password = password;
            Contact = contact;
            Role = role;
        }
    }
}
