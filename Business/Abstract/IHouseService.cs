using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilitis.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IHouseService
    {
        IDataResult<List<House>> GetAll();
        IDataResult<House> GetById();
        IResult Add(House house);
        IResult Update(House house);
        IResult Delete(House house);
    }
}
