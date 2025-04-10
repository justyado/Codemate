using Codemate.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Codemate.Infrastructure.Data;

public class ApplicationDbContext(IConfiguration configuration) : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql(configuration.GetConnectionString("Database"));
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        
    }
}