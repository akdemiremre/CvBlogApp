using CvBlog.Shared.Utilities.Results.ComplexTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CvBlog.Shared.Entities.Abstract
{
    public abstract class DtoGetBase
    {
        // Dto yu view a taşıdık tablo da göstericeğimizi varsayalım. ResultStatus -> success,error durumlarına göre farklı viewlar gösterebilmemizi sağlar.

        public virtual ResultStatus ResultStatus { get; set; }
    }
}
