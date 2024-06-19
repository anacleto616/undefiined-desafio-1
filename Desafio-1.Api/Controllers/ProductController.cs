using Desafio_1.Api.Data;
using Desafio_1.Api.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Desafio_1.Api.Controllers
{
    [ApiController]
    [Route(template: "api/v1")]
    [Authorize]
    public class ProductController : ControllerBase
    {
        [HttpGet(template: "products")]
        public async Task<ActionResult<IEnumerable<Product>>> GetAsync(
            [FromServices] AppDbContext context
        )
        {
            var products = await context.Products.AsNoTracking().ToListAsync();

            return Ok(products);
        }

        [HttpGet(template: "products/{id}")]
        public async Task<ActionResult> GetByIdAsync(
            [FromServices] AppDbContext context,
            [FromRoute] int id
        )
        {
            var product = await context.Products.FindAsync(id);

            return product == null ? NotFound() : Ok(product);
        }
    }
}
