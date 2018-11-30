﻿// <auto-generated />
using System;
using ApiDesign.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Design.Api.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024");

            modelBuilder.Entity("ApiDesign.Dtos.CategoryForListDto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("ImgUrl");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("CategoryForListDto");
                });

            modelBuilder.Entity("ApiDesign.Dtos.PhotoForListDto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<bool>("IsMain");

                    b.Property<int?>("ProductForDetailDtoId");

                    b.Property<string>("Url");

                    b.HasKey("Id");

                    b.HasIndex("ProductForDetailDtoId");

                    b.ToTable("PhotoForListDto");
                });

            modelBuilder.Entity("ApiDesign.Dtos.ProductForDetailDto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("CategoryId");

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.Property<int>("QuantityPerUnit");

                    b.Property<int?>("SupplierId");

                    b.Property<bool>("Top20");

                    b.Property<float>("UnitPrice");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("SupplierId");

                    b.ToTable("ProductForDetailDto");
                });

            modelBuilder.Entity("ApiDesign.Dtos.SupplierForListDto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<string>("City");

                    b.Property<string>("CompanyName");

                    b.Property<string>("ContactName");

                    b.Property<string>("ContactTitle");

                    b.Property<string>("Country");

                    b.Property<string>("Phone");

                    b.Property<string>("PostalCode");

                    b.HasKey("Id");

                    b.ToTable("SupplierForListDto");
                });

            modelBuilder.Entity("ApiDesign.Models.Cart", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("CartPrice");

                    b.Property<double>("ItemCount");

                    b.HasKey("Id");

                    b.ToTable("Cart");
                });

            modelBuilder.Entity("ApiDesign.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("ImgUrl");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new { Id = 1, Description = "Repair Cisterna Chyli, Percutaneous Approach", ImgUrl = "http://dummyimage.com/244x100.png/cc0000/ffffff", Name = "Technology" },
                        new { Id = 2, Description = "Reposition Pancreas, Percutaneous Endoscopic Approach", ImgUrl = "http://dummyimage.com/119x188.bmp/ff4444/ffffff", Name = "Energy" }
                    );
                });

            modelBuilder.Entity("ApiDesign.Models.Line", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("CartId");

                    b.Property<int?>("ProductId");

                    b.Property<int>("Quantity");

                    b.HasKey("Id");

                    b.HasIndex("CartId");

                    b.HasIndex("ProductId");

                    b.ToTable("Line");
                });

            modelBuilder.Entity("ApiDesign.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("CartId");

                    b.Property<string>("City");

                    b.Property<string>("Country");

                    b.Property<string>("Name");

                    b.Property<string>("State");

                    b.Property<string>("Zip");

                    b.HasKey("Id");

                    b.HasIndex("CartId");

                    b.ToTable("Orders");

                    b.HasData(
                        new { Id = 1, City = "cairo", Country = "egypt", Name = "order one", State = "hello state", Zip = "order zip code " }
                    );
                });

            modelBuilder.Entity("ApiDesign.Models.Photo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<bool>("IsMain");

                    b.Property<int>("ProductId");

                    b.Property<string>("Url");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("Photos");

                    b.HasData(
                        new { Id = 1, Description = "Abrasion, unspecified ankle, sequela", IsMain = false, ProductId = 1, Url = "https://dummyimage.com/230x230/f2deb5/fff" },
                        new { Id = 2, Description = "Contus/lac cereb, w LOC of unsp duration, init", IsMain = false, ProductId = 1, Url = "https://dummyimage.com/230x230/f2deb5/fff" },
                        new { Id = 3, Description = "Nondisp fx of coronoid pro of unsp ulna, 7thD", IsMain = false, ProductId = 2, Url = "https://dummyimage.com/230x230/f2deb5/fff" },
                        new { Id = 4, Description = "Lacerat flexor musc/fasc/tend at forarm lv, unsp arm, subs", IsMain = true, ProductId = 2, Url = "https://dummyimage.com/230x230/f2deb5/fff" },
                        new { Id = 5, Description = "Pnctr w foreign body of r idx fngr w damage to nail, subs", IsMain = false, ProductId = 3, Url = "https://dummyimage.com/230x230/f2deb5/fff" },
                        new { Id = 6, Description = "Prsn brd/alit a car injured in clsn w 2/3-whl mv, sequela", IsMain = true, ProductId = 3, Url = "https://dummyimage.com/230x230/f2deb5/fff" },
                        new { Id = 7, Description = "Poisoning by barbiturates, intentional self-harm, init", IsMain = false, ProductId = 4, Url = "https://dummyimage.com/230x230/f2deb5/fff" },
                        new { Id = 8, Description = "Disp fx of proximal third of navic bone of l wrist, sequela", IsMain = false, ProductId = 4, Url = "https://dummyimage.com/230x230/f2deb5/fff" },
                        new { Id = 9, Description = "Complete traumatic trnsphal amputation of r rng fngr, subs", IsMain = true, ProductId = 5, Url = "https://dummyimage.com/230x230/f2deb5/fff" },
                        new { Id = 10, Description = "Other diseases of biliary tract", IsMain = true, ProductId = 5, Url = "https://dummyimage.com/230x230/f2deb5/fff" },
                        new { Id = 11, Description = "Oth fracture of unsp talus, subs for fx w malunion", IsMain = false, ProductId = 6, Url = "https://dummyimage.com/230x230/f2deb5/fff" },
                        new { Id = 12, Description = "Disp fx of second metatarsal bone, right foot, sequela", IsMain = false, ProductId = 6, Url = "https://dummyimage.com/230x230/f2deb5/fff" },
                        new { Id = 13, Description = "Toxic effect of copper and its compounds, undetermined", IsMain = false, ProductId = 7, Url = "https://dummyimage.com/230x230/f2deb5/fff" },
                        new { Id = 14, Description = "Unsp malignant neoplasm of skin of and unsp parts of face", IsMain = false, ProductId = 7, Url = "https://dummyimage.com/230x230/f2deb5/fff" },
                        new { Id = 15, Description = "Anogenital herpesviral infection, unspecified", IsMain = false, ProductId = 8, Url = "https://dummyimage.com/230x230/f2deb5/fff" },
                        new { Id = 16, Description = "Inhalant depend w inhalnt-induce psych disorder w delusions", IsMain = false, ProductId = 8, Url = "https://dummyimage.com/230x230/f2deb5/fff" }
                    );
                });

            modelBuilder.Entity("ApiDesign.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CategoryId");

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.Property<int>("QuantityPerUnit");

                    b.Property<int>("SupplierId");

                    b.Property<bool>("Top20");

                    b.Property<float>("UnitPrice");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("SupplierId");

                    b.ToTable("Products");

                    b.HasData(
                        new { Id = 1, CategoryId = 1, Description = "Nondisp subtrochnt fx unsp femr, subs for clos fx w nonunion", Name = "Otomegusa Dashi Konbu", QuantityPerUnit = 42, SupplierId = 1, Top20 = false, UnitPrice = 39f },
                        new { Id = 2, CategoryId = 2, Description = "Slip/trip w/o fall d/t step from one level to another, subs", Name = "Rice Pilaf, Dry,packageu", QuantityPerUnit = 1, SupplierId = 2, Top20 = false, UnitPrice = 22f },
                        new { Id = 3, CategoryId = 2, Description = "Nondisp subtrochnt fx unsp femr, subs for clos fx w nonunion", Name = "Mangoes", QuantityPerUnit = 42, SupplierId = 1, Top20 = false, UnitPrice = 39f },
                        new { Id = 4, CategoryId = 1, Description = "Unspecified injury of ascending colon, initial encounter", Name = "Mangoes", QuantityPerUnit = 10, SupplierId = 2, Top20 = true, UnitPrice = 80f },
                        new { Id = 5, CategoryId = 1, Description = "Subluxation of other carpometacarpal joint of right hand", Name = "The Pop Shoppe - Grape", QuantityPerUnit = 28, SupplierId = 3, Top20 = false, UnitPrice = 14f },
                        new { Id = 6, CategoryId = 2, Description = "Other superficial bite of right elbow, initial encounter", Name = "Stock - Fish", QuantityPerUnit = 78, SupplierId = 3, Top20 = true, UnitPrice = 76f },
                        new { Id = 7, CategoryId = 2, Description = "Burn of unspecified degree of back of right hand", Name = "Juice - Apple, 1.36l", QuantityPerUnit = 99, SupplierId = 4, Top20 = true, UnitPrice = 60f },
                        new { Id = 8, CategoryId = 1, Description = "Poisoning by emetics, assault, subsequent encounter", Name = "Island Oasis - Wildberry", QuantityPerUnit = 58, SupplierId = 4, Top20 = false, UnitPrice = 95f }
                    );
                });

            modelBuilder.Entity("ApiDesign.Models.Supplier", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<string>("City");

                    b.Property<string>("CompanyName");

                    b.Property<string>("ContactName");

                    b.Property<string>("ContactTitle");

                    b.Property<string>("Country");

                    b.Property<string>("Phone");

                    b.Property<string>("PostalCode");

                    b.HasKey("Id");

                    b.ToTable("Suppliers");

                    b.HasData(
                        new { Id = 1, Address = "638 Sunfield Parkway", City = "Mintang", CompanyName = "Centimia", ContactName = "Codi Kilsby", ContactTitle = "Assistant Manager", Country = "China", Phone = "336-490-8728" },
                        new { Id = 2, Address = "382 Morning Lane", City = "Ljungby", CompanyName = "Eare", ContactName = "Etienne Kohrt", ContactTitle = "Analyst Programmer", Country = "Sweden", Phone = "157-714-1226", PostalCode = "341 31" },
                        new { Id = 3, Address = "0 Boyd Road", City = "Changjiang", CompanyName = "Zazio", ContactName = "Zedekiah Kinson", ContactTitle = "Operator", Country = "China", Phone = "414-142-9766" },
                        new { Id = 4, Address = "477 Bunker Hill Parkway", City = "Shanghu", CompanyName = "Bubbletube", ContactName = "Kahaleel Teacy", ContactTitle = "Cost Accountant", Country = "China", Phone = "519-126-7676" }
                    );
                });

            modelBuilder.Entity("ApiDesign.Dtos.PhotoForListDto", b =>
                {
                    b.HasOne("ApiDesign.Dtos.ProductForDetailDto")
                        .WithMany("Photos")
                        .HasForeignKey("ProductForDetailDtoId");
                });

            modelBuilder.Entity("ApiDesign.Dtos.ProductForDetailDto", b =>
                {
                    b.HasOne("ApiDesign.Dtos.CategoryForListDto", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId");

                    b.HasOne("ApiDesign.Dtos.SupplierForListDto", "Supplier")
                        .WithMany()
                        .HasForeignKey("SupplierId");
                });

            modelBuilder.Entity("ApiDesign.Models.Line", b =>
                {
                    b.HasOne("ApiDesign.Models.Cart")
                        .WithMany("Lines")
                        .HasForeignKey("CartId");

                    b.HasOne("ApiDesign.Dtos.ProductForDetailDto", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId");
                });

            modelBuilder.Entity("ApiDesign.Models.Order", b =>
                {
                    b.HasOne("ApiDesign.Models.Cart", "Cart")
                        .WithMany()
                        .HasForeignKey("CartId");
                });

            modelBuilder.Entity("ApiDesign.Models.Photo", b =>
                {
                    b.HasOne("ApiDesign.Models.Product", "Product")
                        .WithMany("Photos")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ApiDesign.Models.Product", b =>
                {
                    b.HasOne("ApiDesign.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ApiDesign.Models.Supplier", "Supplier")
                        .WithMany("Products")
                        .HasForeignKey("SupplierId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
