using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
  public  class HouseDetail
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
        public string SaleTypeName { get; set; }
        public string ProvinceName { get; set; }
        public string  DistrictName { get; set; }
        public string NeighborhoodName { get; set; }
        public int ApartmentBuilding { get; set; }
        public int Floor { get; set; }
        public int DoorNumber { get; set; }
        public string HeatingTypeName { get; set; }



    }
}
