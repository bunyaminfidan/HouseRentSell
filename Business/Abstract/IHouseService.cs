using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilitis.Results;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface IHouseService
    {
        IDataResult<List<House>> GetAll();
        IDataResult<House> GetById(int id);
        IResult Add(House house);
        IResult Update(House house);
        IResult Delete(House house);

        IDataResult<List<HouseDetail>> GetAllHouseDetails();
    }
}
