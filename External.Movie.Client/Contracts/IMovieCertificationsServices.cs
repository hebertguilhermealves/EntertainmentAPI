using External.Movie.Client.Responses;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace External.Movie.Client.Contracts
{
    public interface IMovieCertificationsServices
    {
        Task<MovieCertificationResponse> GetMovieCertifications();
        Task<MovieCertificationResponse> GetTVCertifications();
    }
}
