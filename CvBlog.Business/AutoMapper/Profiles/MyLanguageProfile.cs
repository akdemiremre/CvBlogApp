using AutoMapper;
using CvBlog.Entities.Concrete;
using CvBlog.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CvBlog.Services.AutoMapper.Profiles
{
    public class MyLanguageProfile : Profile
    {
        public MyLanguageProfile()
        {
            CreateMap<MyLanguageAddDto, MyLanguage>().ForMember(d => d.CreatedDate, opt => opt.MapFrom(x => DateTime.Now));
            CreateMap<MyLanguageUpdateDto, MyLanguage>().ForMember(d => d.ModifiedDate, opt => opt.MapFrom(x => DateTime.Now));
        }
    }
}
