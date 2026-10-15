using System;
using System.Collections.Immutable;
using System.Threading.Tasks;
using E_COMMERCE_MANAGEMENT.Dto;
using E_COMMERCE_MANAGEMENT.Repos.interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace E_COMMERCE_MANAGEMENT.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IUnitOfWork repo;

        public ProductController(IUnitOfWork repo)
        {
            this.repo = repo;
        }

        [HttpGet("getpage")]
        public async Task<IActionResult> GetPage(int? id, int size, int num, string sortby)
        {
            var result = await repo.productss.Getpage1Async(id, size, num, sortby);

            var b = result.Select(a => new ProductDto()
            {
Id = a.Id,
Name = a.Name,
Price = a.Price,
StockQuantity = a.StockQuantity,

            });

            return Ok(b);
        }


        [HttpGet("get byid")]
        public async Task<IActionResult> getbyid(int id)
        {
            var e = await repo.productss.GetById(id);
            return Ok(e);   
        }

        [HttpGet("getsec")]
        public async Task<IActionResult> Getsec(int id) {

           var e=repo.productss.secondmostexpensiveexcluding(id);
            return Ok(e);
        
        }
    }

}