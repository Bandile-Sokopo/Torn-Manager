namespace API.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string? UserName { get; set; }
        public string? ApiKey { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public string KnownAs { get; set; }
        public DateTime Created { get; set; } = DateTime.UtcNow;
        public DateTime LastActive { get; set; }
        public string Gender { get; set; }
        public Photo photo { get; set; }
    }
}
