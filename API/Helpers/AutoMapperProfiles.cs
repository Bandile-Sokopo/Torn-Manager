using API.Dtos;
using API.DTOs;
using API.Entities;
using AutoMapper;

namespace API.Helpers
{
    public class AutoMapperProfiles: Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<User, MemberDto>().
                ForMember(dest => dest.PhotoUrl, opt => opt.MapFrom(src => src.photo.Url));
            CreateMap<Photo, PhotoDto>();
        }
    }
}
