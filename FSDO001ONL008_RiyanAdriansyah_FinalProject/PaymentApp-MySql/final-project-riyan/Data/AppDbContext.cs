using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using final_project_riyan.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace final_project_riyan.Data
{
    public class AppDbContext : IdentityDbContext
    {
        public virtual DbSet<ItemData> Items { get; set; }

        public virtual DbSet<RefreshToken> RefreshTokens { get; set; }

        protected static void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ItemData>()
                .Property(p => p.paymentDetailId)
                .ValueGeneratedOnAdd();
        }

        public AppDbContext(DbContextOptions<AppDbContext> option)
        : base(option)
        {

        }
    }
}
