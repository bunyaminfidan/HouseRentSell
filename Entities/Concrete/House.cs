using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class House : IEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public Decimal Price { get; set; }
        public int Gross { get; set; }
        public int BuildingAge { get; set; }
        public bool CreditAvailable { get; set; }
        public bool Furniture { get; set; }
        public bool Balcony { get; set; }
        public string Description { get; set; }
        public int SaleTypeId { get; set; }
        public int AdressId { get; set; }
        public int HeatingTypeId { get; set; }



    }
}
