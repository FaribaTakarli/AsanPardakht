using AsanPardakht.BL.Core;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

namespace AsanPardakht.BL.Service.Config
{
    public static class DependencyInjection
    {
        public static void AddApiVersion(this IServiceCollection services)
        {
            // Add API Versioning to the Project
            services.AddApiVersioning(config =>
            {
                // Specify the default API Version as 1.0
                config.DefaultApiVersion = new ApiVersion(1, 0);
                // If the client hasn't specified the API version in the request, use the default API version number 
                config.AssumeDefaultVersionWhenUnspecified = true;
                // Advertise the API versions supported for the particular endpoint
                config.ReportApiVersions = true;
            });


        }

        //public static void AddAputoMapper(this IServiceCollection services)
        //{
        //    var mapperConfig = new MapperConfiguration(mc =>
        //    {
        //        mc.AddProfile(new MappingProfile());
        //    });

        //    IMapper mapper = mapperConfig.CreateMapper();
        //    services.AddSingleton(mapper);
        //    services.AddTransient<IUserInfo>(s => new UserInfoHandler(mapper));

        //}
    }
}
