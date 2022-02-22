using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TesodevOrder.CoreLayer.Concrete.Entities;
using TesodevOrder.DataAccessLayer.Abstract.IGenericRepository;

namespace TesodevOrder.DataAccessLayer.Abstract.IUnitOfWorkRepository
{
    public interface IUnitOfWorkRepository : IDisposable
    {
        IGenericRepository<T> GetRepository<T, C>() where T : Entity, new() where C : DbContext, new();
        bool BeginTransaction();
        bool RollBackTransaction();
        int SaveChanges();
    }
}
