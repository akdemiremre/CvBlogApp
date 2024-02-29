using CvBlog.Entities.Dtos;
using CvBlog.Shared.Utilities.Results.Abstract;
using CvBlog.Shared.Utilities.Results.ComplexTypes;
using CvBlog.Shared.Utilities.Results.Concrete;

namespace CvBlog.Web.Areas.Admin.Models
{
    public class CategoryViewModel
    {
        public IDataResult<CategoryListDto> Result { get; set; }
        public DataTable CategoryDataTable { get; set; }
        public ResultStatus ResultStatus { get; set; }
        public class DataTable
        {
            public string[][] Data { get; set; }
            public int RecordsTotal { get; set; } = 0;
            public int RecordsFiltered { get; set; } = 0;
            //public int PageCount { get; set; } = 0;
            //public int Page { get; set; } = 0;
            public int Draw { get; set; } = 1;
            public int Start { get; set; } = 0;
            //public int Length { get; set; } = 10;
        }
        public class Parameter
        {
            public int p { get; set; } // page count
            public int r { get; set; } // row count
            public string oc { get; set; } // order column
            public string ot { get; set; } // order type
            public string l { get; set; } // limit
            public string s { get; set; }
        }
    }
}
