﻿using CvBlog.Data.Abstract;
using CvBlog.Entities.Concrete;
using CvBlog.Shared.Data.Concrete.EntityFramework;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CvBlog.Data.Concrete.EntityFramework.Repositories
{
    public class EfExperienceRepository : EfEntityRepositoryBase<Experience>, IExperienceRepository
    {
        public EfExperienceRepository(DbContext context) : base(context)
        {
        }
    }
}