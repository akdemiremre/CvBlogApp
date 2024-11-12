using AutoMapper;
using CvBlog.Data.Abstract;
using CvBlog.Entities.Concrete;
using CvBlog.Entities.Dtos;
using CvBlog.Services.Abstract;
using CvBlog.Services.Utilities;
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
    public class ArticleManager : IArticleService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public ArticleManager(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<IResult> Add(ArticleAddDto articleAddDto, string createdByName)
        {
            try
            {
                var article = _mapper.Map<Article>(articleAddDto);  // _mapper.map<istenilen_class>(mevcut_class)
                if (article != null)
                {
                    article.CreatedByName = createdByName;
                    article.ModifiedByName = createdByName;
                    article.UserId = 1;
                    await _unitOfWork.Articles.AddAsync(article).ContinueWith(t => { _unitOfWork.SaveAsync(); });
                    return new Result(ResultStatus.Success, Messages.Article.Add(true, article.Title));
                }
                return new Result(ResultStatus.Error, Messages.Article.NotFound(false), null);
            }
            catch (Exception Ex)
            {
                return new Result(ResultStatus.Error, Messages.Article.Error("Makale ekleme işlemi", Ex.Message.ToString()), null);
            }
        }

        public async Task<IResult> Delete(int articleId, string modifiedByName)
        {
            try
            {
                var result = await _unitOfWork.Articles.AnyAsync(a => a.Id == articleId);
                if (result)
                {
                    var article = await _unitOfWork.Articles.GetAsync(a => a.Id == articleId);
                    article.IsDeleted = true;
                    article.ModifiedByName = modifiedByName;
                    article.ModifiedDate = DateTime.Now;
                    await _unitOfWork.Articles.UpdateAsync(article).ContinueWith(t => { _unitOfWork.SaveAsync(); });
                    return new Result(ResultStatus.Success, Messages.Article.Delete(true, article.Title));
                }
                return new Result(ResultStatus.Error, Messages.Article.NotFound(false));
            }
            catch (Exception Ex)
            {
                return new Result(ResultStatus.Error, Messages.Article.Error("Silme işlemi", Ex.Message.ToString()));
            }
        }

         public async Task<IDataResult<ArticleDto>> Get(int articleId)
        {
            try
            {
                var article = await _unitOfWork.Articles.GetAsync(a => a.Id == articleId, a => a.User, a => a.Category);
                if (article != null)
                {
                    return new DataResult<ArticleDto>(ResultStatus.Success, new ArticleDto
                    {
                        Article = article,
                        ResultStatus = ResultStatus.Success
                    });
                }
                return new DataResult<ArticleDto>(ResultStatus.Error, Messages.Article.NotFound(false), null);
            }
            catch (Exception Ex)
            {
                return new DataResult<ArticleDto>(ResultStatus.Error, Messages.Article.Error("Makale bilgisi çekme işlemi", Ex.Message.ToString()), null);
            }
        }

        public async Task<IDataResult<ArticleListDto>> GetAll()
        {
            try
            {
                var articles = await _unitOfWork.Articles.GetAllAsync(null, a => a.User, a => a.Category);
                if (articles.Count > -1)
                {
                    return new DataResult<ArticleListDto>(ResultStatus.Success, new ArticleListDto
                    {
                        Articles = articles,
                        ResultStatus = ResultStatus.Success
                    });
                }
                return new DataResult<ArticleListDto>(ResultStatus.Error, Messages.Article.NotFound(true), null);
            }
            catch (Exception Ex)
            {
                return new DataResult<ArticleListDto>(ResultStatus.Error, Messages.Article.Error("Kayıtları listeleme işlemi", Ex.Message.ToString()), null);
            }
        }

        public async Task<IDataResult<ArticleListDto>> GetAllByCategory(int categoryId)
        {
            try
            {
                var result = await _unitOfWork.Categories.AnyAsync(c => c.Id == categoryId);
                if (result)
                {
                    // frontend de kullanıcagımız için aktif ve silinmeyenler gelsin.
                    var articles = await _unitOfWork.Articles.GetAllAsync(a => !a.IsDeleted && a.IsActive && a.CategoryId == categoryId, a => a.User, a => a.Category);
                    if (articles.Count > -1)
                    {
                        return new DataResult<ArticleListDto>(ResultStatus.Success, new ArticleListDto
                        {
                            Articles = articles,
                            ResultStatus = ResultStatus.Success
                        });
                    }
                    return new DataResult<ArticleListDto>(ResultStatus.Error, Messages.Article.NotFound(true), null);
                }
                return new DataResult<ArticleListDto>(ResultStatus.Error, Messages.Article.NotFound(true), null);
            }
            catch (Exception Ex)
            {
                return new DataResult<ArticleListDto>(ResultStatus.Error, Messages.Article.Error("Kayıtları listeleme işlemi", Ex.Message.ToString()), null);
            }
        }

        public async Task<IDataResult<ArticleListDto>> GetAllByNonDeleted()
        {
            try
            {
                var articles = await _unitOfWork.Articles.GetAllAsync(a => !a.IsDeleted, a => a.User, a => a.Category);
                if (articles.Count > -1)
                {
                    return new DataResult<ArticleListDto>(ResultStatus.Success, new ArticleListDto
                    {
                        Articles = articles,
                        ResultStatus = ResultStatus.Success
                    });
                }
                return new DataResult<ArticleListDto>(ResultStatus.Error, Messages.Article.NotFound(true), null);
            }
            catch (Exception Ex)
            {
                return new DataResult<ArticleListDto>(ResultStatus.Error, Messages.Article.Error("Kayıtları listeleme işlemi", Ex.Message.ToString()), null);
            }
        }

        public async Task<IDataResult<ArticleListDto>> GetAllByNonDeletedAndActive()
        {
            try
            {
                var articles = await _unitOfWork.Articles.GetAllAsync(a => !a.IsDeleted && a.IsActive, a => a.User, a => a.Category);
                if (articles.Count > -1)
                {
                    return new DataResult<ArticleListDto>(ResultStatus.Success, new ArticleListDto
                    {
                        Articles = articles,
                        ResultStatus = ResultStatus.Success
                    });
                }
                return new DataResult<ArticleListDto>(ResultStatus.Error, Messages.Article.NotFound(true), null);
            }
            catch (Exception Ex)
            {
                return new DataResult<ArticleListDto>(ResultStatus.Error, Messages.Article.Error("Kayıtları listeleme işlemi", Ex.Message.ToString()), null);
            }
        }

        public async Task<IResult> HardDelete(int articleId, string modifiedByName)
        {
            try
            {
                var result = await _unitOfWork.Articles.AnyAsync(a => a.Id == articleId);
                if (result)
                {
                    var article = await _unitOfWork.Articles.GetAsync(a => a.Id == articleId);
                    await _unitOfWork.Articles.DeleteAsync(article).ContinueWith(t => { _unitOfWork.SaveAsync(); });
                    return new Result(ResultStatus.Success, Messages.Article.HardDelete(true,article.Title));
                }
                return new Result(ResultStatus.Error, "Makale bulunamadı.");
            }
            catch (Exception Ex)
            {
                return new Result(ResultStatus.Error, Messages.Article.Error("Kaydı kalıcı olarak silme işlemi",Ex.Message.ToString()));
            }
        }

        public async Task<IResult> Update(ArticleUpdateDto articleUpdateDto, string modifiedByName)
        {
            try
            {
                var article = _mapper.Map<Article>(articleUpdateDto);
                article.ModifiedByName = modifiedByName;
                await _unitOfWork.Articles.UpdateAsync(article).ContinueWith(t => { _unitOfWork.SaveAsync(); });
                return new Result(ResultStatus.Success, Messages.Article.Update(true,articleUpdateDto.Title));
            }
            catch (Exception Ex)
            {
                return new Result(ResultStatus.Error, Messages.Article.Error("Makale güncelleme işlemi", Ex.Message.ToString()));
            }
        }
    }
}
