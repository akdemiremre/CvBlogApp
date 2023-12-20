using AutoMapper;
using CvBlog.Data.Abstract;
using CvBlog.Entities.Concrete;
using CvBlog.Entities.Dtos;
using CvBlog.Services.Abstract;
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
            var socialMedia = await _unitOfWork.SocialMedias.GetAsync(x => x.Id == socialMediaId);
            if (socialMedia != null)
            {
                return new DataResult<SocialMediaDto>(ResultStatus.Success,new SocialMediaDto
                {
                    ResultStatus = ResultStatus.Success,
                    SocialMedia = socialMedia
                });
            }
            return new DataResult<SocialMediaDto>(ResultStatus.Error,"Böyle bir sosyal medya bulunamadı.", null);
        }

        public async Task<IDataResult<SocialMediaListDto>> GetAll()
        {
            var socialMedias = await _unitOfWork.SocialMedias.GetAllAsync();
            if (socialMedias.Count > -1 )
            {
                return new DataResult<SocialMediaListDto>(ResultStatus.Success, new SocialMediaListDto
                {
                    ResultStatus = ResultStatus.Success,
                    SocialMedias = socialMedias
                });
            }
            return new DataResult<SocialMediaListDto>(ResultStatus.Error, "Herhangi bir sosyal medya kaydı bulunamadı", null);
        }

        public async Task<IDataResult<SocialMediaListDto>> GetAllByNonDelete()
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
            return new DataResult<SocialMediaListDto>(ResultStatus.Error, "Herhangi bir sosyal medya kaydı bulunamadı", null);
        }

        public async Task<IDataResult<SocialMediaListDto>> GetAllByNonDeleteAndActive()
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
            return new DataResult<SocialMediaListDto>(ResultStatus.Error, "Herhangi bir sosyal medya kaydı bulunamadı", null);
        }

        public async Task<IResult> Add(SocialMediaAddDto socialMediaAddDto, string createdByName)
        {
            var socialMedia = _mapper.Map<SocialMedia>(socialMediaAddDto);
            socialMedia.CreatedByName = createdByName;
            socialMedia.ModifiedByName = createdByName;
            socialMedia.CreatedDate = DateTime.Now;
            socialMedia.ModifiedDate = DateTime.Now;
            await _unitOfWork.SocialMedias.AddAsync(socialMedia).ContinueWith(t => { _unitOfWork.SaveAsync(); });
            return new Result(ResultStatus.Success, $"{socialMedia.Name} isimli kayıt başarıyla eklendi.");
        }

        public async Task<IResult> Update(SocialMediaUpdateDto socialMediaUpdateDto, string modifiedByName)
        {
            var socialMedia = _mapper.Map<SocialMedia>(socialMediaUpdateDto);
            socialMedia.ModifiedByName = modifiedByName;
            socialMedia.ModifiedDate = DateTime.Now;
            await _unitOfWork.SocialMedias.UpdateAsync(socialMedia).ContinueWith(t => { _unitOfWork.SaveAsync(); });
            return new Result(ResultStatus.Success, $"{socialMedia.Name} isimli kayıt başarıyla güncellend.");
        }

        public async Task<IResult> Delete(int socialMediaId, string modifiedByName)
        {
            var result = await _unitOfWork.SocialMedias.AnyAsync(x => x.Id == socialMediaId);
            if (result)
            {
                var socialMedia = await _unitOfWork.SocialMedias.GetAsync(x => x.Id == socialMediaId);
                socialMedia.IsDeleted = false;
                socialMedia.ModifiedByName = modifiedByName;
                socialMedia.ModifiedDate = DateTime.Now;
                await _unitOfWork.SocialMedias.UpdateAsync(socialMedia).ContinueWith( t => { _unitOfWork.SaveAsync(); });
                return new Result(ResultStatus.Success, $"{socialMedia.Name} isimli sosyal medya kaydı başarıyla silinmiştir.");
            }
            return new Result(ResultStatus.Success, "Böyle bir sosyal medya kaydı bulunamadı");
        }

        public async Task<IResult> HardDelete(int socialMediaId)
        {
            var result = await _unitOfWork.SocialMedias.AnyAsync(x => x.Id == socialMediaId);
            if (result)
            {
                var socialMedia = await _unitOfWork.SocialMedias.GetAsync(x => x.Id == socialMediaId);
                await _unitOfWork.SocialMedias.DeleteAsync(socialMedia).ContinueWith(t => { _unitOfWork.SaveAsync(); });
                return new Result(ResultStatus.Success, $"{socialMedia.Name} isimli sosyal medya kaydı başarıyla kalıcı olarak silinmiştir.");
            }
            return new Result(ResultStatus.Success, "Böyle bir sosyal medya kaydı bulunamadı");
        }
    }
}
