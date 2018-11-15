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
            CreateMap<List<Product>,ProductForListDto>();
            CreateMap<Supplier,SupplierForListDto>();
            CreateMap<Category,CategoryForListDto>();
            CreateMap<Photo,PhotoForListDto>();
        }
    }
}