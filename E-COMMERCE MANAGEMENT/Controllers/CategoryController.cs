using E_COMMERCE_MANAGEMENT.Dto;
using E_COMMERCE_MANAGEMENT.MOdels;
using E_COMMERCE_MANAGEMENT.Repos.implemnt;
using E_COMMERCE_MANAGEMENT.Repos.interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace E_COMMERCE_MANAGEMENT.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly IUnitOfWork repo;

        public CategoryController(IUnitOfWork repo)
        {
            this.repo = repo;
        }
        [HttpGet("getall")]

        public async Task<IActionResult> Getall()
        {
            var e = await repo.categoryss.Getall();
            return Ok(e);
        }
        [HttpPost("create")]
        public async Task<IActionResult> Create(categoryDto dto)
        {
            var cat = new Category
            {
                Id = dto.Id,
                Name = dto.Name,
                Description = dto.Description,
            };
            var c = repo.categoryss.Create(cat);
            repo.save();
            return Ok();
        }
      

    }
}
