using System.Collections.Generic;

namespace ApiDesign.Dtos
{
    public class ProductForAddingDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public float UnitPrice { get; set; }
        public int QuantityPerUnit { get; set; }
        public bool Top20 { get; set; } 

        public int SupplierId { get; set; }
        
        public int CategoryId { get; set; }

        public ICollection<PhotoForListDto> Photos { get; set; } = new List<PhotoForListDto>
        {
            new PhotoForListDto {
                Url = "http://dummyimage.com/188x238.png/cc0000/ffffff",
                Description ="Anogenital herpesviral infection, unspecified",
                IsMain = false
            }
        };
    }
}