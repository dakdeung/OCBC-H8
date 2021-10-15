using Microsoft.EntityFrameworkCore;
using TodoApp.Models;

namespace TodoApp.Data
{
    public class ApiDbContext : DbContext 
    {
        public virtual DbSet<ItemData> items {get;set;}

        public ApiDbContext(DbContextOptions<ApiDbContext> option) 
        : base(option) {

        }
    }
}