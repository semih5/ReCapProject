using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Results.Concrete
{
    public class ErrorDataResult<T>:DataResult<T>
    {
        public ErrorDataResult(string message) : base(default, false, message)
        {

        }
    }
}
