using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiDesign.Dtos
{
    public class ProductForUpdateDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public float UnitPrice { get; set; }
        public int QuantityPerUnit { get; set; }
        public bool Top20 { get; set; }

        public int SupplierId { get; set; }

        public int CategoryId { get; set; }
    }
}
