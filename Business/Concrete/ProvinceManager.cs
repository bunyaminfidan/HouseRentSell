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
    public class ProvinceManager : IProvinceService
    {
        private IProvinceDal _provinceDal;

        public ProvinceManager(IProvinceDal provinceDal)
        {
            _provinceDal = provinceDal;
        }
        public IResult Add(Province province)
        {
            _provinceDal.Add(province);

            return new SuccessResult(Messages.ProvinceAdded);
        }

        public IResult Delete(Province province)
        {
            _provinceDal.Delete(province);
            return new SuccessResult(Messages.ProvinceDeleted);
        }

        public IDataResult<List<Province>> GetAll()
        {
            return new SuccessDataResult<List<Province>>(_provinceDal.GetAll(), Messages.ProvinceGetAll);
        }

        public IDataResult<Province> GetById(int id)
        {
            return new SuccessDataResult<Province>(_provinceDal.Get(b => b.Id == id), Messages.ProvinceGetById);

        }

        public IResult Update(Province province)
        {
            _provinceDal.Update(province);
            return new SuccessResult(Messages.ProvinceUpdated);
        }
    }
}
