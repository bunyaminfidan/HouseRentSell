using Autofac;
using Autofac.Extras.DynamicProxy;
using Business.Abstract;
using Business.Concrete;
using Castle.DynamicProxy;
using Core.Utilitis.Interceptors;
using Core.Utilitis.Security.JWT;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;


namespace Business.DependencyResolves.Autofac
{
    public class AutofacBusinessModule : Module
    {

        protected override void Load(ContainerBuilder builder)
        {

            builder.RegisterType<DistrictManager>().As<IDistrictService>().SingleInstance();
            builder.RegisterType<EfDistrictDal>().As<IDistrictDal>().SingleInstance();

            builder.RegisterType<HeatingTypeManager>().As<IHeatingTypeService>().SingleInstance();
            builder.RegisterType<EfHeatingTypeDal>().As<IHeatingTypeDal>().SingleInstance();

            builder.RegisterType<HomeAdressManager>().As<IHomeAdressService>().SingleInstance();
            builder.RegisterType<EfHomeAdressDal>().As<IHomeAdressDal>().SingleInstance();

            builder.RegisterType<HomeImageManager>().As<IHomeImageService>().SingleInstance();
            builder.RegisterType<EfHomeImageDal>().As<IHomeImageDal>().SingleInstance();

            builder.RegisterType<HouseManager>().As<IHouseService>().SingleInstance();
            builder.RegisterType<EfHouseDal>().As<IHouseDal>().SingleInstance();

            builder.RegisterType<UserManager>().As<IUserService>().SingleInstance();
            builder.RegisterType<EfUserDal>().As<IUserDal>().SingleInstance();

            builder.RegisterType<NeighborhoodManager>().As<INeighborhoodService>().SingleInstance();
            builder.RegisterType<EfNeighborhoodDal>().As<INeighborhoodDal>().SingleInstance();

            builder.RegisterType<ProvinceManager>().As<IProvinceService>().SingleInstance();
            builder.RegisterType<EfProvinceDal>().As<IProvinceDal>().SingleInstance();


            builder.RegisterType<SaleTypeManager>().As<ISaleTypeService>().SingleInstance();
            builder.RegisterType<EfSaleTypeDal>().As<ISaleTypeDal>().SingleInstance();


            builder.RegisterType<SellerManager>().As<ISellerService>().SingleInstance();
            builder.RegisterType<EfSellerDal>().As<ISellerDal>().SingleInstance();

            builder.RegisterType<UserManager>().As<IUserService>().SingleInstance();
            builder.RegisterType<EfUserDal>().As<IUserDal>().SingleInstance();

            builder.RegisterType<AuthManager>().As<IAuthService>();
            builder.RegisterType<JwtHelper>().As<ITokenHelper>();


            var assembly = System.Reflection.Assembly.GetExecutingAssembly();
            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();


        }
    }
}
