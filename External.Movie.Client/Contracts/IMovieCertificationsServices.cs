using External.Movie.Client.Responses;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace External.Movie.Client.Contracts
{
    public interface IMovieCertificationsServices
    {
        Task<MovieCertificationResponse> GetMovieCertifications(string key, string uri);
        Task<MovieCertificationResponse> GetTVCertifications(string key, string uri);
    }
}
