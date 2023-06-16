using DTO.MySiteDtos;
using Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Abstract
{
    public interface IMySiteRepository
    {
        Task<List<MySite>> GetAsync();
        Task<MySite> GetById(int id);
        Task Addasync(MySite entity);
        Task<MySite> Updateasync(MySite entity);
        Task Deleteasync(int id);
    }
}
