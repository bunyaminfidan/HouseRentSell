using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilitis.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IStreetService
    {
        IDataResult<List<Street>> GetAll();
        IDataResult<Street> GetById();
        IResult Add(Street street);
        IResult Update(Street street);
        IResult Delete(Street street);
    }
}
