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
        Task<IDataResult<SocialMediaDto>> Get(int socialMediaId);
        Task<IDataResult<SocialMediaListDto>> GetAll();
        Task<IDataResult<SocialMediaListDto>> GetAllByNonDelete();
        Task<IDataResult<SocialMediaListDto>> GetAllByNonDeleteAndActive();
        Task<IResult> Add(SocialMediaAddDto socialMediaAddDto, string createdByName);
        Task<IResult> Update(SocialMediaUpdateDto socialMediaUpdateDto, string modifiedByName);
        Task<IResult> Delete(int socialMediaId, string modifiedByName);
        Task<IResult> HardDelete(int socialMediaId);
    }
}
