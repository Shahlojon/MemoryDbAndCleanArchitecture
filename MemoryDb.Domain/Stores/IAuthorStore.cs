using MemoryDb.Domain.Entities;

namespace MemoryDb.Domain.Stores;

public interface IAuthorStore
{
    Task<List<Author>> GetAuthorsAsync();
}
