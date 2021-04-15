using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class HeatingType: IEntity
    {
        public int Id { get; set; }
        public string HeatingName { get; set; }
    }
}
