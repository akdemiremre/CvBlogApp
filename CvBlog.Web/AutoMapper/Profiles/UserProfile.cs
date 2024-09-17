using AutoMapper;
using CvBlog.Entities.Concrete;
using CvBlog.Entities.Dtos;

namespace CvBlog.Web.AutoMapper.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<UserAddDto, User>();
            CreateMap<User, UserUpdateDto>();
            CreateMap<UserUpdateDto, User>();
            CreateMap<User, UserProfilePersonalUpdateDto>();
            CreateMap<UserProfilePersonalUpdateDto,User>();
            CreateMap<User, UserProfilePasswordUpdateDto>().ReverseMap();// Reverse diyerek tersinede map işlemini yaptırabilmiş oluyoruz.
            //CreateMap<UserProfilePasswordUpdateDto, User>();
        }
    }
}
