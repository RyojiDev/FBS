using FBS.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace FBS.InfraStructure.DataBase
{
    public class DataBaseItemContext : DbContext
    {
        public DataBaseItemContext(DbContextOptions<DataBaseItemContext> options)
            : base (options)
        {

        }

        public DbSet<PurchaseItem> PurchaseItems { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {

        }
    }
}
