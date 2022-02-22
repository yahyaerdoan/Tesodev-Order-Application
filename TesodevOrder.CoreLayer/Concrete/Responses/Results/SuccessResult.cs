using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesodevOrder.CoreLayer.Concrete.Responses.Result
{
    public class SuccessResult : Result
    {
        public SuccessResult(string message) : base(true, message)
        {
        }
        public SuccessResult() : base(true)
        {
        }
    }
}
