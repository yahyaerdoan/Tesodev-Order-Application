using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TesodevOrder.CoreLayer.Abstract.IEntities;
using TesodevOrder.CoreLayer.Abstract.IResponses.IResults;

namespace TesodevOrder.InterfaceLayer.Abstract.IGenericService
{
    public interface IGenericService<T, TDto> where T : IEntity where TDto : IDto
    {
        IDataResult<TDto> Add(TDto entity, bool saveChanges = true);
        Task<IDataResult<TDto>> AddAsync(TDto entity, bool saveChanges = true);
        IDataResult<bool> DeleteById(int id, bool saveChanges = true);
        Task<IDataResult<bool>> DeleteByIdAsync(int id, bool saveChanges = true);
        IDataResult<bool> Delete(TDto entity, bool saveChanges = true);
        Task<IDataResult<bool>> DeleteAsync(TDto entity, bool saveChanges = true);
        IDataResult<TDto> Update(TDto entity, bool saveChanges = true);
        Task<IDataResult<TDto>> UpdateAsync(TDto entity, bool saveChanges = true);
        IDataResult<TDto> Find(int id);
        IDataResult<IQueryable<T>> GetIQueryable();
        IDataResult<List<TDto>> GetAll();
        IDataResult<List<TDto>> GetAll(Expression<Func<T, bool>> expression);
        void Save();
    }
}
