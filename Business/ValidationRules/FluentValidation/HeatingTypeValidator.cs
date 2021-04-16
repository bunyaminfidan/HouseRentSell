using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class HeatingTypeValidator: AbstractValidator<HeatingType>
    {
        public HeatingTypeValidator()
        {
            RuleFor(r => r.HeatingName).NotEmpty();
            RuleFor(r => r.HeatingName).MinimumLength(2);

        }
    }
}
