using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfHouseDal : EfEntityRepositoryBase<House, HouseRentSellDatabaseContext>, IHouseDal
    {


        public List<HouseDetail> GetHouseDetails(Expression<Func<House, bool>> filter = null)
        {
            using (HouseRentSellDatabaseContext context = new HouseRentSellDatabaseContext())
            {

                var result = from house in filter is null ? context.Houses : context.Houses.Where(filter)

                             join homeAdress in context.HomeAdresses
                                 on house.AdressId equals homeAdress.Id

                             join province in context.Provinces
                                 on homeAdress.ProvinceId equals province.Id

                             join district in context.Districts
                                 on homeAdress.DistrictId equals district.Id

                             join neighborhood in context.Neighborhoods
                                 on homeAdress.NeighborhoodId equals neighborhood.Id

                             join heatingType in context.HeatingTypes
                                 on house.HeatingTypeId equals heatingType.Id

                             join saleType in context.SaleTypes
                                 on house.SaleTypeId equals saleType.Id


                             select new HouseDetail
                             {
                                 Id = house.Id,
                                 Title = house.Title,
                                 Price = house.Price,
                                 Gross = house.Gross,
                                 BuildingAge = house.BuildingAge,
                                 CreditAvailable = house.CreditAvailable,
                                 Furniture = house.Furniture,
                                 Balcony = house.Balcony,
                                 Description = house.Description,
                                 SaleTypeName = saleType.TypeName,
                                 HeatingTypeName = heatingType.HeatingName,
                                 ProvinceName = province.ProvinceName,
                                 DistrictName = district.DistrictName,
                                 NeighborhoodName = neighborhood.NeighborhoodName,
                                 ApartmentBuilding = homeAdress.ApartmentBuilding,
                                 Floor = homeAdress.Floor,
                                 DoorNumber = homeAdress.DoorNumber

                             };
                return result.ToList();









            }

        }
    }
}
