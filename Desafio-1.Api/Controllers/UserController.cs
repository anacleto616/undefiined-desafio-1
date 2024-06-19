using Desafio_1.Api.Data;
using Desafio_1.Api.Dtos;
using Desafio_1.Api.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Desafio_1.Api.Controllers
{
    [ApiController]
    [Route(template: "api/v1")]
    public class UserController : ControllerBase
    {
        [HttpPost(template: "users")]
        public async Task<ActionResult> AddAsync(
            [FromServices] AppDbContext context,
            [FromBody] UserDto userDto
        )
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var hashedPassword = BCrypt.Net.BCrypt.HashPassword(userDto.Password);
            var user = new User { Username = userDto.Username, Password = hashedPassword };

            try
            {
                await context.Users.AddAsync(user);
                await context.SaveChangesAsync();
                return Created();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut(template: "users/{id}")]
        [Authorize]
        public async Task<ActionResult> UpdateAsync(
            [FromServices] AppDbContext context,
            [FromBody] UserDto userDto,
            [FromRoute] int id
        )
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var existingUser = await context.Users.FindAsync(id);

            if (existingUser is null)
                return NotFound();

            var hashedPassword = BCrypt.Net.BCrypt.HashPassword(userDto.Password);

            try
            {
                existingUser.Username = userDto.Username;
                existingUser.Password = hashedPassword;
                context.Entry(existingUser).CurrentValues.SetValues(existingUser);
                await context.SaveChangesAsync();
                return NoContent();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
