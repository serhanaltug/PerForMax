using Microsoft.EntityFrameworkCore;
using PERforMAX.Domain.Entities;

namespace PERforMAX.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
            
        }
        public DbSet<User> Users { get; set; }

    }
}
