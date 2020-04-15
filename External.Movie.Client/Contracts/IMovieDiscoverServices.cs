using External.Movie.Client.Requests;
using External.Movie.Client.Responses;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace External.Movie.Client.Contracts
{
    public interface IMovieDiscoverServices
    {
        Task<MovieDiscoverResponse> DiscoverMovies(MovieDiscoverRequest movieDiscoverRequest);
        Task<MovieDiscoverResponse> DiscoverMovies();
    }
}
