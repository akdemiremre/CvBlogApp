using CvBlog.Entities.Dtos;
using CvBlog.Shared.Utilities.Results.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CvBlog.Services.Abstract
{
    public interface IPortfolioService
    {
        Task<IDataResult<PortfolioDto>> Get(int portfolioId);
        Task<IDataResult<PortfolioListDto>> GetAll();
        Task<IDataResult<PortfolioListDto>> GetAllByNonDeleted();
        Task<IDataResult<PortfolioListDto>> GetAllByNonDeletedAndActive();
        Task<IResult> Add(PortfolioAddDto portfolioAddDto, string createdByName);
        Task<IResult> Update(PortfolioUpdateDto portfolioUpdateDto, string modifiedByName);
        Task<IResult> Delete(int portfolioId, string modifiedByName);
        Task<IResult> HardDelete(int portfolioId);
    }
}
