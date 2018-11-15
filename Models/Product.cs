using System;
using System.Collections.Generic;

namespace ApiDesign.Models
{
    public class Product 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public float UnitPrice { get; set; }
        public int QuantityPerUnit { get; set; }
        public bool Top20 { get; set; } 

        public int SupplierId { get; set; }
        public Supplier Supplier { get; set; }
        
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public ICollection<Photo> Photos { get; set; }
    }
}