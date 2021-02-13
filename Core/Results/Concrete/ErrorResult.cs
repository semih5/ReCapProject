using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Results.Concrete
{
    public class ErrorResult
    {
        public ErrorResult(string message) : base(false, message)
        {

        }
    }
}
