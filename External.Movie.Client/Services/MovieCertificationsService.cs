using External.Communications.Client;
using External.Movie.Client.Contracts;
using External.Movie.Client.Requests.BaseRequest;
using External.Movie.Client.Responses;
using External.Movie.Client.Services.Base;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace External.Movie.Client.Services
{
    public class MovieCertificationsService : BaseService, IMovieCertificationsServices
    {
       
        private readonly IBaseClient baseClient;
        private readonly IConfiguration _configuration;
        public MovieCertificationsService(IConfiguration configuration,
                                           IBaseClient _baseClient) : base(configuration)
        {
            baseClient = _baseClient;
            _configuration = configuration;
        }

        public async Task<MovieCertificationResponse> GetMovieCertifications()
        {
            var client = baseClient.InitializeClient();
            var action = new Uri(base.baseRequest.BaseURI + string.Format("certification/movie/list?api_key={0}", base.baseRequest.ApiKey));
            var dataObjects = new MovieCertificationResponse();

            using (var response = await client.GetAsync(action))
            {
                response.EnsureSuccessStatusCode();
                if (response.IsSuccessStatusCode)
                {
                    dataObjects = JsonConvert.DeserializeObject<MovieCertificationResponse>(response.Content.ReadAsStringAsync().Result);
                    dataObjects.BaseResponse.StatusCode = response.StatusCode;
                    dataObjects.BaseResponse.IsSuccessStatusCode = response.IsSuccessStatusCode;
                }
                else if (response.StatusCode == HttpStatusCode.Unauthorized)
                {
                    dataObjects.BaseResponse.StatusCode = response.StatusCode;
                    dataObjects.BaseResponse.IsSuccessStatusCode = response.IsSuccessStatusCode;

                }
                else if (response.StatusCode == HttpStatusCode.BadRequest)
                {
                    dataObjects.BaseResponse.StatusCode = response.StatusCode;
                    dataObjects.BaseResponse.IsSuccessStatusCode = response.IsSuccessStatusCode;
                }
            }

            return dataObjects;
        }

        public async Task<MovieCertificationResponse> GetTVCertifications()
        {
            var client = baseClient.InitializeClient();
            var action = new Uri(base.baseRequest.BaseURI + string.Format("certification/tv/list?api_key={0}", base.baseRequest.ApiKey));
            var dataObjects = new MovieCertificationResponse();

            using (var response = await client.GetAsync(action))
            {
                response.EnsureSuccessStatusCode();
                if (response.IsSuccessStatusCode)
                {
                    dataObjects = JsonConvert.DeserializeObject<MovieCertificationResponse>(response.Content.ReadAsStringAsync().Result);
                    dataObjects.BaseResponse.StatusCode = response.StatusCode;
                    dataObjects.BaseResponse.IsSuccessStatusCode = response.IsSuccessStatusCode;
                }
                else if (response.StatusCode == HttpStatusCode.Unauthorized)
                {
                    dataObjects.BaseResponse.StatusCode = response.StatusCode;
                    dataObjects.BaseResponse.IsSuccessStatusCode = response.IsSuccessStatusCode;

                }
                else if (response.StatusCode == HttpStatusCode.BadRequest)
                {
                    dataObjects.BaseResponse.StatusCode = response.StatusCode;
                    dataObjects.BaseResponse.IsSuccessStatusCode = response.IsSuccessStatusCode;
                }
            }

            return dataObjects;
        }
    }
}
