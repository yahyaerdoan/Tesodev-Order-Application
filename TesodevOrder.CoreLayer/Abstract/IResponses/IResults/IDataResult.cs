using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesodevOrder.CoreLayer.Abstract.IResponses.IResult;

namespace TesodevOrder.CoreLayer.Abstract.IResponses.IResults
{
    public interface IDataResult<T> : IResult.IResult
    {
        T Data { get; }
    }
}
