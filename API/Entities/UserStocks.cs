namespace API.Entities
{
    public class UserStocks
    {
        public int Id { get; set; }
        public string Stock { get; set; }
        public int Total { get; set; }
        public bool isActive { get; set; }
        public int IncrementsActive { get; set; }
    }
}
