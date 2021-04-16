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
    public class HeatingTypeManager : IHeatingTypeService
    {
        private IHeatingTypeDal _heatingTypeDal;

        public HeatingTypeManager(IHeatingTypeDal heatingTypeDal)
        {
            _heatingTypeDal = heatingTypeDal;
        }
        public IResult Add(HeatingType heatingType)
        {
            _heatingTypeDal.Add(heatingType);

            return new SuccessResult(Messages.HeatingTypeAdded);
        }

        public IResult Delete(HeatingType heatingType)
        {
            _heatingTypeDal.Delete(heatingType);
            return new SuccessResult(Messages.HeatingTypeDeleted);
        }

        public IDataResult<List<HeatingType>> GetAll()
        {
            return new SuccessDataResult<List<HeatingType>>(_heatingTypeDal.GetAll(), Messages.HeatingTypeGetAll);
        }

        public IDataResult<HeatingType> GetById(int id)
        {
            return new SuccessDataResult<HeatingType>(_heatingTypeDal.Get(b => b.Id == id), Messages.HeatingTypeGetById);
        }

        public IResult Update(HeatingType heatingType)
        {
            _heatingTypeDal.Update(heatingType);
            return new SuccessResult(Messages.HeatingTypeUpdated);
        }
    }
}
