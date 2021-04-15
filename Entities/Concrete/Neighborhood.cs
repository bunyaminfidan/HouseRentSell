using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Neighborhood : IEntity
    {
        public int Id { get; set; }
        public string NeighborhoodName { get; set; }
    }
}
