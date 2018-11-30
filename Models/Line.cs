using ApiDesign.Dtos;

namespace ApiDesign.Models
{
    public class Line
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public ProductForDetailDto Product { get; set; }
    }
}