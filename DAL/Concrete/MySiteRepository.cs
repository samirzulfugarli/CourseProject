using DAL.Abstract;
using DAL.DataContext;
using DTO.MySiteDtos;
using Entity.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Concrete
{
    public class MySiteRepository : IMySiteRepository
    {
        private readonly MyContext _ctx;
        public MySiteRepository(MyContext ctx)
        {
            _ctx = ctx;
        }
        public async Task Addasync(MySite entity)
        {
            await _ctx.MySites.AddAsync(entity);
        }

        public async Task Deleteasync(int id)
        {
            MySite site = await _ctx.MySites.FindAsync(id);
            _ctx.MySites.Remove(site);
        }

        public async Task<List<MySite>> GetAsync()
        {
            return await _ctx.MySites.ToListAsync();
        }

        public async Task<MySite> GetById(int id)
        {
            return (await _ctx.MySites.FindAsync(id));
        }

        public async Task<MySite> Updateasync(MySite entity)
        {
            _ctx.MySites.Update(entity);
            return entity;
        }
    }
}
