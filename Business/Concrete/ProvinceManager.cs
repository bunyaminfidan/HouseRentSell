using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using Core.Utilitis.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class ProvinceManager : IProvinceService
    {
        private IProvinceDal _provinceDal;

        public ProvinceManager(IProvinceDal provinceDal)
        {
            _provinceDal = provinceDal;
        }
        public IResult Add(Province province)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(Province province)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Province>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<Province> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IResult Update(Province province)
        {
            throw new NotImplementedException();
        }
    }
}
