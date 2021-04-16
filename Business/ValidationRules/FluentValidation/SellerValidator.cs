using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
 public   class SellerValidator: AbstractValidator<Seller>
    {
        public SellerValidator()
        {
            RuleFor(s => s.UserId).NotEmpty();
            RuleFor(s => s.SellerName).NotEmpty();

        }
    }
}
