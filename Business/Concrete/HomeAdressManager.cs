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
    public class HomeAdressManager : IHomeAdressService
    {
        private IHomeAdressDal _homeAdressDal;

        public HomeAdressManager(IHomeAdressDal homeAdressDal)
        {
            _homeAdressDal = homeAdressDal;
        }
        public IResult Add(HomeAdress homeAdress)
        {
            _homeAdressDal.Add(homeAdress);

            return new SuccessResult(Messages.HomeAdressAdded);
        }

        public IResult Delete(HomeAdress homeAdress)
        {
            _homeAdressDal.Delete(homeAdress);
            return new SuccessResult(Messages.HomeAdressDeleted);
        }

        public IDataResult<List<HomeAdress>> GetAll()
        {
            return new SuccessDataResult<List<HomeAdress>>(_homeAdressDal.GetAll(), Messages.HomeAdressGetAll);
        }

        public IDataResult<HomeAdress> GetById(int id)
        {
            return new SuccessDataResult<HomeAdress>(_homeAdressDal.Get(b => b.Id == id), Messages.HomeAdressGetById);
        }

        public IResult Update(HomeAdress homeAdress)
        {
            _homeAdressDal.Update(homeAdress);
            return new SuccessResult(Messages.HomeAdressUpdated);
        }
    }
}
