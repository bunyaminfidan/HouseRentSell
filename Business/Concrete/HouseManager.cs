using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using Core.Utilitis.Results;
using DataAccess.Abstract;
using DataAccess.Constans;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Concrete
{
    public class HouseManager : IHouseService
    {
        private IHouseDal _houseDal;

        public HouseManager(IHouseDal houseDal)
        {
            _houseDal = houseDal;

        }

        public IResult Add(House house)
        {
            _houseDal.Add(house);

            return new SuccessResult(Messages.HouseAdded);
        }

        public IResult Delete(House house)
        {
            _houseDal.Delete(house);
            return new SuccessResult(Messages.HouseDeleted);
        }

        public IDataResult<List<House>> GetAll()
        {
            return new SuccessDataResult<List<House>>(_houseDal.GetAll(), Messages.HouseGetAll);
        }

        public IDataResult<House> GetById(int id)
        {
            return new SuccessDataResult<House>(_houseDal.Get(b => b.Id == id), Messages.HouseGetById);
        }

        public IDataResult<List<HouseDetail>> GetAllHouseDetails()
        {
            return new SuccessDataResult<List<HouseDetail>>(_houseDal.GetHouseDetails(), Messages.HouseGetById);
       
        }

        public IResult Update(House house)
        {
            _houseDal.Update(house);
            return new SuccessResult(Messages.HouseDeleted);
        }
    }
}
