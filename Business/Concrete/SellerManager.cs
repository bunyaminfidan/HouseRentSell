using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using Core.Utilitis.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class SellerManager : ISellerService
    {
        private ISellerDal _sellerDal;

        public SellerManager(ISellerDal sellerDal)
        {
            _sellerDal = sellerDal;
        }

        public IResult Add(Seller seller)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(Seller seller)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Seller>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<Seller> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IResult Update(Seller seller)
        {
            throw new NotImplementedException();
        }
    }
}
