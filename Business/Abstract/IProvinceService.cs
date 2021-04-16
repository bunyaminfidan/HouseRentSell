using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilitis.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IProvinceService
    {
        IDataResult<List<Province>> GetAll();
        IDataResult<Province> GetById();
        IResult Add(Province province);
        IResult Update(Province province);
        IResult Delete(Province province);
    }
}
