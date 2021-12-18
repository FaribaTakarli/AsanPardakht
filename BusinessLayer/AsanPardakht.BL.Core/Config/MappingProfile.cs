using AsanPardakht.CL.DTOs;
using AsanPardakht.CL.Entities;
using AutoMapper;

namespace AsanPardakht.BL.Core.Config
{
 
        public class MappingProfile : Profile
        {
            public MappingProfile()
            {

            CreateMap<User, UserDTO_response>().ReverseMap();
            CreateMap<UserDTO_response, User>().ReverseMap();
            CreateMap<User, UserDTO_request>().ReverseMap();
            CreateMap<UserDTO_request, User>().ReverseMap();

            CreateMap<UserAddress, UserAddressDTO_response>().ReverseMap();
            CreateMap<UserAddressDTO_response, UserAddress>().ReverseMap();
            CreateMap<UserAddress, UserAddressDTO_request>().ReverseMap();
            CreateMap<UserAddressDTO_request, UserAddress>().ReverseMap();


        }
        
    }
}
