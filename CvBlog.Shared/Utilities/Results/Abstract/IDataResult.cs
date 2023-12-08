using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CvBlog.Shared.Utilities.Results.Abstract
{
    // <out T> => Sadece T değilde out T şeklinde kullanmamızın sebebi : hem Entity hem Ilist hem de IEnumarable şeklinde kullanabilmek
    public interface IDataResult<T>:IResult
    {
        // 1.kullanım -> new DataResult<Category>(ResultStatus.Success,category);
        // 2.kullanım -> new DataResult<IList<Category>>(ResultStatus.Success,categoryList);
        public T Data { get; }
    }
}
