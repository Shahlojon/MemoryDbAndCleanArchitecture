using MemoryDb.Domain.Entities;
using MemoryDb.Domain.Stores;
using MemoryDb.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using System;

namespace MemoryDb.Persistence.Repository;

public class AuthorRepository : IAuthorStore
{
    private readonly IApiDbContext _context;

    public AuthorRepository(IApiDbContext context)
    {
        _context = context;
        CancellationToken cancellationToken = new CancellationToken();
        var authors = new List<Author>
                {
                new Author
                {
                    FirstName ="Joydip",
                    LastName ="Kanjilal",
                       Books = new List<Book>()
                    {
                        new Book { Title = "Mastering C# 8.0"},
                        new Book { Title = "Entity Framework Tutorial"},
                        new Book { Title = "ASP.NET 4.0 Programming"}
                    }
                },
                new Author
                {
                    FirstName ="Yashavanth",
                    LastName ="Kanetkar",
                    Books = new List<Book>()
                    {
                        new Book { Title = "Let us C"},
                        new Book { Title = "Let us C++"},
                        new Book { Title = "Let us C#"}
                    }
                }
                };
            _context.Authors.AddRange(authors);
            _context.SaveChangesAsync(cancellationToken);
    }
    public async Task<List<Author>> GetAuthorsAsync()
    {
        var list = await _context.Authors
              .Include(a => a.Books)
              .ToListAsync();
        return list;
    }
}
