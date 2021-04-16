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
    public class NeighborhoodManager : INeighborhoodService
    {
        private INeighborhoodDal _neighborhoodDal;

        public NeighborhoodManager(INeighborhoodDal neighborhoodDal)
        {
            _neighborhoodDal = neighborhoodDal;

        }

        public IResult Add(Neighborhood neighborhood)
        {
            _neighborhoodDal.Add(neighborhood);

            return new SuccessResult(Messages.NeighborhoodAdded);
        }

        public IResult Delete(Neighborhood neighborhood)
        {
            _neighborhoodDal.Delete(neighborhood);
            return new SuccessResult(Messages.NeighborhoodDeleted);
        }

        public IDataResult<List<Neighborhood>> GetAll()
        {
            return new SuccessDataResult<List<Neighborhood>>(_neighborhoodDal.GetAll(), Messages.NeighborhoodGetAll);
        }

        public IDataResult<Neighborhood> GetById(int id)
        {
            return new SuccessDataResult<Neighborhood>(_neighborhoodDal.Get(b => b.Id == id), Messages.NeighborhoodGetById);
        }

        public IResult Update(Neighborhood neighborhood)
        {
            _neighborhoodDal.Update(neighborhood);
            return new SuccessResult(Messages.NeighborhoodUpdated);
        }
    }
}
