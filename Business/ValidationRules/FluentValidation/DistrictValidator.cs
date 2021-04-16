using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
   public  class DistrictValidator: AbstractValidator<District>
    {
        public DistrictValidator( )
        {
            RuleFor(d => d.DistrictName).NotEmpty();
            RuleFor(d => d.DistrictName).MinimumLength(2);

        }
    }
}
