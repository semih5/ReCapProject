using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(p => p.CustomerCompanyName).NotEmpty();
            RuleFor(p => p.CustomerCompanyName).MinimumLength(2);

            RuleFor(p => p.CustomerId).NotEmpty();
        }
    }
}
