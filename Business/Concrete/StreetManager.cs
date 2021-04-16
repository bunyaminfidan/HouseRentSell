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
    public class StreetManager : IStreetService
    {
        private IStreetDal _streetDal;

        public StreetManager(IStreetDal streetDal)
        {
            _streetDal = streetDal;

        }
        public IResult Add(Street street)
        {
            _streetDal.Add(street);

            return new SuccessResult(Messages.StreetAdded);
        }

        public IResult Delete(Street street)
        {
            _streetDal.Delete(street);
            return new SuccessResult(Messages.StreetDeleted);
        }

        public IDataResult<List<Street>> GetAll()
        {
            return new SuccessDataResult<List<Street>>(_streetDal.GetAll(), Messages.StreetGetAll);
        }

        public IDataResult<Street> GetById(int id)
        {
            return new SuccessDataResult<Street>(_streetDal.Get(b => b.Id == id), Messages.StreetGetById);
        }

        public IResult Update(Street street)
        {
            _streetDal.Update(street);
            return new SuccessResult(Messages.StreetUpdated);
        }
    }
}
