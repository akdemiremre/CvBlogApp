using CvBlog.Entities.Dtos;
using CvBlog.Shared.Utilities.Results.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CvBlog.Services.Abstract
{
    public interface ISocialMediaService
    {
        Task<IDataResult<SocialMediaDto>> GetAsync(int socialMediaId);
        Task<IDataResult<SocialMediaListDto>> GetAllAsync();
        Task<IDataResult<SocialMediaListDto>> GetAllByNonDeleteAsync();
        Task<IDataResult<SocialMediaListDto>> GetAllByNonDeleteAndActiveAsync();
        Task<IResult> AddAsync(SocialMediaAddDto socialMediaAddDto, string createdByName);
        Task<IResult> UpdateAsync(SocialMediaUpdateDto socialMediaUpdateDto, string modifiedByName);
        Task<IResult> DeleteAsync(int socialMediaId, string modifiedByName);
        Task<IResult> HardDeleteAsync(int socialMediaId);
    }
}
