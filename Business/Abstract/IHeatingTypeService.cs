using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilitis.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IHeatingTypeService
    {
        IDataResult<List<HeatingType>> GetAll();
        IDataResult<HeatingType> GetById();
        IResult Add(HeatingType heatingType);
        IResult Update(HeatingType heatingType);
        IResult Delete(HeatingType heatingType);
    }
}
