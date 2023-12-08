using CvBlog.Shared.Utilities.Results.ComplexTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CvBlog.Shared.Utilities.Results.Abstract
{
    public interface IResult
    {
        // ctor'lar da propertyler veriliyor olacak değiştirilebilir olmayacaklar. o yüzden set kullanmadık.
        public ResultStatus ResultStatus { get; } // ResultStatus.Success // ResultStatus.Error
        public string Message { get; }
        public Exception Exception { get;  }
    }
}
