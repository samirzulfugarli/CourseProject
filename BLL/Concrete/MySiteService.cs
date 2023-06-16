using AutoMapper;
using BLL.Abstract;
using DAL.UnitOfWork.Abstract;
using DTO.MySiteDtos;
using Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Concrete
{
    public class MySiteService : IMySiteService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public MySiteService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task Addasync(MySiteToAddDto dto)
        {
            var entity = _mapper.Map<MySite>(dto);
            await  _unitOfWork.MysiteRepository.Addasync(entity);
            _unitOfWork.CommitAsync();
            
        }

        public async Task Deleteasync(int id)
        {
            await _unitOfWork.MysiteRepository.Deleteasync(id);
            await _unitOfWork.CommitAsync();
        }

        public async Task<List<MySiteToListDto>> GetAsync()
        {
           var entites = await _unitOfWork.MysiteRepository.GetAsync();
            var dtos = _mapper.Map<List<MySiteToListDto>>(entites);
            return dtos;
        }

        public async Task<MySiteByIdDto> GetByID(int id)
        {
            var entity = await _unitOfWork.MysiteRepository.GetById(id);
            var dto = _mapper.Map< MySiteByIdDto >(entity);
            return dto;
        }

        public async Task<MySiteToUpdateDto> Updateasync(int id, MySiteToUpdateDto dto)
        {
            var entity = await _unitOfWork.MysiteRepository.GetById(id);
            if (entity==null)
            {
                throw new Exception("Entity is null");
            }
            entity.Name= dto.Name;
            MySite site = await _unitOfWork.MysiteRepository.Updateasync(entity);
            var dtos = _mapper.Map<MySiteToUpdateDto>(site);
            site.Name=dtos.Name;
            _unitOfWork.CommitAsync();
            return dtos;
        }
    }
}
