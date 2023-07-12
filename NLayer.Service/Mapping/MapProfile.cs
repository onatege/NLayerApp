﻿using AutoMapper;
using NLayer.Core.DTOs;
using NLayer.Core;
using System.Net.Sockets;

namespace NLayer.Service.Mapping
{
    public class MapProfile: Profile
    {
        public MapProfile()
        {
            CreateMap<Product, ProductDto>().ReverseMap();
            CreateMap<Category, CategoryDto>().ReverseMap();
            CreateMap<ProductFeature, ProductFeatureDto>().ReverseMap();
            CreateMap<ProductUpdateDto, Product>();
        }

    }
}
