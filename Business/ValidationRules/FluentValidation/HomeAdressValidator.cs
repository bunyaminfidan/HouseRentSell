using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
  public  class HomeAdressValidator : AbstractValidator<HomeAdress>
    {
        public HomeAdressValidator()
        {
            RuleFor(h => h.HomeId).NotEmpty();
            RuleFor(h => h.Province).NotEmpty();
            RuleFor(h => h.District).NotEmpty(); 
            RuleFor(h => h.Neighborhood).NotEmpty();
            RuleFor(h => h.Street).NotEmpty();
            RuleFor(h => h.ApartmentBuilding).NotEmpty();
            RuleFor(h => h.Floor).NotEmpty();
            RuleFor(h => h.ApartmentNo).NotEmpty();

        }
    }
}
