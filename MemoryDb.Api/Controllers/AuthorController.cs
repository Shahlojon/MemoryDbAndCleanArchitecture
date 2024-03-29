using MemoryDb.Application.Services;
using MemoryDb.Domain.Entities;
using MemoryDb.Persistence.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MemoryDb.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorController : ControllerBase
    {
        readonly IAuthorService _authorService;
        public AuthorController(IAuthorService authorService)
        {
            _authorService = authorService;
        }
        [HttpGet]
        public async Task<ActionResult<List<Author>>> GetList()
        {
            return Ok(_authorService.GetList());
        }
    }
}
