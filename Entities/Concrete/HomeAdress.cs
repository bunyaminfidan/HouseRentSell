using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class HomeAdress : IEntity
    {
        public int Id { get; set; }
        public int HomeId { get; set; }
        public int Province { get; set; }
        public int District { get; set; }
        public int Neighborhood { get; set; }
        public int Street { get; set; }
        public int ApartmentBuilding { get; set; }
        public int Floor { get; set; }
        public int ApartmentNo { get; set; }

    }
}
