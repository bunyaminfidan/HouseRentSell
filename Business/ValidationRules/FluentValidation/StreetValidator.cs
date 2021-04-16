using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class StreetValidator : AbstractValidator<Street>
    {
        public StreetValidator()
        {
            RuleFor(s => s.StreetName).NotEmpty();
        }
    }
}
