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

using Swashbuckle.AspNetCore.SwaggerGen;
using Swashbuckle.AspNetCore.SwaggerGen;
using Swashbuckle.AspNetCore.SwaggerUI;
using Microsoft.OpenApi.Models;

services.AddSwaggerGen(c =>
            c.SwaggerDoc("v1", new OpenApiInfo { Title = "UnitTest_Mock", Version = "v1" }));
			
			app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "UnitTest_Mock v1"));