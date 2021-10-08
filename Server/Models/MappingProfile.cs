using Api.Models.Resources;
using AutoMapper;

namespace Api.Models
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Account, GetAccountModel>();

            CreateMap<AddAccountModel, Account>()
                .ForMember(dest => dest.Id, source => source.Ignore())
                .ForMember(dest => dest.UserId, source => source.Ignore())
                .ForMember(dest => dest.User, source => source.Ignore());

            CreateMap<UpdateAccountModel, Account>();
        }
    }
}
