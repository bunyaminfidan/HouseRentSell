using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Business.Abstract;
using Core.Utilitis.Results;
using DataAccess.Abstract;
using DataAccess.Constans;
using Entities.Concrete;

namespace Business.Concrete
{
    public class HomeImageManager : IHomeImageService
    {
        private IHomeImageDal _homeImageDal;

        public HomeImageManager(IHomeImageDal homeImageDal)
        {
            _homeImageDal = homeImageDal;

        }

        public IResult Add(HomeImage homeImage)
        {
            _homeImageDal.Add(homeImage);

            return new SuccessResult(Messages.HomeImageAdded);
        }

        public IResult Delete(HomeImage homeImage)
        {
            _homeImageDal.Delete(homeImage);
            return new SuccessResult(Messages.HomeImageDeleted);
        }

        public IDataResult<List<HomeImage>> GetAll()
        {
            return new SuccessDataResult<List<HomeImage>>(_homeImageDal.GetAll(), Messages.HomeImageGetAll);
        }

        public IDataResult<HomeImage> GetById(int id)
        {
            return new SuccessDataResult<HomeImage>(_homeImageDal.Get(b => b.Id == id), Messages.HomeImageGetById);
        }

        public IResult Update(HomeImage homeImage)
        {
            _homeImageDal.Update(homeImage);
            return new SuccessResult(Messages.HomeImageUpdated);
        }
    }
}
