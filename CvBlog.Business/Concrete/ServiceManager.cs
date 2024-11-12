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
    public class ServiceManager : IServiceService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public ServiceManager(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<IResult> Add(ServiceAddDto serviceAddDto, string createdByName)
        {
            try
            {
                var service = _mapper.Map<Service>(serviceAddDto);
                service.CreatedByName = createdByName;
                service.ModifiedByName = createdByName;
                await _unitOfWork.Services.AddAsync(service).ContinueWith(t => { _unitOfWork.SaveAsync(); });
                return new Result(ResultStatus.Success, Messages.Service.Add(true,service.Name));
            }
            catch (Exception Ex)
            {
                return new Result(ResultStatus.Success, Messages.Service.Error("Ekleme işlemi",Ex.Message.ToString()));
            }
        }

        public async Task<IResult> Delete(int serviceId, string modifiedByName)
        {
            try
            {
                var service = await _unitOfWork.Services.GetAsync(x => x.Id == serviceId);
                if (service != null)
                {
                    service.IsDeleted = true;
                    service.ModifiedByName = modifiedByName;
                    service.ModifiedDate = DateTime.Now;
                    await _unitOfWork.Services.UpdateAsync(service).ContinueWith(t => { _unitOfWork.SaveAsync(); });
                    return new Result(ResultStatus.Success, Messages.Service.Delete(true,service.Name));
                }
                return new Result(ResultStatus.Error, Messages.Service.NotFound(false));
            }
            catch (Exception Ex)
            {
                return new Result(ResultStatus.Success, Messages.Service.Error("Silme işlemi", Ex.Message.ToString()));
            }
        }

        public async Task<IDataResult<ServiceDto>> Get(int serviceId)
        {
            try
            {
                var service = await _unitOfWork.Services.GetAsync(x => x.Id == serviceId);
                if (service != null)
                {
                    return new DataResult<ServiceDto>(ResultStatus.Success, new ServiceDto
                    {
                        ResultStatus = ResultStatus.Success,
                        Service = service
                    });
                }
                return new DataResult<ServiceDto>(ResultStatus.Error, Messages.Service.NotFound(false),null);

            }
            catch (Exception Ex)
            {
                return new DataResult<ServiceDto>(ResultStatus.Success, Messages.Service.Error("Silme işlemi", Ex.Message.ToString()),null);
            }
        }

        public async Task<IDataResult<ServiceListDto>> GetAll()
        {
            try
            {
                var services = await _unitOfWork.Services.GetAllAsync();
                if (services.Count > -1)
                {
                    return new DataResult<ServiceListDto>(ResultStatus.Success, new ServiceListDto
                    {
                        ResultStatus = ResultStatus.Success,
                        Services = services
                    });
                }
                return new DataResult<ServiceListDto>(ResultStatus.Error, Messages.Service.NotFound(true), null);
            }
            catch (Exception Ex)
            {
                return new DataResult<ServiceListDto>(ResultStatus.Error, Messages.Service.Error("Kayıtları çekme işlemi", Ex.Message.ToString()), null);
            }
        }

        public async Task<IDataResult<ServiceListDto>> GetAllByNonDeleted()
        {
            try
            {
                var services = await _unitOfWork.Services.GetAllAsync(x => !x.IsDeleted);
                if (services.Count > -1)
                {
                    return new DataResult<ServiceListDto>(ResultStatus.Success, new ServiceListDto
                    {
                        ResultStatus = ResultStatus.Success,
                        Services = services
                    });
                }
                return new DataResult<ServiceListDto>(ResultStatus.Error, Messages.Service.NotFound(true), null);
            }
            catch (Exception Ex)
            {
                return new DataResult<ServiceListDto>(ResultStatus.Error, Messages.Service.Error("Kayıtları çekme işlemi", Ex.Message.ToString()), null);
            }
        }

        public async Task<IDataResult<ServiceListDto>> GetAllByNonDeletedAndActive()
        {
            try
            {
                var services = await _unitOfWork.Services.GetAllAsync(x => !x.IsDeleted && x.IsActive);
                if (services.Count > -1)
                {
                    return new DataResult<ServiceListDto>(ResultStatus.Success, new ServiceListDto
                    {
                        ResultStatus = ResultStatus.Success,
                        Services = services
                    });
                }
                return new DataResult<ServiceListDto>(ResultStatus.Error, Messages.Service.NotFound(true), null);
            }
            catch (Exception Ex)
            {
                return new DataResult<ServiceListDto>(ResultStatus.Error, Messages.Service.Error("Kayıtları çekme işlemi", Ex.Message.ToString()), null);
            }
        }

        public async Task<IResult> HardDelete(int serviceId)
        {
            try
            {
                var result = await _unitOfWork.Services.AnyAsync(x => x.Id == serviceId);
                if (result)
                {
                    var service = await _unitOfWork.Services.GetAsync(x => x.Id == serviceId);
                    await _unitOfWork.Services.DeleteAsync(service).ContinueWith(t => { _unitOfWork.SaveAsync(); });
                    return new Result(ResultStatus.Success, Messages.Service.HardDelete(true,service.Name));
                }
                return new Result(ResultStatus.Error, Messages.Service.NotFound(false));
            }
            catch (Exception Ex)
            {
                return new Result(ResultStatus.Error, Messages.Service.Error("Hizmet kaydını kalıcı olarak silme işlemi",Ex.Message.ToString()));
            }
        }

        public async Task<IResult> Update(ServiceUpdateDto serviceUpdateDto, string modifiedByName)
        {
            try
            {
                var service = _mapper.Map<Service>(serviceUpdateDto);
                service.ModifiedByName = modifiedByName;
                await _unitOfWork.Services.UpdateAsync(service).ContinueWith(t => { _unitOfWork.SaveAsync(); });
                return new Result(ResultStatus.Success, Messages.Service.Update(true,service.Name));
            }
            catch (Exception Ex)
            {
                return new Result(ResultStatus.Error, Messages.Service.Error("Hizmet kaydını güncelleme işlemi", Ex.Message.ToString()));
            }
        }
    }
}
