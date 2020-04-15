using External.Communications.Client;
using External.Movie.Client.Contracts;
using External.Movie.Client.Requests.BaseRequest;
using External.Movie.Client.Services;
using External.Movie.Client.Services.Base;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Configurations
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {
            services.AddScoped<IMovieCertificationsServices, MovieCertificationsService>();
            services.AddScoped<IBaseClient, BaseClient>();
            return services;
        }
    }
}
