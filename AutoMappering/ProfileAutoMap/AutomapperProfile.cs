

using AutoMapper;
using AutoMappering.DTOs;
using AutoMappering.Models;

namespace AutoMappering.ProfileAutoMap
{
    public class AutomapperProfile:Profile
    {
        public AutomapperProfile()
        {
            CreateMap<UserVewModel, User>().ReverseMap();
        }
    }
}
