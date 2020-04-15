using External.Communications.Client;
using External.Movie.Client.Contracts;
using External.Movie.Client.Requests;
using External.Movie.Client.Responses;
using External.Movie.Client.Services.Base;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace External.Movie.Client.Services
{
    public class MovieDiscoverService : BaseService, IMovieDiscoverServices
    {
        private readonly IBaseClient baseClient;
        private readonly IConfiguration _configuration;
        public MovieDiscoverService(IConfiguration configuration,
                                           IBaseClient _baseClient) : base(configuration)
        {
            baseClient = _baseClient;
            _configuration = configuration;
        }
       
        private Dictionary<string, string> _propertyMapping =
          new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
          {
               { "Language",  ""  },
               { "MainCategory", "" },
               { "Age",  "" },
               { "Name",  ""  }
          };

        public async Task<MovieDiscoverResponse> DiscoverMovies()
        {
            var client = baseClient.InitializeClient();
            var action = new Uri(base.baseRequest.BaseURI + string.Format("discover/movie?api_key={0}", base.baseRequest.ApiKey));
            var dataObjects = new MovieDiscoverResponse();

            using (var response = await client.GetAsync(action))
            {
                response.EnsureSuccessStatusCode();
                if (response.IsSuccessStatusCode)
                {
                    dataObjects = JsonConvert.DeserializeObject<MovieDiscoverResponse>(response.Content.ReadAsStringAsync().Result);
                    dataObjects.StatusCode = response.StatusCode;
                    dataObjects.IsSuccessStatusCode = response.IsSuccessStatusCode;
                }
                else if (response.StatusCode == HttpStatusCode.Unauthorized)
                {
                    dataObjects.StatusCode = response.StatusCode;
                    dataObjects.IsSuccessStatusCode = response.IsSuccessStatusCode;

                }
                else if (response.StatusCode == HttpStatusCode.BadRequest)
                {
                    dataObjects.StatusCode = response.StatusCode;
                    dataObjects.IsSuccessStatusCode = response.IsSuccessStatusCode;
                }
            }

            return dataObjects;
        }

        public async Task<MovieDiscoverResponse> DiscoverMovies(MovieDiscoverRequest movieDiscoverRequest)
        {
        //     public string Language { get; set; }
        //public string Region { get; set; }
        //[JsonProperty("Sort_By")]
        //public string SortBy { get; set; }
        //[JsonProperty("Certification_country")]
        //public string CertificationCountry { get; set; }
        //public string Page { get; set; }


        var client = baseClient.InitializeClient();
            var action = new Uri(base.baseRequest.BaseURI + string.Format("discover/movie?api_key={0}", base.baseRequest.ApiKey));
            var parameters = string.Empty;

            if (!string.IsNullOrWhiteSpace(movieDiscoverRequest.Language))
            {
                parameters += string.Format("&language={0}", movieDiscoverRequest.Language);
            }
            if (!string.IsNullOrWhiteSpace(movieDiscoverRequest.CertificationCountry))
            {
                parameters += string.Format("&certification_country={0}", movieDiscoverRequest.CertificationCountry);
            }



            var dataObjects = new MovieDiscoverResponse();

            using (var response = await client.GetAsync(action))
            {
                response.EnsureSuccessStatusCode();
                if (response.IsSuccessStatusCode)
                {
                    dataObjects = JsonConvert.DeserializeObject<MovieDiscoverResponse>(response.Content.ReadAsStringAsync().Result);
                    dataObjects.StatusCode = response.StatusCode;
                    dataObjects.IsSuccessStatusCode = response.IsSuccessStatusCode;
                }
                else if (response.StatusCode == HttpStatusCode.Unauthorized)
                {
                    dataObjects.StatusCode = response.StatusCode;
                    dataObjects.IsSuccessStatusCode = response.IsSuccessStatusCode;

                }
                else if (response.StatusCode == HttpStatusCode.BadRequest)
                {
                    dataObjects.StatusCode = response.StatusCode;
                    dataObjects.IsSuccessStatusCode = response.IsSuccessStatusCode;
                }
            }

            return dataObjects;
        }

    }
}
