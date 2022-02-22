using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TesodevOrder.CoreLayer.Abstract.IEntities;
using TesodevOrder.CoreLayer.Concrete.Entities;
using TesodevOrder.DataAccessLayer.Abstract.IGenericRepository;

namespace TesodevOrder.DataAccessLayer.Concrete.EntityFramework.EfGenericRepository
{
    public class EfGenericRepository<T, C> : IGenericRepository<T> where T : class, IEntity, new()
        where C : DbContext, new()
    {
        protected readonly DbContext context;
        protected readonly DbSet<T> set;

        public EfGenericRepository(DbContext context)
        {
            this.context = context;
            this.set = this.context.Set<T>();
        }

        public T Add(T entity)
        {
            var addedEntity = context.Entry(entity);
            addedEntity.State = EntityState.Added;
            set.Add(entity);
            return entity;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public bool Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public T Find(int id)
        {
            throw new NotImplementedException();
        }

        public List<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> GetAll(Expression<Func<T, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public T Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
