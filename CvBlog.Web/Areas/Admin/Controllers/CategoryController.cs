﻿using AutoMapper;
using CvBlog.Entities.Dtos;
using CvBlog.Services.Abstract;
using CvBlog.Services.Utilities;
using CvBlog.Shared.Utilities.Exttensions;
using CvBlog.Shared.Utilities.Results.ComplexTypes;
using CvBlog.Shared.Utilities.Results.Concrete;
using CvBlog.Web.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System.Text.Json;

namespace CvBlog.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
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
                    var categoryAddAjaxViewModel = JsonSerializer.Serialize(new CategoryAddAjaxViewModel
                    {
                        CategoryDto = result.Data, // veri gönderildi.
                        CategoryAddPartial = await this.RenderViewToStringAsync("_CategoryAddModalPartial", categoryAddDto)
                    });
                    return Json(categoryAddAjaxViewModel);
                }
            }
            //System.Text.Json; daki JsonSerializer
            var categoryAddAjaxErrorViewModel = JsonSerializer.Serialize(new CategoryAddAjaxViewModel
            {
                // CategoryDto kısmını göndermeye gerek yok zaten error a dustu.. 
                // Hata mesajları görünmesi için partialview i gönderdik.
                CategoryAddPartial = await this.RenderViewToStringAsync("_CategoryAddModalPartial",categoryAddDto)
            });
            return Json(categoryAddAjaxErrorViewModel);
        }
    }
}