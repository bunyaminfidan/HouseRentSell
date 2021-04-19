using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Abstract
{
   public interface IHouseDal : IEntityRepository<House>
    {
        List<HouseDetail> GetHouseDetails(Expression<Func<House, bool>> filter = null);
    }
}
