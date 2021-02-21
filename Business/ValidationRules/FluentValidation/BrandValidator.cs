using Entities.Concrete;
using Business.ValidationRules.FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class BrandValidator : AbstractValidator<Brand>
    {
        public BrandValidator()
        {
            RuleFor(p => p.BrandName).NotEmpty();
        }

    }
}
