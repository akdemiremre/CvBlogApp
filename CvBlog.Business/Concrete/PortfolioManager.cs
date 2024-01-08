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
using System.Text;
using System.Threading.Tasks;

namespace CvBlog.Services.Concrete
{
    public class PortfolioManager : IPortfolioService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public PortfolioManager(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<IResult> Add(PortfolioAddDto portfolioAddDto, string createdByName)
        {
            var portfolio = _mapper.Map<Portfolio>(portfolioAddDto);
            portfolio.CreatedByName = createdByName;
            portfolio.ModifiedByName = createdByName;
            await _unitOfWork.Portfolios.AddAsync(portfolio).ContinueWith(t => { _unitOfWork.SaveAsync(); });
            return new Result(ResultStatus.Success, $"{portfolio.Title} başlıklı portfolio başarıyla kaydedilmiştir.");
        }

        public async Task<IResult> Delete(int portfolioId, string modifiedByName)
        {
            bool result = await _unitOfWork.Portfolios.AnyAsync(x => x.Id == portfolioId);
            if (result)
            {
                var portfolio = await _unitOfWork.Portfolios.GetAsync(x => x.Id == portfolioId);
                portfolio.IsDeleted = true;
                portfolio.ModifiedByName = modifiedByName;
                portfolio.ModifiedDate = DateTime.Now;
                await _unitOfWork.Portfolios.UpdateAsync(portfolio).ContinueWith(t => { _unitOfWork.SaveAsync(); });
                return new Result(ResultStatus.Success, $"{portfolio.Title} başlıklı portfolio kaydı başarıyla silinmiştir.");
            }
            return new Result(ResultStatus.Error, "Böyle bir kayıt bulunamadı.");
        }

        public async Task<IDataResult<PortfolioDto>> Get(int portfolioId)
        {
            var portfolio = await _unitOfWork.Portfolios.GetAsync(x => x.Id == portfolioId);
            if (portfolio != null)
            {
                return new DataResult<PortfolioDto>(ResultStatus.Success, new PortfolioDto
                {
                    ResultStatus = ResultStatus.Success,
                    Portfolio = portfolio
                });
            }
            return new DataResult<PortfolioDto>(ResultStatus.Error, null);
        }

        public async Task<IDataResult<PortfolioListDto>> GetAll()
        {
            var portfolios = await _unitOfWork.Portfolios.GetAllAsync();
            if (portfolios.Count > -1)
            {
                return new DataResult<PortfolioListDto>(ResultStatus.Success, new PortfolioListDto
                {
                    ResultStatus = ResultStatus.Success,
                    Portfolios = portfolios
                });
            }
            return new DataResult<PortfolioListDto>(ResultStatus.Error, null);
        }

        public async Task<IDataResult<PortfolioListDto>> GetAllByNonDeleted()
        {
            var portfolios = await _unitOfWork.Portfolios.GetAllAsync(x => !x.IsDeleted);
            if (portfolios.Count > -1)
            {
                return new DataResult<PortfolioListDto>(ResultStatus.Success, new PortfolioListDto
                {
                    ResultStatus = ResultStatus.Success,
                    Portfolios = portfolios
                });
            }
            return new DataResult<PortfolioListDto>(ResultStatus.Error, null);
        }

        public async Task<IDataResult<PortfolioListDto>> GetAllByNonDeletedAndActive()
        {
            var portfolios = await _unitOfWork.Portfolios.GetAllAsync(x => !x.IsDeleted && x.IsActive);
            if (portfolios.Count > -1)
            {
                return new DataResult<PortfolioListDto>(ResultStatus.Success, new PortfolioListDto
                {
                    ResultStatus = ResultStatus.Success,
                    Portfolios = portfolios
                });
            }
            return new DataResult<PortfolioListDto>(ResultStatus.Error, null);
        }

        public async Task<IResult> HardDelete(int portfolioId)
        {
            bool result = await _unitOfWork.Portfolios.AnyAsync(x => x.Id == portfolioId);
            if (result)
            {
                var portfolio = await _unitOfWork.Portfolios.GetAsync(x => x.Id == portfolioId);
                await _unitOfWork.Portfolios.DeleteAsync(portfolio).ContinueWith(t => { _unitOfWork.SaveAsync(); });
                return new Result(ResultStatus.Success, $"{portfolio.Title} başlıklı portfolio kaydı kalıcı olarak başarıyla silinmiiştir.");
            }
            return new Result(ResultStatus.Error, "Böyle bir kayıt bulunamadı.");
        }

        public async Task<IResult> Update(PortfolioUpdateDto portfolioUpdateDto, string modifiedByName)
        {
            var portfolio = _mapper.Map<Portfolio>(portfolioUpdateDto);
            portfolio.ModifiedByName = modifiedByName;
            portfolio.ModifiedDate = DateTime.Now;
            await _unitOfWork.Portfolios.UpdateAsync(portfolio).ContinueWith(t => { _unitOfWork.SaveAsync(); });
            return new Result(ResultStatus.Success, $"{portfolio.Title} başlıklı portfolio kaydı başarıyla güncellenmiştir.");
        }
    }
}
