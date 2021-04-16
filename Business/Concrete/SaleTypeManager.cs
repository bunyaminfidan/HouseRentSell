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
    public class SaleTypeManager : ISaleTypeService
    {
        private ISaleTypeDal _saleTypeDal;

        public SaleTypeManager(ISaleTypeDal saleTypeDal)
        {
            _saleTypeDal = saleTypeDal;
        }
        public IResult Add(SaleType saleType)
        {
            _saleTypeDal.Add(saleType);

            return new SuccessResult(Messages.SaleTypeAdded);
        }

        public IResult Delete(SaleType saleType)
        {
            _saleTypeDal.Delete(saleType);

            return new SuccessResult(Messages.SaleTypeDeleted);
        }

        public IDataResult<List<SaleType>> GetAll()
        {
            return new SuccessDataResult<List<SaleType>>(_saleTypeDal.GetAll(), Messages.SaleTypeGetAll);
        }

        public IDataResult<SaleType> GetById(int id)
        {
            return new SuccessDataResult<SaleType>(_saleTypeDal.Get(b => b.Id == id), Messages.SaleTypeGetById);

        }

        public IResult Update(SaleType saleType)
        {
            _saleTypeDal.Update(saleType);

            return new SuccessResult(Messages.SaleTypeUpdated);
        }
    }
}
