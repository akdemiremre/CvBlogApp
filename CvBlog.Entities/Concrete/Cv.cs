using CvBlog.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CvBlog.Entities.Concrete
{
    // ÖZGEÇMİŞ
    public class Cv : EntityBase,IEntity
    {
        public string Description { get; set; }
        public string HeaderImage { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public ICollection<Customer> Customers { get; set; }
        public ICollection<Education> Educations { get; set; }
        public ICollection<Experience> Experiences { get; set; }
        public ICollection<Skill> Skills { get; set; }
        public ICollection<SocialMedia> SocialMedias { get; set; }
        public ICollection<MyLanguage> MyLanguages { get; set; }
    }
}
