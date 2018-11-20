using Microsoft.EntityFrameworkCore;

namespace ApiDesign.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Product> Products { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Photo> Photos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        { 
            modelBuilder.Entity<Category>().HasData(
                new Category{
                        Id = 1,
                        Name = "Technology",
                        Description = "Repair Cisterna Chyli, Percutaneous Approach",
                        ImgUrl = "http://dummyimage.com/244x100.png/cc0000/ffffff"
                    },
                new Category{
                        Id = 2,
                        Name = "Energy",
                        Description = "Reposition Pancreas, Percutaneous Endoscopic Approach",
                        ImgUrl = "http://dummyimage.com/119x188.bmp/ff4444/ffffff"
                     }
            );
            modelBuilder.Entity<Supplier>().HasData(
                new Supplier{
                        Id = 1,
                        CompanyName =  "Centimia",
                        ContactName =  "Codi Kilsby",
                        ContactTitle =  "Assistant Manager",
                        Address =  "638 Sunfield Parkway",
                        City =  "Mintang",
                        PostalCode =  null,
                        Country =  "China",
                        Phone =  "336-490-8728"
                    },
                new Supplier{
                        Id = 2,
                        CompanyName = "Eare",
                        ContactName = "Etienne Kohrt",
                        ContactTitle = "Analyst Programmer",
                        Address = "382 Morning Lane",
                        City = "Ljungby",
                        PostalCode = "341 31",
                        Country = "Sweden",
                        Phone = "157-714-1226"
                     },
                new Supplier{
                        Id = 3,
                        CompanyName = "Zazio",
                        ContactName = "Zedekiah Kinson",
                        ContactTitle = "Operator",
                        Address = "0 Boyd Road",
                        City = "Changjiang",
                        PostalCode = null,
                        Country = "China",
                        Phone = "414-142-9766"
                     },
                new Supplier{
                        Id = 4,
                        CompanyName = "Bubbletube",
                        ContactName = "Kahaleel Teacy",
                        ContactTitle = "Cost Accountant",
                        Address = "477 Bunker Hill Parkway",
                        City = "Shanghu",
                        PostalCode = null,
                        Country = "China",
                        Phone = "519-126-7676"
                     }
            );
            modelBuilder.Entity<Photo>().HasData(
                new Photo { 
                    Id = 1,
                    Url = "https://dummyimage.com/230x230/f2deb5/fff",
                    Description = "Abrasion, unspecified ankle, sequela",
                    IsMain = false,
                    ProductId = 1
                 },
                new Photo { 
                    Id = 2,
                    Url = "https://dummyimage.com/230x230/f2deb5/fff",
                    Description = "Contus/lac cereb, w LOC of unsp duration, init",
                    IsMain = false,
                    ProductId = 1
                 },
                new Photo { 
                    Id = 3,
                    Url = "https://dummyimage.com/230x230/f2deb5/fff",
                    Description = "Nondisp fx of coronoid pro of unsp ulna, 7thD",
                    IsMain = false,
                    ProductId = 2
                 },
                new Photo { 
                    Id = 4,
                    Url = "https://dummyimage.com/230x230/f2deb5/fff",
                    Description = "Lacerat flexor musc/fasc/tend at forarm lv, unsp arm, subs",
                    IsMain = true,
                    ProductId = 2
                 },
                new Photo { 
                    Id = 5,
                    Url = "https://dummyimage.com/230x230/f2deb5/fff",
                    Description = "Pnctr w foreign body of r idx fngr w damage to nail, subs",
                    IsMain = false,
                    ProductId = 3
                 },
                new Photo { 
                    Id = 6,
                    Url = "https://dummyimage.com/230x230/f2deb5/fff",
                    Description = "Prsn brd/alit a car injured in clsn w 2/3-whl mv, sequela",
                    IsMain = true,
                    ProductId = 3
                 },
                new Photo { 
                    Id = 7,
                    Url = "https://dummyimage.com/230x230/f2deb5/fff",
                    Description = "Poisoning by barbiturates, intentional self-harm, init",
                    IsMain = false,
                    ProductId = 4
                 },
                new Photo { 
                    Id = 8,
                    Url = "https://dummyimage.com/230x230/f2deb5/fff",
                    Description = "Disp fx of proximal third of navic bone of l wrist, sequela",
                    IsMain = false,
                    ProductId = 4
                 },
                new Photo { 
                    Id = 9,
                    Url = "https://dummyimage.com/230x230/f2deb5/fff",
                    Description = "Complete traumatic trnsphal amputation of r rng fngr, subs",
                    IsMain = true,
                    ProductId = 5
                 },
                new Photo { 
                    Id = 10,
                    Url = "https://dummyimage.com/230x230/f2deb5/fff",
                    Description = "Other diseases of biliary tract",
                    IsMain = true,
                    ProductId = 5
                 },
                new Photo { 
                    Id = 11,
                    Url = "https://dummyimage.com/230x230/f2deb5/fff",
                    Description = "Oth fracture of unsp talus, subs for fx w malunion",
                    IsMain = false,
                    ProductId = 6
                 },
                new Photo { 
                    Id = 12,
                    Url = "https://dummyimage.com/230x230/f2deb5/fff",
                    Description = "Disp fx of second metatarsal bone, right foot, sequela",
                    IsMain = false,
                    ProductId = 6
                 },
                new Photo { 
                    Id = 13,
                    Url = "https://dummyimage.com/230x230/f2deb5/fff",
                    Description = "Toxic effect of copper and its compounds, undetermined",
                    IsMain = false,
                    ProductId = 7
                 },
                new Photo { 
                    Id = 14,
                    Url = "https://dummyimage.com/230x230/f2deb5/fff",
                    Description = "Unsp malignant neoplasm of skin of and unsp parts of face",
                    IsMain = false,
                    ProductId = 7
                 },
                new Photo { 
                    Id = 15,
                    Url = "https://dummyimage.com/230x230/f2deb5/fff",
                    Description = "Anogenital herpesviral infection, unspecified",
                    IsMain = false,
                    ProductId = 8
                 },
                new Photo { 
                    Id = 16,
                    Url = "https://dummyimage.com/230x230/f2deb5/fff",
                    Description = "Inhalant depend w inhalnt-induce psych disorder w delusions",
                    IsMain = false,
                    ProductId = 8
                 }
                
            );
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Name = "Otomegusa Dashi Konbu",
                    Description = "Nondisp subtrochnt fx unsp femr, subs for clos fx w nonunion",
                    UnitPrice = 39,
                    QuantityPerUnit = 42,
                    Top20 = false,
                    SupplierId = 1,
                    CategoryId = 1
                },
                new Product
                 {
                     Id = 2,
                     Name = "Rice Pilaf, Dry,packageu",
                     Description = "Slip/trip w/o fall d/t step from one level to another, subs",
                     UnitPrice = 22,
                     QuantityPerUnit = 1,
                     Top20 = false,
                     SupplierId = 2,
                     CategoryId = 2
                 },
                new Product
                 {
                     Id = 3,
                     Name = "Mangoes",
                     Description = "Nondisp subtrochnt fx unsp femr, subs for clos fx w nonunion",
                     UnitPrice = 39,
                     QuantityPerUnit = 42,
                     Top20 = false,
                     SupplierId = 1,
                     CategoryId = 2
                 },
                new Product
                  {
                     Id = 4,
                      Name = "Mangoes",
                      Description = "Unspecified injury of ascending colon, initial encounter",
                      UnitPrice = 80,
                      QuantityPerUnit = 10,
                      Top20 = true,
                     SupplierId = 2,
                     CategoryId = 1
                  },
                new Product
                  {
                      Id = 5,
                      Name = "The Pop Shoppe - Grape",
                      Description = "Subluxation of other carpometacarpal joint of right hand",
                      UnitPrice = 14,
                      QuantityPerUnit = 28,
                      Top20 = false,
                     SupplierId = 3,
                     CategoryId = 1
                  },
                new Product
                  {
                      Id = 6,
                      Name = "Stock - Fish",
                      Description = "Other superficial bite of right elbow, initial encounter",
                      UnitPrice = 76,
                      QuantityPerUnit = 78,
                      Top20 = true,
                        SupplierId = 3,
                        CategoryId = 2,
                  },
                new Product
                  {
                      Id = 7,
                      Name = "Juice - Apple, 1.36l",
                      Description = "Burn of unspecified degree of back of right hand",
                      UnitPrice = 60,
                      QuantityPerUnit = 99,
                      Top20 = true,
                      SupplierId = 4,
                      CategoryId = 2,
                  },
                new Product
                  {
                      Id = 8,
                      Name = "Island Oasis - Wildberry",
                      Description = "Poisoning by emetics, assault, subsequent encounter",
                      UnitPrice = 95,
                      QuantityPerUnit = 58,
                      Top20 = false,
                     SupplierId = 4,
                    CategoryId = 1
                  }
            );
        }
        
    }
}