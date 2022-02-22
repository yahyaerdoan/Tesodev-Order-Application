using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using TesodevOrder.CoreLayer.Concrete.Entities;
using TesodevOrder.DataAccessLayer.Abstract.IGenericRepository;
using TesodevOrder.DataAccessLayer.Abstract.IUnitOfWorkRepository;
using TesodevOrder.DataAccessLayer.Concrete.EntityFramework.EfGenericRepository;

namespace TesodevOrder.DataAccessLayer.Concrete.EntityFramework.EfUnitOfWorkRepository
{
    public class EfUnitOfWorkRepository : IUnitOfWorkRepository
    {

        private readonly DbContext context;
        private IDbContextTransaction transaction;
        private bool dispose = false;

        public EfUnitOfWorkRepository(DbContext context)
        {
            this.context = context;
        }

        public IGenericRepository<T> GetRepository<T, C>() where T : Entity, new() where C : DbContext, new()
        {
            return new EfGenericRepository<T, C>(context);
        }

        public bool BeginTransaction()
        {
            try
            {
                transaction = context.Database.BeginTransaction();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool RollBackTransaction()
        {
            try
            {
                if (transaction != null)
                {
                    transaction.Rollback();
                    transaction.Dispose();
                    transaction = null;
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public int SaveChanges()
        {
            if (context == null)
                throw new ArgumentException("Context is null");
            if (transaction == null)
                BeginTransaction();
            using (transaction)
            {
                try
                {
                    int changes = context.SaveChanges();
                    transaction.Commit();
                    return changes;
                }
                catch (Exception)
                {
                    transaction.Rollback();
                    return -1;
                }
            }
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!this.dispose)
            {
                if (disposing)
                {
                    transaction?.Dispose();
                }
                this.dispose = true;
            }
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

    }
}
