using AutoMapper;
using CvBlog.Services.Abstract;
using CvBlog.Services.Utilities;
using CvBlog.Shared.Utilities.Results.ComplexTypes;
using CvBlog.Web.Areas.Admin.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CvBlog.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin,Editor")]
    [Route("admin/egitim")]
    public class EducationController : BaseController
    {
        private readonly IEducationService _educationService;
        public EducationController(IMapper mapper, IEducationService educationService) : base(mapper)
        {
            _educationService = educationService;
        }
        [Route("liste")]
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var result = await _educationService.GetAllAsync();
            if (result.ResultStatus == ResultStatus.Success)
            {
                return View(result.Data);
            }
            return View();
        }
        [Route("egitim-listesi")]
        [HttpPost]
        public async Task<JsonResult> EducationList(string val, int draw, int start, int length)
        {
            var searchValue = Request.Form["search[value]"].FirstOrDefault();
            EducationVliewModel educationVliewModel = new EducationVliewModel();
            EducationVliewModel.Parameter parameter = new EducationVliewModel.Parameter();
            parameter = Tool.AsObject<EducationVliewModel.Parameter>(val);
            parameter.s = searchValue;
            parameter.p = (start == 0) ? 1 : (start / length + 1);
            educationVliewModel.Result = await _educationService.GetPagingAllAsync(parameter.p, parameter.r, parameter.oc, parameter.ot, parameter.s);
            educationVliewModel.EducationDataTable = new EducationVliewModel.DataTable();
            educationVliewModel.EducationDataTable.Draw = draw;
            educationVliewModel.EducationDataTable.RecordsTotal = await _educationService.CountAsync();
            educationVliewModel.EducationDataTable.RecordsFiltered = educationVliewModel.EducationDataTable.RecordsTotal;
            string[][] data = new string[educationVliewModel.Result.Data.Educations.Count][];
            int index = 0;
            foreach (var item in educationVliewModel.Result.Data.Educations)
            {
                data[index] = new string[]
                {
                    item.EducationLevelId.ToString(),
                    item.SchoolName,
                    item.DateRange,
                    item.Description,
                    item.CreatedDate.ToShortDateString()+" "+ item.CreatedDate.ToShortTimeString(),
                    item.ModifiedDate.ToShortDateString()+" "+ item.ModifiedDate.ToShortTimeString(),
                    Tool.Base64Encode(item.Id.ToString()),
                    item.IsActive.ToString()
                };
                index++;
            }
            educationVliewModel.EducationDataTable.Data = data;
            return Json(educationVliewModel.EducationDataTable);
        }
    }
}
