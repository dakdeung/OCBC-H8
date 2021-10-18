using Microsoft.EntityFrameworkCore;
using JwtApp.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace JwtApp.Data
{
    public class ApiDbContext : IdentityDbContext
    {
        public virtual DbSet<ItemData> items {get;set;}
        public virtual DbSet<RefreshToken> RefreshTokens {get;set;}

        public ApiDbContext(DbContextOptions<ApiDbContext> option) 
        : base(option) {

        }
    }
}