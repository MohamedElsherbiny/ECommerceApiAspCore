using System.Collections.Generic;
using ApiDesign.Dtos;
using ApiDesign.Models;
using AutoMapper;

namespace ApiDesign.Extentions
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<List<User>,UserForListDto>();
            CreateMap<User,UserForListDto>();

            CreateMap<List<Product>,ProductForListDto>();
            CreateMap<Product,ProductForDetailDto>();
            CreateMap<ProductForAddingDto,Product>();
            CreateMap<ProductForUpdateDto,Product>();

            CreateMap<Supplier,SupplierForListDto>();

            CreateMap<Category,CategoryForListDto>();

            CreateMap<Photo,PhotoForListDto>();
            CreateMap<PhotoForListDto,Photo>();
            
        }
    }
}