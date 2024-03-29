using MemoryDb.Domain.Entities;

namespace MemoryDb.Application.Services;

public interface IAuthorService
{
    Task<List<Author>> GetList();
}