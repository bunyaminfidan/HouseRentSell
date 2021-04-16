using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using Core.Utilitis.Results;
using DataAccess.Abstract;
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
            throw new NotImplementedException();
        }

        public IResult Delete(SaleType saleType)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<SaleType>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<SaleType> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IResult Update(SaleType saleType)
        {
            throw new NotImplementedException();
        }
    }
}
