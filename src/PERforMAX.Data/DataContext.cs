using Microsoft.EntityFrameworkCore;
using PERforMAX.Domain.Entities;

namespace PERforMAX.Data
{
    public class DataContext : DbContext
    {
        public DbSet<User> Users { get; set; }

    }
}
