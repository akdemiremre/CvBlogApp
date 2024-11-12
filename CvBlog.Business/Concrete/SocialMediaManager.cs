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
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CvBlog.Services.Concrete
{
    public class SocialMediaManager : ISocialMediaService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public SocialMediaManager(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<IDataResult<SocialMediaDto>> Get(int socialMediaId)
        {
            try
            {
                var socialMedia = await _unitOfWork.SocialMedias.GetAsync(x => x.Id == socialMediaId);
                if (socialMedia != null)
                {
                    return new DataResult<SocialMediaDto>(ResultStatus.Success, new SocialMediaDto
                    {
                        ResultStatus = ResultStatus.Success,
                        SocialMedia = socialMedia
                    });
                }
                return new DataResult<SocialMediaDto>(ResultStatus.Error, Messages.SocialMedia.NotFound(false), null);
            }
            catch (Exception Ex)
            {
                return new DataResult<SocialMediaDto>(ResultStatus.Error, Messages.SocialMedia.Error("Sosyal medya kaydı çekme işlemi",Ex.Message.ToString()), null);
            }
        }

        public async Task<IDataResult<SocialMediaListDto>> GetAll()
        {
            try
            {
                var socialMedias = await _unitOfWork.SocialMedias.GetAllAsync();
                if (socialMedias.Count > -1)
                {
                    return new DataResult<SocialMediaListDto>(ResultStatus.Success, new SocialMediaListDto
                    {
                        ResultStatus = ResultStatus.Success,
                        SocialMedias = socialMedias
                    });
                }
                return new DataResult<SocialMediaListDto>(ResultStatus.Error, Messages.SocialMedia.NotFound(true), null);
            }
            catch (Exception Ex)
            {
                return new DataResult<SocialMediaListDto>(ResultStatus.Error, Messages.SocialMedia.Error("Sosyal medya kayıtları çekme işlemi",Ex.Message.ToString()), null);
            }
        }

        public async Task<IDataResult<SocialMediaListDto>> GetAllByNonDelete()
        {
            try
            {
                var socialMedias = await _unitOfWork.SocialMedias.GetAllAsync(x => x.IsDeleted);
                if (socialMedias.Count > -1)
                {
                    return new DataResult<SocialMediaListDto>(ResultStatus.Success, new SocialMediaListDto
                    {
                        ResultStatus = ResultStatus.Success,
                        SocialMedias = socialMedias
                    });
                }
                return new DataResult<SocialMediaListDto>(ResultStatus.Error, Messages.SocialMedia.NotFound(true), null);
            }
            catch (Exception Ex)
            {
                return new DataResult<SocialMediaListDto>(ResultStatus.Error, Messages.SocialMedia.Error("Sosyal medya kayıtları çekme işlemi", Ex.Message.ToString()), null);
            }
        }

        public async Task<IDataResult<SocialMediaListDto>> GetAllByNonDeleteAndActive()
        {
            try
            {
                var socialMedias = await _unitOfWork.SocialMedias.GetAllAsync(x => x.IsDeleted && x.IsActive);
                if (socialMedias.Count > -1)
                {
                    return new DataResult<SocialMediaListDto>(ResultStatus.Success, new SocialMediaListDto
                    {
                        ResultStatus = ResultStatus.Success,
                        SocialMedias = socialMedias
                    });
                }
                return new DataResult<SocialMediaListDto>(ResultStatus.Error, Messages.SocialMedia.NotFound(true), null);
            }
            catch (Exception Ex)
            {
                return new DataResult<SocialMediaListDto>(ResultStatus.Error, Messages.SocialMedia.Error("Sosyal medya kayıtları çekme işlemi", Ex.Message.ToString()), null);
            }
        }

        public async Task<IResult> Add(SocialMediaAddDto socialMediaAddDto, string createdByName)
        {
            try
            {
                var socialMedia = _mapper.Map<SocialMedia>(socialMediaAddDto);
                socialMedia.CreatedByName = createdByName;
                socialMedia.ModifiedByName = createdByName;
                await _unitOfWork.SocialMedias.AddAsync(socialMedia).ContinueWith(t => { _unitOfWork.SaveAsync(); });
                return new Result(ResultStatus.Success, Messages.SocialMedia.Add(true,socialMedia.Name));
            }
            catch (Exception Ex)
            {
                return new Result(ResultStatus.Success, Messages.SocialMedia.Error("Sosyal medya ekleme işlemi", Ex.Message.ToString()));
            }
        }

        public async Task<IResult> Update(SocialMediaUpdateDto socialMediaUpdateDto, string modifiedByName)
        {
            try
            {
                var socialMedia = _mapper.Map<SocialMedia>(socialMediaUpdateDto);
                socialMedia.ModifiedByName = modifiedByName;
                await _unitOfWork.SocialMedias.UpdateAsync(socialMedia).ContinueWith(t => { _unitOfWork.SaveAsync(); });
                return new Result(ResultStatus.Success, Messages.SocialMedia.Update(true,socialMedia.Name));
            }
            catch (Exception Ex)
            {
                return new Result(ResultStatus.Success, Messages.SocialMedia.Error("Sosyal medya kaydı güncelleme işlemi", Ex.Message.ToString()));
            }
        }

        public async Task<IResult> Delete(int socialMediaId, string modifiedByName)
        {
            try
            {
                var result = await _unitOfWork.SocialMedias.AnyAsync(x => x.Id == socialMediaId);
                if (result)
                {
                    var socialMedia = await _unitOfWork.SocialMedias.GetAsync(x => x.Id == socialMediaId);
                    socialMedia.IsDeleted = false;
                    socialMedia.ModifiedByName = modifiedByName;
                    socialMedia.ModifiedDate = DateTime.Now;
                    await _unitOfWork.SocialMedias.UpdateAsync(socialMedia).ContinueWith(t => { _unitOfWork.SaveAsync(); });
                    return new Result(ResultStatus.Success, Messages.SocialMedia.Delete(true,socialMedia.Name));
                }
                return new Result(ResultStatus.Success, Messages.SocialMedia.NotFound(false));
            }
            catch (Exception Ex)
            {
                return new Result(ResultStatus.Success, Messages.SocialMedia.Error("Sosyal medya kaydı silme işlemi", Ex.Message.ToString()));
            }
        }

        public async Task<IResult> HardDelete(int socialMediaId)
        {
            try
            {
                var result = await _unitOfWork.SocialMedias.AnyAsync(x => x.Id == socialMediaId);
                if (result)
                {
                    var socialMedia = await _unitOfWork.SocialMedias.GetAsync(x => x.Id == socialMediaId);
                    await _unitOfWork.SocialMedias.DeleteAsync(socialMedia).ContinueWith(t => { _unitOfWork.SaveAsync(); });
                    return new Result(ResultStatus.Success, Messages.SocialMedia.HardDelete(true, socialMedia.Name));
                }
                return new Result(ResultStatus.Success, Messages.SocialMedia.NotFound(false));
            }
            catch (Exception Ex)
            {
                return new Result(ResultStatus.Success, Messages.SocialMedia.Error("Sosyal medya kaydını kalıcı olarak silme işlemi", Ex.Message.ToString()));
            }
        }
    }
}
