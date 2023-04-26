

using AutoMapper;
using AutoMappering.DTOs;
using AutoMappering.Models;

namespace AutoMappering.ProfileAutoMap
{
    public class AutomapperProfile:Profile
    {
        public AutomapperProfile()
        {
            CreateMap<UserVewModel, User>()
                // we use ForMember when we have Diffrent name for Binding
                .ForMember(des => des.Usrename, i => i.MapFrom(src => src.Usrename))
                .ForMember(des => des.Age, i =>
                {
                    i.PreCondition(src => src.Age > 21);
                    i.MapFrom(src => src.Age);
                })
                .ReverseMap();
        }
    }
}
