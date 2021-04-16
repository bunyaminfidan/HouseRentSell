using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilitis.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface ISaleTypeService
    {
        IDataResult<List<SaleType>> GetAll();
        IDataResult<SaleType> GetById();
        IResult Add(SaleType saleType);
        IResult Update(SaleType saleType);
        IResult Delete(SaleType saleType);
    }
}
