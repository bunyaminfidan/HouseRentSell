using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilitis.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IHomeImageService
    {
        IDataResult<List<HomeImage>> GetAll();
        IDataResult<HomeImage> GetById();
        IResult Add(HomeImage homeImage);
        IResult Update(HomeImage homeImage);
        IResult Delete(HomeImage homeImage);
    }
}
