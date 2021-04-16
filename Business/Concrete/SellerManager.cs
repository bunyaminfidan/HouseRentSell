using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using Core.Utilitis.Results;
using DataAccess.Abstract;
using DataAccess.Constans;
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
            _sellerDal.Add(seller);
            return new SuccessResult(Messages.SellerAdded);
        }

        public IResult Delete(Seller seller)
        {
            _sellerDal.Delete(seller);
            return new SuccessResult(Messages.SellerDeleted);
        }

        public IDataResult<List<Seller>> GetAll()
        {
            return new SuccessDataResult<List<Seller>>(_sellerDal.GetAll(), Messages.SellerGetAll);
        }

        public IDataResult<Seller> GetById(int id)
        {
            return new SuccessDataResult<Seller>(_sellerDal.Get(b => b.Id == id), Messages.SellerGetById);
        }

        public IResult Update(Seller seller)
        {
            _sellerDal.Update(seller);
            return new SuccessResult(Messages.SellerUpdated);
        }
    }
}
