using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
  public  class Seller: IEntity
    {
        public int Id { get; set; }
        public String  SellerName { get; set; }
        public int UserId { get; set; }
    }
}
