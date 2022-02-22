using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TesodevOrder.CoreLayer.Abstract.IEntities;
using TesodevOrder.CoreLayer.Concrete.Entities;

namespace TesodevOrder.DataAccessLayer.Abstract.IGenericRepository
{
    public interface IGenericRepository<T> where T : class, IEntity, new()
    {
        T Add(T entity);
        bool Delete(int id);
        bool Delete(T entity);
        T Update(T entity);
        T Find(int id);
        List<T> GetAll();
        IQueryable<T> GetAll(Expression<Func<T, bool>> expression);
    }
}
