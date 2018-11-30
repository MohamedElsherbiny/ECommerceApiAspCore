namespace ApiDesign.Models
{
    public class Cart
    {
        public int Id { get; set; }
        public double CartPrice { get; set; }
        public double ItemCount { get; set; }
        public Line[] Lines { get; set; }
    }
}