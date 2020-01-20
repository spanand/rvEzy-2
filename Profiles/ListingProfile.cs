using Api.Dto;
using AutoMapper;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Profiles
{
    public class ListingProfile : Profile
    {
        public ListingProfile()
        {
            CreateMap<Listing, ListingDto>()
                .ReverseMap();
        }
    }
}
