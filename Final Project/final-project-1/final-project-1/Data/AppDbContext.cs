using final_project_1.Models;
using Microsoft.EntityFrameworkCore;

namespace final_project_1.Data
{
    public class AppDbContext : DbContext
    {
        public virtual DbSet<ItemData> Items { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> option)
        : base(option)
        {

        }
    }
}
