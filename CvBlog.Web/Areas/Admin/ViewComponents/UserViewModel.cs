using CvBlog.Entities.Dtos;
using CvBlog.Shared.Utilities.Results.Abstract;
using CvBlog.Shared.Utilities.Results.ComplexTypes;

namespace CvBlog.Web.Areas.Admin.ViewComponents
{
    public class UserViewModel
    {
        public IDataResult<UserListDto> Result { get; set; }
        public DataTable UserCategoryDataTable { get; set; }
        public ResultStatus ResultStatus { get; set; }
        public class DataTable
        {
            public string[][] Data { get; set; }
            public int RecordsTotal { get; set; } = 0;
            public int RecordsFiltered { get; set; } = 0;
            public int Draw { get; set; } = 1;
            public int Start { get; set; } = 0;

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
