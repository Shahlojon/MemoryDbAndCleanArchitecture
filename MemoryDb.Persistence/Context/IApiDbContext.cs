using MemoryDb.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryDb.Persistence.Context;

public interface IApiDbContext
{
    public DbSet<Author> Authors { get; set; }
    public DbSet<Book> Books { get; set; }

    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}
