﻿using CvBlog.Shared.Entities.Abstract;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CvBlog.Entities.Concrete
{
    // KULLANICI ROLÜ
    public class Role : IdentityRole<int>,IEntity
    {
    }
}
