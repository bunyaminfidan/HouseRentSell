using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
   public class HouseValidator: AbstractValidator<House>
    {
        public HouseValidator()
        {
            RuleFor(h => h.Title).NotEmpty();
            RuleFor(h => h.Price).NotEmpty();
            RuleFor(h => h.Gross).NotEmpty();
            RuleFor(h => h.BuildingAge).NotEmpty();
            RuleFor(h => h.CreditAvailable).NotEmpty();
            RuleFor(h => h.Furniture).NotEmpty();
            RuleFor(h => h.Balcony).NotEmpty();
            RuleFor(h => h.Description).NotEmpty();
            RuleFor(h => h.SaleTypeId).NotEmpty();
            RuleFor(h => h.AdressId).NotEmpty();
            RuleFor(h => h.HeatingTypeId).NotEmpty();
        }
    }
}
