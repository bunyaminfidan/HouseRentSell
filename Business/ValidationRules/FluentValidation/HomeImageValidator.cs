using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class HomeImageValidator : AbstractValidator<HomeImage>
    {
        public HomeImageValidator()
        {
            RuleFor(h => h.HomeId).NotEmpty();
            RuleFor(h => h.HomeId).GreaterThan(0);
        }
    }
}
