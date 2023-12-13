using CvBlog.Entities.Concrete;
using CvBlog.Shared.Entities.Abstract;
using CvBlog.Shared.Utilities.Results.ComplexTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CvBlog.Entities.Dtos
{
    public class ArticleDto : DtoGetBase
    {
        public Article  Article { get; set; }
    }
}
