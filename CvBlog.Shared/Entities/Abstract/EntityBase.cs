﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CvBlog.Shared.Entities.Abstract
{
    // Sadece türetilecek classlar da kullanamabilmek için abstract tanımladık
    public abstract class EntityBase
    {
        public virtual int Id { get; set; }
        // sonradan değişiklik yapabilmek/ezebilmek yani override edebilmek için virtual tanımladık.
        public virtual DateTime CreatedDate { get; set; } = DateTime.Now; // override CreatedDate = new DateTime(2020/01/01); 
        public virtual DateTime ModifiedDate { get; set; } = DateTime.Now;
        public virtual bool IsDeleted { get; set; } = false;
        public virtual bool IsActive { get; set; } = true;
        public virtual string CreatedByName { get; set; } = "Admin";
        public virtual string ModifiedByName { get; set; } = "Admin";
        public virtual string Note { get; set; } // Herhangi bir not ekleyebilme ihtiyacı için kullanıldı.
    }
}
