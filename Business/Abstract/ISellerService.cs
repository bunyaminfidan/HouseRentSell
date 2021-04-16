using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilitis.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface ISellerService
    {
        IDataResult<List<Seller>> GetAll();
        IDataResult<Seller> GetById(int id);
        IResult Add(Seller seller);
        IResult Update(Seller seller);
        IResult Delete(Seller seller);
    }
}
