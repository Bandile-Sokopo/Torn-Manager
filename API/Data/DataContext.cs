using Microsoft.EntityFrameworkCore;
using API.Entities;

namespace API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<TransactionHistory> Transactions { get; set; }
        public DbSet<OwnedStocks> OwnedStocks { get; set; }
        public DbSet<StockTransactions> StockTransactions { get; set; }

    }
}
