using AutoMapper;
using CvBlog.Data.Concrete;
using CvBlog.Entities.Dtos;
using CvBlog.Services.Abstract;
using CvBlog.Services.Utilities;
using CvBlog.Shared.Utilities.Exttensions;
using CvBlog.Shared.Utilities.Results.ComplexTypes;
using CvBlog.Shared.Utilities.Results.Concrete;
using CvBlog.Web.Areas.Admin.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System.Net;
using System.Text;
using System.Text.Json;

namespace CvBlog.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles ="Admin,Editor")]
    [Route("admin/kategori")]
    public class CategoryController : BaseController
    {
        private readonly ICategoryService _categoryService;
        public CategoryController(ICategoryService categoryService,IMapper mapper) : base(mapper)
        {
            _categoryService = categoryService;
        }
        [Route("liste")]
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
        [Route("kategori-listesi")]
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
        [Route("kategori-listesi")]
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
        [Route("kategori-ekleme-formu")]
        [HttpGet]
        public async Task<PartialViewResult> CategoryAddModal()
        {
            return PartialView("_CategoryAddModalPartial");
        }
        [Route("kategori-ekle")]
        [HttpPost]
        public async Task<IActionResult> CategoryAdd(CategoryAddDto categoryAddDto)
        {
            if (ModelState.IsValid)
            {
                var result = await _categoryService.Add(categoryAddDto, "system");
                if (result.ResultStatus == ResultStatus.Success)
                {
                    //System.Text.Json; daki JsonSerializer
                    var categoryAddAjaxModel = JsonSerializer.Serialize(new CategoryAddAjaxViewModel
                    {
                        CategoryDto = result.Data, // veri gönderildi.
                        CategoryAddPartial = await this.RenderViewToStringAsync("_CategoryAddModalPartial", categoryAddDto)
                    });
                    return Json(categoryAddAjaxModel);
                }
            }
            //System.Text.Json; daki JsonSerializer
            var categoryAddAjaxErrorModel = JsonSerializer.Serialize(new CategoryAddAjaxViewModel
            {
                // CategoryDto kısmını göndermeye gerek yok zaten error a dustu.. 
                // Hata mesajları görünmesi için partialview i gönderdik.
                CategoryAddPartial = await this.RenderViewToStringAsync("_CategoryAddModalPartial",categoryAddDto)
            });
            return Json(categoryAddAjaxErrorModel);
        }
        [Route("kategori-guncelleme-formu")]
        [HttpGet]
        public async Task<IActionResult> CategoryUpdateModal(string val)
        {
            var result = await _categoryService.GetCategoryUpdateDto(Convert.ToInt32(Tool.Base64Decode(val)));
            if (result.ResultStatus == ResultStatus.Success)
            {
                return PartialView("_CategoryUpdateModalPartial", result.Data);
            }
            return NotFound();
        }
        [Route("kategori-guncelle")]
        [HttpPost]
        public async Task<IActionResult> CategoryUpdate(CategoryUpdateDto categoryUpdateDto)
        {
            if (ModelState.IsValid)
            {
                var result = await _categoryService.Update(categoryUpdateDto, "system");
                if (result.ResultStatus == ResultStatus.Success)
                {
                    var categpryUpdateAjaxModel = JsonSerializer.Serialize(new CategoryUpdateAjaxViewModel
                    {
                        CategoryDto = result.Data,
                        CategoryUpdatePartial = await this.RenderViewToStringAsync("_CategoryUpdateModalPartial",categoryUpdateDto)
                    });
                    return Json(categpryUpdateAjaxModel);
                }
            }
            var categoryUpdateErrorAjaxModel = JsonSerializer.Serialize(new CategoryUpdateAjaxViewModel
            {
                CategoryUpdatePartial = await this.RenderViewToStringAsync("_CategoryUpdateModalPartial",categoryUpdateDto)
            });
            return Json(categoryUpdateErrorAjaxModel);
        }
        [Route("kategori-aktif-durumunu-degistir")]
        [HttpPost]
        public async Task<Result> CategoryUpdateIsActive(string val)
        {
            if (!string.IsNullOrEmpty(val))
            {
                var result = await _categoryService.UpdateIsActive(Convert.ToInt32(Tool.Base64Decode(val)),"admin");
                return new Result(result.ResultStatus, result.Message);
            }
            return new Result(ResultStatus.Error, "Lütfen işlem yapmak istediğiniz kategoriyi seçiniz.");
        }
        [Route("kategori-sil")]
        [HttpPost]
        public async Task<Result> CategoryDelete(string val)
        {
            if (!string.IsNullOrEmpty(val))
            {
                var result = await _categoryService.Delete(Convert.ToInt32(Tool.Base64Decode(val)), "admin");
                return new Result(result.ResultStatus, result.Message);
            }
            return new Result(ResultStatus.Error, "Lütfen işlem yapmak istediğiniz kategoriyi seçiniz.");
        }
    }
}
