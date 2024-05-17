using ATEC_API_Sample.Data.DTO.SocialMediaDTO;
using ATEC_API_Sample.DomainModels.SocialMedia;
using AutoMapper;

namespace ATEC_API_Sample.Data.MappingProfile
{
    public class SocialMediaMappingProfile : Profile
    {
        public SocialMediaMappingProfile()
        {
            CreateMap<User, UserDTO>().ReverseMap();

            CreateMap<Post, PostDTO>().ReverseMap();

            CreateMap<Comment, CommentDTO>().ReverseMap();
        }
    }
}
