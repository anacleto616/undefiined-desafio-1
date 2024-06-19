using System.ComponentModel.DataAnnotations;

namespace Desafio_1.Api.Dtos
{
    public record UserDto(
        [Required] [StringLength(50)] string Username,
        [Required] string Password
    );
}
