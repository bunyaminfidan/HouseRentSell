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
        IDataResult<HomeAdress> GetById(int id);
        IResult Add(HomeAdress homeAdress);
        IResult Update(HomeAdress homeAdress);
        IResult Delete(HomeAdress homeAdress);

    }
}
