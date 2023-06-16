using DTO.MySiteDtos;
using Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Abstract
{
    public interface IMySiteService
    {
        Task<List<MySiteToListDto>> GetAsync();
        Task<MySiteByIdDto> GetByID(int id);
        Task Addasync(MySiteToAddDto dto);
        Task Deleteasync(int id);
        Task<MySiteToUpdateDto> Updateasync(int id, MySiteToUpdateDto dto);
    }
}
