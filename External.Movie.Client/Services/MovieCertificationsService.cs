using External.Communications.Client;
using External.Movie.Client.Contracts;
using External.Movie.Client.Responses;
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
    public class MovieCertificationsService : IMovieCertificationsServices
    {
        private readonly IBaseClient baseClient;
        public MovieCertificationsService(IBaseClient _baseClient)
        {

            baseClient = _baseClient;
        }

        public async Task<MovieCertificationResponse> GetMovieCertifications(string key, string uri)
        {
            var client = baseClient.InitializeClient();
            var action = new Uri(uri + string.Format("certification/movie/list?api_key={0}", key));
            var dataObjects = new MovieCertificationResponse();

            using (var response = await client.GetAsync(action))
            {
                response.EnsureSuccessStatusCode();
                if (response.IsSuccessStatusCode)
                {
                    dataObjects = JsonConvert.DeserializeObject<MovieCertificationResponse>(response.Content.ReadAsStringAsync().Result);
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

        public async Task<MovieCertificationResponse> GetTVCertifications(string key, string uri)
        {
            var client = baseClient.InitializeClient();
            var action = new Uri(uri + string.Format("certification/tv/list?api_key=", key));
            var dataObjects = new MovieCertificationResponse();

            using (var response = await client.GetAsync(action))
            {
                response.EnsureSuccessStatusCode();
                if (response.IsSuccessStatusCode)
                {
                    dataObjects = JsonConvert.DeserializeObject<MovieCertificationResponse>(response.Content.ReadAsStringAsync().Result);
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
