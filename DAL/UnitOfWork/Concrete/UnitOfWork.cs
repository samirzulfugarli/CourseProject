using DAL.Abstract;
using DAL.DataContext;
using DAL.UnitOfWork.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.UnitOfWork.Concrete
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly MyContext _ctx;
        public IMySiteRepository MysiteRepository { get;set; }
        public UnitOfWork(MyContext ctx, IMySiteRepository mySiteRepository )
        {
            _ctx = ctx;
            MysiteRepository=mySiteRepository;
        }
        public async Task CommitAsync()
        {
            await _ctx.SaveChangesAsync();
        }
    }
}
