using MemoryDb.Domain.Entities;
using MemoryDb.Domain.Stores;

namespace MemoryDb.Application.Services;

public class AuthorService:IAuthorService
{
    private readonly IAuthorStore _authorStore;

    public AuthorService(IAuthorStore authorStore)
    {
        _authorStore = authorStore;
    }

    public async Task<List<Author>> GetList()
    {
        return await _authorStore.GetAuthorsAsync();
    }
}
