namespace API.Entities
{
    public class OwnedStocks
    {
        public int Id { get; set; }
        public string? Stock { get; set; }
        public int TotalOwned { get; set; }
        public bool isActive { get; set; }
        public int IncrementsActive { get; set; }
    }
}
