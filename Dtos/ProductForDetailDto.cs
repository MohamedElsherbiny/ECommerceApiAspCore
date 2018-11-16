using System.Collections.Generic;

namespace ApiDesign.Dtos
{
    public class ProductForDetailDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public float UnitPrice { get; set; }
        public int QuantityPerUnit { get; set; }
        public bool Top20 { get; set; } 

        public SupplierForListDto Supplier { get; set; }
        
        public CategoryForListDto Category { get; set; }

        public ICollection<PhotoForListDto> Photos { get; set; }
    }
}