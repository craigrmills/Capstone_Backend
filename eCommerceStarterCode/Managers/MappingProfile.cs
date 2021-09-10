using AutoMapper;
using BattleSmithAPI.DataTransferObjects;
using BattleSmithAPI.Models;

namespace BattleSmithAPI.Managers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<UserForRegistrationDto, User>();
        }
    }
}
