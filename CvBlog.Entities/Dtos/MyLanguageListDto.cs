﻿using CvBlog.Entities.Concrete;
using CvBlog.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CvBlog.Entities.Dtos
{
    public class MyLanguageListDto : DtoGetBase
    {
        public IList<MyLanguage> MyLanguages { get; set; }
    }
}
