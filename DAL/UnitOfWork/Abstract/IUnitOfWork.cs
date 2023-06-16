using DAL.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.UnitOfWork.Abstract
{
    public interface IUnitOfWork
    {
        public IMySiteRepository MysiteRepository { get; }
        public Task CommitAsync();
    }
}
