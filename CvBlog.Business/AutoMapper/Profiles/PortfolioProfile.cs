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
    public class PortfolioProfile : Profile
    {
        public PortfolioProfile()
        {
            CreateMap<PortfolioAddDto, Portfolio>().ForMember(d => d.CreatedDate, opt => opt.MapFrom(x => DateTime.Now));
            CreateMap<PortfolioUpdateDto, Portfolio>().ForMember(d => d.ModifiedDate, opt => opt.MapFrom(x => DateTime.Now));
        }
    }
}
