using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilitis.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IHomeAdressService
    {
        IDataResult<List<HomeAdress>> GetAll();
        IDataResult<HomeAdress> GetById();
        IResult Add(HomeAdress district);
        IResult Update(HomeAdress district);
        IResult Delete(HomeAdress district);

    }
}
