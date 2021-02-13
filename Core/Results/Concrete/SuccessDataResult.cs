using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Results.Concrete
{
    public class SuccessDataResult<T>:DataResult<T>
    {
        
        public SuccessDataResult(T data, string message) : base(data, true, message)
        {

        }
    }
}
