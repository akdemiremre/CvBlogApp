using CvBlog.Services.Abstract;
using CvBlog.Services.Utilities;
using CvBlog.Shared.Utilities.Results.ComplexTypes;
using CvBlog.Web.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;

namespace CvBlog.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;
        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var result = await _categoryService.GetAll();
            if (result.ResultStatus == ResultStatus.Success) 
            {
                return View(result.Data);
            }
            return View();
        }
        [HttpGet]
        public async Task<JsonResult> CategoryList(string? p, string? r, string? oc, string? ot, string? l)
        {
            int pageNumber = (p != null) ? Convert.ToInt32(p) : 1;
            int rowCount = (r != null) ? Convert.ToInt32(r) : 10;
            string orderColumn = (oc != null) ? oc : "Id";
            string orderType = (ot != null) ? ot : "Desc";
            int limit = (l != null) ? Convert.ToInt32(l) : 99999999;
            var queryResult = await _categoryService.GetAll();
            return Json(queryResult.Data);
        }
        [HttpPost]
        public async Task<JsonResult> CategoryList(string val, int draw, int start, int length)
        {
            var searchValue = Request.Form["search[value]"].FirstOrDefault();
            CategoryViewModel categoryViewModel = new CategoryViewModel();
            CategoryViewModel.Parameter parameter = new CategoryViewModel.Parameter();
            parameter = Tool.AsObject<CategoryViewModel.Parameter>(val);
            parameter.s = searchValue;
            parameter.p = start / length;
            if (start == 0)
                parameter.p = 1;
            else
                parameter.p = start / length + 1;
            categoryViewModel.Result = await _categoryService.GetPagingAllAsync(parameter.p,parameter.r,parameter.oc,parameter.ot, parameter.s);
            categoryViewModel.CategoryDataTable = new CategoryViewModel.DataTable();
            categoryViewModel.CategoryDataTable.Draw = draw;
            categoryViewModel.CategoryDataTable.RecordsTotal = await _categoryService.CountAsync();
            categoryViewModel.CategoryDataTable.RecordsFiltered = categoryViewModel.CategoryDataTable.RecordsTotal;
            string[][] data = new string[categoryViewModel.Result.Data.Categories.Count][];
            int index = 0;
            foreach (var item in categoryViewModel.Result.Data.Categories)
            {
                data[index] = new string[] {
                    item.Name, // 0
                    item.Description, // 1
                    item.CreatedDate.ToShortDateString() + " " + item.CreatedDate.ToShortTimeString(),
                    item.CreatedByName,
                    item.ModifiedDate.ToShortDateString() + " " + item.ModifiedDate.ToShortTimeString(),
                    item.ModifiedByName,
                    Tool.Base64Encode(item.Id.ToString()),
                    item.IsActive.ToString()
                };
                index++;
            }
            categoryViewModel.CategoryDataTable.Data = data;
            return Json(categoryViewModel.CategoryDataTable);
        }
    }
}
