using MemoryDb.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace MemoryDb.Persistence.Context;

public class ApiDbContext : DbContext,IApiDbContext
{
    protected override void OnConfiguring
   (DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseInMemoryDatabase(databaseName: "AuthorDb");
    }
    public DbSet<Author> Authors { get; set; }
    public DbSet<Book> Books { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<Author>()
           .HasKey(a => a.Id);

        // Configure Book entity
        builder.Entity<Book>()
            .HasKey(b => b.Id);




        base.OnModelCreating(builder);
    }
}
