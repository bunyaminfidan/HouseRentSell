using Core.Entities.Concrete;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class HouseRentSellDatabaseContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=HouseRentSell;Trusted_Connection=true");
        }

        public DbSet<User> Users { get; set; }
        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }
        public DbSet<District> Districts { get; set; }
        public DbSet<HeatingType> HeatingTypes { get; set; }
        public HomeAdress HomeAdresses { get; set; }
        public DbSet<HomeImage> HomeImages { get; set; }
        public DbSet<House> Houses { get; set; }
        public DbSet<Neighborhood> Neighborhoods { get; set; }
        public DbSet<Province> Provinces { get; set; }
        public DbSet<SaleType> SaleTypes { get; set; }
        public DbSet<Seller> Sellers { get; set; }
        public DbSet<Street> Streets { get; set; }

    }
}
