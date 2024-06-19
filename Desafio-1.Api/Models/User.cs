namespace Desafio_1.Api.Models
{
    public class User
    {
        public int Id { get; set; }
        public required string Username { get; set; }
        public required string Password { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
