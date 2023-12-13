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
    public class ArticleProfile:Profile
    {
        public ArticleProfile()
        {
            // 1. parametre (source) -> neyi dönüştüreceğimiz 
            // 2. parametre (destination) -> neye dönüştüreceğimiz
            // ForMember ile içerisindeki bir property ile ilgili işlem yapacağımızı belirtiyoruz.
            // Destinationdaki createdDate için işlem yapıcağımızı belirttik.
            // Opt ile yapıcağımız ayarı(createdDate e güncel tarihi vermek) belirttik.
            CreateMap<ArticleAddDto, Article>().ForMember(d => d.CreatedDate, opt => opt.MapFrom(x => DateTime.Now));
            CreateMap<ArticleUpdateDto, Article>().ForMember(d => d.ModifiedDate, opt => opt.MapFrom(x => DateTime.Now));
        }
    }
}
