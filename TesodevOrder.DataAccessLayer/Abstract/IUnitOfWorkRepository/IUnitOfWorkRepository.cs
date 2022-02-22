using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesodevOrder.CoreLayer.Concrete.Entities;
using TesodevOrder.DataAccessLayer.Abstract.IGenericRepository;

namespace TesodevOrder.DataAccessLayer.Abstract.IUnitOfWorkRepository
{
    public interface IUnitOfWorkRepository : IDisposable
    {
        IGenericRepository<T> GetRepository<T>() where T : Entity;
        bool BeginTransaction();
        bool RollBackTransaction();
        int SaveChanges();
    }
}
