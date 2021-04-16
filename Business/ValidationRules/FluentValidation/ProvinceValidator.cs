using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
 public   class ProvinceValidator: AbstractValidator<Province>
    {
        public ProvinceValidator()
        {
            RuleFor(p => p.ProvinceName).NotEmpty();
        }
    }
}
