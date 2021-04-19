using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities;

namespace Entities.Concrete
{
    public class HomeAdress : IEntity
    {
        public int Id { get; set; }
        public int HomeId { get; set; }
        public int ProvinceId { get; set; }
        public int DistrictId { get; set; }
        public int NeighborhoodId { get; set; }
        public int ApartmentBuilding { get; set; }
        public int Floor { get; set; }
        public int DoorNumber { get; set; }

    }
}
