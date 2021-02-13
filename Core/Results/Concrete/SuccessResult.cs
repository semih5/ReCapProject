using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Results.Concrete
{
    public class SuccessResult
    {
        public SuccessResult(string message) : base(false, message)
        {

        }
    }
}
