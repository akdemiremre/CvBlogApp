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
            try
            {
                var portfolio = _mapper.Map<Portfolio>(portfolioAddDto);
                portfolio.CreatedByName = createdByName;
                portfolio.ModifiedByName = createdByName;
                await _unitOfWork.Portfolios.AddAsync(portfolio).ContinueWith(t => { _unitOfWork.SaveAsync(); });
                return new Result(ResultStatus.Success, Messages.Portfolio.Add(true,portfolio.Title));
            }
            catch (Exception Ex)
            {
                return new Result(ResultStatus.Success, Messages.Portfolio.Error("Portföy ekleme işlemi",Ex.Message.ToString()));
            }
        }

        public async Task<IResult> Delete(int portfolioId, string modifiedByName)
        {
            try
            {
                bool result = await _unitOfWork.Portfolios.AnyAsync(x => x.Id == portfolioId);
                if (result)
                {
                    var portfolio = await _unitOfWork.Portfolios.GetAsync(x => x.Id == portfolioId);
                    portfolio.IsDeleted = true;
                    portfolio.ModifiedByName = modifiedByName;
                    portfolio.ModifiedDate = DateTime.Now;
                    await _unitOfWork.Portfolios.UpdateAsync(portfolio).ContinueWith(t => { _unitOfWork.SaveAsync(); });
                    return new Result(ResultStatus.Success,Messages.Portfolio.Delete(true,portfolio.Title));
                }
                return new Result(ResultStatus.Error, Messages.Portfolio.NotFound(false));
            }
            catch (Exception Ex)
            {
                return new Result(ResultStatus.Success, Messages.Portfolio.Error("Portföy silme işlemi", Ex.Message.ToString()));
            }
        }

        public async Task<IDataResult<PortfolioDto>> Get(int portfolioId)
        {
            try
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
                return new DataResult<PortfolioDto>(ResultStatus.Error, Messages.Portfolio.NotFound(false),null);
            }
            catch (Exception Ex)
            {
                return new DataResult<PortfolioDto>(ResultStatus.Error, Messages.Portfolio.Error("Portföy çekme işlemi", Ex.Message.ToString()),null);
            }
        }

        public async Task<IDataResult<PortfolioListDto>> GetAll()
        {
            try
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
                return new DataResult<PortfolioListDto>(ResultStatus.Error, Messages.Portfolio.NotFound(false), null);
            }
            catch (Exception Ex)
            {
                return new DataResult<PortfolioListDto>(ResultStatus.Error, Messages.Portfolio.Error("Portföy kayıtlarını çekme işlemi", Ex.Message.ToString()), null);
            }
        }

        public async Task<IDataResult<PortfolioListDto>> GetAllByNonDeleted()
        {
            try
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
                return new DataResult<PortfolioListDto>(ResultStatus.Error, Messages.Portfolio.NotFound(false), null);
            }
            catch (Exception Ex)
            {
                return new DataResult<PortfolioListDto>(ResultStatus.Error, Messages.Portfolio.Error("Portföy kayıtlarını çekme işlemi", Ex.Message.ToString()), null);
            }
        }

        public async Task<IDataResult<PortfolioListDto>> GetAllByNonDeletedAndActive()
        {
            try
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
                return new DataResult<PortfolioListDto>(ResultStatus.Error, Messages.Portfolio.NotFound(false), null);
            }
            catch (Exception Ex)
            {
                return new DataResult<PortfolioListDto>(ResultStatus.Error, Messages.Portfolio.Error("Portföy kayıtlarını çekme işlemi", Ex.Message.ToString()), null);
            }
        }

        public async Task<IResult> HardDelete(int portfolioId)
        {
            try
            {
                bool result = await _unitOfWork.Portfolios.AnyAsync(x => x.Id == portfolioId);
                if (result)
                {
                    var portfolio = await _unitOfWork.Portfolios.GetAsync(x => x.Id == portfolioId);
                    await _unitOfWork.Portfolios.DeleteAsync(portfolio).ContinueWith(t => { _unitOfWork.SaveAsync(); });
                    return new Result(ResultStatus.Success, $"{portfolio.Title} başlıklı portfolio kaydı kalıcı olarak başarıyla silinmiiştir.");
                }
                return new Result(ResultStatus.Error, Messages.Portfolio.NotFound(false));
            }
            catch (Exception Ex)
            {
                return new Result(ResultStatus.Error, Messages.Portfolio.Error("Portföy kayıtlarını çekme işlemi", Ex.Message.ToString()));
            }
        }

        public async Task<IResult> Update(PortfolioUpdateDto portfolioUpdateDto, string modifiedByName)
        {
            try
            {
                var portfolio = _mapper.Map<Portfolio>(portfolioUpdateDto);
                portfolio.ModifiedByName = modifiedByName;
                portfolio.ModifiedDate = DateTime.Now;
                await _unitOfWork.Portfolios.UpdateAsync(portfolio).ContinueWith(t => { _unitOfWork.SaveAsync(); });
                return new Result(ResultStatus.Success,Messages.Portfolio.Update(true,portfolio.Title));
            }
            catch (Exception Ex)
            {
                return new Result(ResultStatus.Error, Messages.Portfolio.Error("Portföy kaydını güncelleme işlemi", Ex.Message.ToString()));
            }
        }
    }
}
