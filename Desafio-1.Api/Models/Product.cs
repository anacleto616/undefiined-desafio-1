namespace Desafio_1.Api.Models
{
    public class Product
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public decimal Price { get; set; }
        public int QuantityStock { get; set; }
    }
}
