﻿using AutoMapper;
using NinjaHive.Contract.Models;
using NinjaHive.Domain;

namespace NinjaHive.BusinessLayer
{
    public class AutoMapperConfiguration
    {
        public static void Configure()
        {
            Mapper.CreateMap<GameItemEntity, GameItemModel>();
            Mapper.CreateMap<CategoryEntity, CategoryModel>();
        }
    };
}
