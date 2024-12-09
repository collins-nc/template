namespace template.core;

using System.Collections;
using Entities;
using Microsoft.EntityFrameworkCore;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<Users> Users => this.Set<Users>();
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Users>(builder =>
        {
            builder.HasKey(p => p.Id);
            builder.HasData(new List<Users>
            {
                new()
                {
                    Id = 1,
                    Name = "Collins",
                    Email = "collins@gmail.com",
                    Password = "password123"
                },
                new()
                {
                    Id = 2,
                    Name = "Noko",
                    Email = "noko@gmail.com",
                    Password = "password456"
                }

            });
        });

    }
}
