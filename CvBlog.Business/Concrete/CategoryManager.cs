using AutoMapper;
using CvBlog.Data.Abstract;
using CvBlog.Data.Concrete;
using CvBlog.Entities.Concrete;
using CvBlog.Entities.Dtos;
using CvBlog.Services.Abstract;
using CvBlog.Shared.Utilities.Results.Abstract;
using CvBlog.Shared.Utilities.Results.ComplexTypes;
using CvBlog.Shared.Utilities.Results.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CvBlog.Services.Concrete
{
    public class CategoryManager : ManagerBase,ICategoryService
    {
        public CategoryManager(IUnitOfWork unitOfWork, IMapper mapper) : base (unitOfWork,mapper)
        {
        }

        public async Task<IDataResult<CategoryDto>> Add(CategoryAddDto categoryAddDto, string createdByName)
        {
            var category = Mapper.Map<Category>(categoryAddDto);
            category.CreatedByName = createdByName;
            category.ModifiedByName = createdByName;
            var addedCategory = await UnitOfWork.Categories.AddAsync(category);
            // await UnitOfWork.Categories.AddAsync(category).ContinueWith(t => { _unitOfWork.SaveAsync(); });
            // bu scope da mevcutta 1 thread zaten çalışırken ContinueWith ile yeni bir thread e SaveAsync() işlemini verip eş zamanlı şekilde arka planda kaydı yapmasınıda sağladık.
            // -> dezavantajo => 2.thread çalışırken(dbcontext te kayıt atarken) 1.thread direkt arayüze success dönüp liste çekmek(örneğin getAllAsync) istediğinde zaten bir thread üzerinde dbcontext in çalıştığını 2.threadin bunu beklemesi gerektiğini söyleyen hata verecektir.
            // bu yüzden await ile işlemin bitmesini bekle diyerek saveAsync i 1.thread e yaptırarak hatayı çözmüş olduk.
            await UnitOfWork.SaveAsync();
            return new DataResult<CategoryDto>(ResultStatus.Success, "Başarılı", new CategoryDto
            {
                Category = addedCategory,
                ResultStatus = ResultStatus.Success,
                Message = "Başarılı"
            });
        }

        public async Task<IResult> Delete(int categoryId,string modifiedByName)
        {
            var category = await UnitOfWork.Categories.GetAsync(c => c.Id == categoryId);
            if (category != null)
            {
                category.IsDeleted = true;
                category.ModifiedByName = modifiedByName;
                category.ModifiedDate = DateTime.Now;
                // güncelleme işlemi tamamlanırken ContinueWith ile db savechange işlemini hızlıca yapıp bu arada frontend e hızlıca yanıt dönmüş oluruz.
                //await UnitOfWork.Categories.UpdateAsync(category).ContinueWith(t => UnitOfWork.SaveAsync()); 
                await UnitOfWork.Categories.UpdateAsync(category);
                await UnitOfWork.SaveAsync();
                return new Result(ResultStatus.Success, $"{category.Name} adlı kategori başarıyla silinmiştir.");
            }
            return new Result(ResultStatus.Error, "Böyle bir kategori bulunamadı.", null);
        }

        public async Task<IDataResult<CategoryDto>> Get(int categoryId)
        {
            var category = await UnitOfWork.Categories.GetAsync(x => x.Id == categoryId, c => c.Articles);
            if (category != null)
            {
                return new DataResult<CategoryDto>(ResultStatus.Success, new CategoryDto
                {
                    Category = category,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<CategoryDto>(ResultStatus.Error, "Böyle bir kategori bulunamadı.", new CategoryDto
            {
               Category = null,
               ResultStatus = ResultStatus.Error,
               Message = "Böyle bir kategori bulunamadı."
            });
        }

        public async Task<IDataResult<CategoryListDto>> GetAll()
        {
            var categories = await UnitOfWork.Categories.GetAllAsync(null, c => c.Articles);
            if (categories.Count > -1) // hiç kategori olmayadabilir... yani count=0 da olabilir.
            {
                return new DataResult<CategoryListDto>(ResultStatus.Success, new CategoryListDto
                {
                    Categories = categories,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<CategoryListDto>(ResultStatus.Error, "Hiç bir kategori bulunamadı.", null);
        }

        public async Task<IDataResult<CategoryListDto>> GetAllByNonDeleted()
        {
            var categories = await UnitOfWork.Categories.GetAllAsync(x => !x.IsDeleted, c => c.Articles);
            if (categories.Count > -1)
            {
                return new DataResult<CategoryListDto>(ResultStatus.Success, new CategoryListDto
                {
                    Categories = categories,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<CategoryListDto>(ResultStatus.Error, "Hiç bir kategori bulunamadı.", null);
        }
        public async Task<IDataResult<CategoryListDto>> GetAllByNonDeletedAndActive()
        {
            var categories = await UnitOfWork.Categories.GetAllAsync(x => !x.IsDeleted && x.IsActive, c => c.Articles);
            if (categories.Count > -1)
            {
                return new DataResult<CategoryListDto>(ResultStatus.Success, new CategoryListDto
                {
                    Categories = categories,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<CategoryListDto>(ResultStatus.Error, "Hiç bir kategori bulunamadı.", null);
        }

        public async Task<int> CountAsync()
        {
            return await UnitOfWork.Categories.CountAsync(x => !x.IsDeleted);
        }

        public async Task<IDataResult<CategoryListDto>> GetPagingAllAsync(int pageNumber, int rowCount, string orderColumn, string orderType, string searchValue)
        {
            //var categories = await _unitOfWork.Categories.GetAllAsync();
            var categories = await UnitOfWork.Categories.GetPagingAllAsync(pageNumber, rowCount, orderColumn, orderType,x => !x.IsDeleted && x.Name.Contains(searchValue));
            if (categories.Count > -1) // hiç kategori olmayadabilir... yani count=0 da olabilir.
            {
                return new DataResult<CategoryListDto>(ResultStatus.Success, new CategoryListDto
                {
                    Categories = categories,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<CategoryListDto>(ResultStatus.Error, "Hiç bir kategori bulunamadı.", null);
        }

        public async Task<IResult> HardDelete(int categoryId, string modifiedByName)
        {
            var category = await UnitOfWork.Categories.GetAsync(c => c.Id == categoryId);
            if (category != null)
            {
                await UnitOfWork.Categories.DeleteAsync(category).ContinueWith(t => UnitOfWork.SaveAsync());
                // silme işlemi tamamlanırken ContinueWith ile db savechange işlemini hızlıca yapıp bu arada frontend e hızlıca yanıt dönmüş oluruz.
                return new Result(ResultStatus.Success, $"{category.Name} adlı kategori başarıyla kalıcı olarak silinmiştir.");
            }
            return new Result(ResultStatus.Error, "Böyle bir kategori bulunamadı.", null);
        }

        public async Task<IDataResult<CategoryDto>> Update(CategoryUpdateDto categoryUpdateDto, string modifiedByName)
        {
            //var category = Mapper.Map<Category>(categoryUpdateDto);
            // categoryUpdateDto -> category e map ederken tekrardan createdDate ve createdByName i verme durumundan dolayı map işlemine eski kategori bilgisini kaynak olarak verdik. Bunun sonucunda createdDate ve createdByName e dokunmadan map işlemini yapmış olduk.
            var oldCategory = await UnitOfWork.Categories.GetAsync(c => c.Id == categoryUpdateDto.Id);
            var category = Mapper.Map<CategoryUpdateDto,Category>(categoryUpdateDto,oldCategory);
            category.ModifiedByName = modifiedByName;
            //var updatedCategory = await UnitOfWork.Categories.UpdateAsync(category).ContinueWith(t => { UnitOfWork.SaveAsync(); });
            var updatedCategory = await UnitOfWork.Categories.UpdateAsync(category);
            await UnitOfWork.SaveAsync();
            //return new Result(ResultStatus.Error, "Böyle bir kategori bulunamadı.", null);
            return new DataResult<CategoryDto>(ResultStatus.Success, $"{categoryUpdateDto.Name} adlı kategori başarıyla güncellenmiştir." ,new CategoryDto
            {
                Category = updatedCategory,
                ResultStatus = ResultStatus.Success,
                Message = $"{categoryUpdateDto.Name} adlı kategori başarıyla güncellenmiştir."
            });
        }

        public async Task<IDataResult<CategoryUpdateDto>> GetCategoryUpdateDto(int categoryId)
        {
            var result = await UnitOfWork.Categories.AnyAsync(x => x.Id == categoryId);
            if (result)
            {
                var category = await UnitOfWork.Categories.GetAsync(x => x.Id == categoryId);
                var categoryUpdateDto = Mapper.Map<CategoryUpdateDto>(category);
                return new DataResult<CategoryUpdateDto>(ResultStatus.Success, categoryUpdateDto);
            }
            return new DataResult<CategoryUpdateDto>(ResultStatus.Error,"Böyle bir kategori bulunamadı.",null);
        }

        public async Task<IResult> UpdateIsActive(int categoryId, string modifiedByName)
        {
            var result = await UnitOfWork.Categories.AnyAsync(x => x.Id == categoryId);
            if (result)
            {
                var category = await UnitOfWork.Categories.GetAsync(x => x.Id == categoryId);
                category.ModifiedByName = modifiedByName;
                category.ModifiedDate = DateTime.Now;
                string message = string.Empty;
                if (category.IsActive)
                {
                    category.IsActive = false;
                    message = $"{category.Name} isimli kategori başarıyla aktif hale getirilmiştir.";
                }
                else
                {
                    category.IsActive = true;
                    message = $"{category.Name} isimli kategori başarıyla pasif hale getirilmiştir.";
                }
                category = await UnitOfWork.Categories.UpdateAsync(category);
                await UnitOfWork.SaveAsync();
                return new Result(ResultStatus.Success, message);
            }
            return new Result(ResultStatus.Error, "Böyle bir kategori bulunamadı.");
        }
    }
}
