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
            RuleFor(h => h.ProvinceId).NotEmpty();
            RuleFor(h => h.DistrictId).NotEmpty(); 
            RuleFor(h => h.NeighborhoodId).NotEmpty();
       
            RuleFor(h => h.ApartmentBuilding).NotEmpty();
            RuleFor(h => h.Floor).NotEmpty();
            RuleFor(h => h.DoorNumber).NotEmpty();

        }
    }
}
