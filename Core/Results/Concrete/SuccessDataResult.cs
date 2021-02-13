using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Results.Concrete
{
    public class SuccessDataResult<T>:DataResult<T>
    {
        private List<global::Entities.Concrete.Car> lists;

        public SuccessDataResult(string message) : base(default, false, message)
        {

        }

        public SuccessDataResult(List<global::Entities.Concrete.Car> lists)
        {
            this.lists = lists;
        }
    }
}
