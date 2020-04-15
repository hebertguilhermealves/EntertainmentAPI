using External.Movie.Client.Contracts;
using External.Movie.Client.Requests.BaseRequest;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace External.Movie.Client.Services.Base
{
    public class BaseService
    {
        public BaseRequest baseRequest = new BaseRequest();

        public BaseService(IConfiguration configuration)
        {
            baseRequest.ApiKey = configuration["MovieAPI:Key"];
            baseRequest.BaseURI = configuration["MovieAPI:URI"];
        }
        
    }
}
