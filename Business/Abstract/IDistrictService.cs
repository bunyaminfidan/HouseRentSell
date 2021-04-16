using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilitis.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IDistrictService
    {
        IDataResult<List<District>> GetAll();
        IDataResult<District> GetById(int id);
        IResult Add(District district);
        IResult Update(District district);
        IResult Delete(District district);
    }
}
