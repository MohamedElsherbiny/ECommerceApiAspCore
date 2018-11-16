using Microsoft.EntityFrameworkCore.Migrations;

namespace Design.Api.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    ImgUrl = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Suppliers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CompanyName = table.Column<string>(nullable: true),
                    ContactName = table.Column<string>(nullable: true),
                    ContactTitle = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    PostalCode = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suppliers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    UnitPrice = table.Column<float>(nullable: false),
                    QuantityPerUnit = table.Column<int>(nullable: false),
                    Top20 = table.Column<bool>(nullable: false),
                    SupplierId = table.Column<int>(nullable: false),
                    CategoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_Suppliers_SupplierId",
                        column: x => x.SupplierId,
                        principalTable: "Suppliers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Photos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Url = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    IsMain = table.Column<bool>(nullable: false),
                    ProductId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Photos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Photos_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "ImgUrl", "Name" },
                values: new object[] { 1, "Repair Cisterna Chyli, Percutaneous Approach", "http://dummyimage.com/244x100.png/cc0000/ffffff", "Technology" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "ImgUrl", "Name" },
                values: new object[] { 2, "Reposition Pancreas, Percutaneous Endoscopic Approach", "http://dummyimage.com/119x188.bmp/ff4444/ffffff", "Energy" });

            migrationBuilder.InsertData(
                table: "Suppliers",
                columns: new[] { "Id", "Address", "City", "CompanyName", "ContactName", "ContactTitle", "Country", "Phone", "PostalCode" },
                values: new object[] { 1, "638 Sunfield Parkway", "Mintang", "Centimia", "Codi Kilsby", "Assistant Manager", "China", "336-490-8728", null });

            migrationBuilder.InsertData(
                table: "Suppliers",
                columns: new[] { "Id", "Address", "City", "CompanyName", "ContactName", "ContactTitle", "Country", "Phone", "PostalCode" },
                values: new object[] { 2, "382 Morning Lane", "Ljungby", "Eare", "Etienne Kohrt", "Analyst Programmer", "Sweden", "157-714-1226", "341 31" });

            migrationBuilder.InsertData(
                table: "Suppliers",
                columns: new[] { "Id", "Address", "City", "CompanyName", "ContactName", "ContactTitle", "Country", "Phone", "PostalCode" },
                values: new object[] { 3, "0 Boyd Road", "Changjiang", "Zazio", "Zedekiah Kinson", "Operator", "China", "414-142-9766", null });

            migrationBuilder.InsertData(
                table: "Suppliers",
                columns: new[] { "Id", "Address", "City", "CompanyName", "ContactName", "ContactTitle", "Country", "Phone", "PostalCode" },
                values: new object[] { 4, "477 Bunker Hill Parkway", "Shanghu", "Bubbletube", "Kahaleel Teacy", "Cost Accountant", "China", "519-126-7676", null });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "Name", "QuantityPerUnit", "SupplierId", "Top20", "UnitPrice" },
                values: new object[] { 1, 1, "Nondisp subtrochnt fx unsp femr, subs for clos fx w nonunion", "Otomegusa Dashi Konbu", 42, 1, false, 39f });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "Name", "QuantityPerUnit", "SupplierId", "Top20", "UnitPrice" },
                values: new object[] { 3, 2, "Nondisp subtrochnt fx unsp femr, subs for clos fx w nonunion", "Mangoes", 42, 1, false, 39f });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "Name", "QuantityPerUnit", "SupplierId", "Top20", "UnitPrice" },
                values: new object[] { 2, 2, "Slip/trip w/o fall d/t step from one level to another, subs", "Rice Pilaf, Dry,packageu", 1, 2, false, 22f });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "Name", "QuantityPerUnit", "SupplierId", "Top20", "UnitPrice" },
                values: new object[] { 4, 1, "Unspecified injury of ascending colon, initial encounter", "Mangoes", 10, 2, true, 80f });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "Name", "QuantityPerUnit", "SupplierId", "Top20", "UnitPrice" },
                values: new object[] { 5, 1, "Subluxation of other carpometacarpal joint of right hand", "The Pop Shoppe - Grape", 28, 3, false, 14f });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "Name", "QuantityPerUnit", "SupplierId", "Top20", "UnitPrice" },
                values: new object[] { 6, 2, "Other superficial bite of right elbow, initial encounter", "Stock - Fish", 78, 3, true, 76f });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "Name", "QuantityPerUnit", "SupplierId", "Top20", "UnitPrice" },
                values: new object[] { 7, 2, "Burn of unspecified degree of back of right hand", "Juice - Apple, 1.36l", 99, 4, true, 60f });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "Name", "QuantityPerUnit", "SupplierId", "Top20", "UnitPrice" },
                values: new object[] { 8, 1, "Poisoning by emetics, assault, subsequent encounter", "Island Oasis - Wildberry", 58, 4, false, 95f });

            migrationBuilder.InsertData(
                table: "Photos",
                columns: new[] { "Id", "Description", "IsMain", "ProductId", "Url" },
                values: new object[] { 1, "Abrasion, unspecified ankle, sequela", false, 1, "http://dummyimage.com/208x161.bmp/ff4444/ffffff" });

            migrationBuilder.InsertData(
                table: "Photos",
                columns: new[] { "Id", "Description", "IsMain", "ProductId", "Url" },
                values: new object[] { 2, "Contus/lac cereb, w LOC of unsp duration, init", false, 1, "http://dummyimage.com/243x128.png/cc0000/ffffff" });

            migrationBuilder.InsertData(
                table: "Photos",
                columns: new[] { "Id", "Description", "IsMain", "ProductId", "Url" },
                values: new object[] { 5, "Pnctr w foreign body of r idx fngr w damage to nail, subs", false, 3, "http://dummyimage.com/122x141.png/cc0000/ffffff" });

            migrationBuilder.InsertData(
                table: "Photos",
                columns: new[] { "Id", "Description", "IsMain", "ProductId", "Url" },
                values: new object[] { 6, "Prsn brd/alit a car injured in clsn w 2/3-whl mv, sequela", true, 3, "http://dummyimage.com/199x148.png/dddddd/000000" });

            migrationBuilder.InsertData(
                table: "Photos",
                columns: new[] { "Id", "Description", "IsMain", "ProductId", "Url" },
                values: new object[] { 3, "Nondisp fx of coronoid pro of unsp ulna, 7thD", false, 2, "http://dummyimage.com/201x214.bmp/5fa2dd/ffffff" });

            migrationBuilder.InsertData(
                table: "Photos",
                columns: new[] { "Id", "Description", "IsMain", "ProductId", "Url" },
                values: new object[] { 4, "Lacerat flexor musc/fasc/tend at forarm lv, unsp arm, subs", true, 2, "http://dummyimage.com/183x131.jpg/5fa2dd/ffffff" });

            migrationBuilder.InsertData(
                table: "Photos",
                columns: new[] { "Id", "Description", "IsMain", "ProductId", "Url" },
                values: new object[] { 7, "Poisoning by barbiturates, intentional self-harm, init", false, 4, "http://dummyimage.com/107x246.jpg/5fa2dd/ffffff" });

            migrationBuilder.InsertData(
                table: "Photos",
                columns: new[] { "Id", "Description", "IsMain", "ProductId", "Url" },
                values: new object[] { 8, "Disp fx of proximal third of navic bone of l wrist, sequela", false, 4, "http://dummyimage.com/165x158.jpg/ff4444/ffffff" });

            migrationBuilder.InsertData(
                table: "Photos",
                columns: new[] { "Id", "Description", "IsMain", "ProductId", "Url" },
                values: new object[] { 9, "Complete traumatic trnsphal amputation of r rng fngr, subs", true, 5, "http://dummyimage.com/240x231.bmp/dddddd/000000" });

            migrationBuilder.InsertData(
                table: "Photos",
                columns: new[] { "Id", "Description", "IsMain", "ProductId", "Url" },
                values: new object[] { 10, "Other diseases of biliary tract", true, 5, "http://dummyimage.com/223x198.bmp/ff4444/ffffff" });

            migrationBuilder.InsertData(
                table: "Photos",
                columns: new[] { "Id", "Description", "IsMain", "ProductId", "Url" },
                values: new object[] { 11, "Oth fracture of unsp talus, subs for fx w malunion", false, 6, "http://dummyimage.com/188x201.jpg/5fa2dd/ffffff" });

            migrationBuilder.InsertData(
                table: "Photos",
                columns: new[] { "Id", "Description", "IsMain", "ProductId", "Url" },
                values: new object[] { 12, "Disp fx of second metatarsal bone, right foot, sequela", false, 6, "http://dummyimage.com/163x242.png/dddddd/000000" });

            migrationBuilder.InsertData(
                table: "Photos",
                columns: new[] { "Id", "Description", "IsMain", "ProductId", "Url" },
                values: new object[] { 13, "Toxic effect of copper and its compounds, undetermined", false, 7, "http://dummyimage.com/119x127.bmp/cc0000/ffffff" });

            migrationBuilder.InsertData(
                table: "Photos",
                columns: new[] { "Id", "Description", "IsMain", "ProductId", "Url" },
                values: new object[] { 14, "Unsp malignant neoplasm of skin of and unsp parts of face", false, 7, "http://dummyimage.com/188x149.png/5fa2dd/ffffff" });

            migrationBuilder.InsertData(
                table: "Photos",
                columns: new[] { "Id", "Description", "IsMain", "ProductId", "Url" },
                values: new object[] { 15, "Anogenital herpesviral infection, unspecified", false, 8, "http://dummyimage.com/188x238.png/cc0000/ffffff" });

            migrationBuilder.InsertData(
                table: "Photos",
                columns: new[] { "Id", "Description", "IsMain", "ProductId", "Url" },
                values: new object[] { 16, "Inhalant depend w inhalnt-induce psych disorder w delusions", false, 8, "http://dummyimage.com/240x188.png/ff4444/ffffff" });

            migrationBuilder.CreateIndex(
                name: "IX_Photos_ProductId",
                table: "Photos",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_SupplierId",
                table: "Products",
                column: "SupplierId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Photos");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Suppliers");
        }
    }
}
