using CvBlog.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CvBlog.Entities.Concrete
{
    // EĞİTİM BİLGİLERİM
    public class Education : EntityBase,IEntity
    {
        public int? CvId { get; set; }  // Foreign Key
        public Cv Cv { get; set; }     // Navigation Property
        public int? EducationLevelId { get; set; }
        public EducationLevel EducationLevel { get; set; } // NavigationProperty
        public string SchoolName { get; set; }
        public string DateRange { get; set; }
        public string Description { get; set; }
    }
}
