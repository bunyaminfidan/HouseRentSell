using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilitis.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface INeighborhoodService
    {
        IDataResult<List<Neighborhood>> GetAll();
        IDataResult<Neighborhood> GetById(int id);
        IResult Add(Neighborhood neighborhood);
        IResult Update(Neighborhood neighborhood);
        IResult Delete(Neighborhood neighborhood);
    }
}
