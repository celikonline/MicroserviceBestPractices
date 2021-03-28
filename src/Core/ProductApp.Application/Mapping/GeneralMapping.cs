using ProdutApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using ProductApp.Application.Dto;
using ProductApp.Application.Features.Command.CreateProduct;

namespace ProductApp.Application.Mapping
{
    public class GeneralMapping : Profile
    {
        public GeneralMapping()
        {
            CreateMap<Product, ProductViewDto>().ReverseMap();
            CreateMap<Product, CreateProductCommand>().ReverseMap();

            CreateMap<Catalog, CatalogViewDto>().ReverseMap();
            CreateMap<Catalog, CreateCatalogCommand>().ReverseMap();
        }
    }
}
