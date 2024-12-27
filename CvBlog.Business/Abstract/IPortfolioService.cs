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
        Task<IDataResult<PortfolioDto>> GetAsync(int portfolioId);
        Task<IDataResult<PortfolioListDto>> GetAllAsync();
        Task<IDataResult<PortfolioListDto>> GetAllByNonDeletedAsync();
        Task<IDataResult<PortfolioListDto>> GetAllByNonDeletedAndActiveAsync();
        Task<IResult> AddAsync(PortfolioAddDto portfolioAddDto, string createdByName);
        Task<IResult> UpdateAsync(PortfolioUpdateDto portfolioUpdateDto, string modifiedByName);
        Task<IResult> DeleteAsync(int portfolioId, string modifiedByName);
        Task<IResult> HardDeleteAsync(int portfolioId);
    }
}
