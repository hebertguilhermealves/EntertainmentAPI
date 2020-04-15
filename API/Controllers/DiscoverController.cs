using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using External.Movie.Client.Contracts;
using External.Movie.Client.Requests;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiscoverController : ControllerBase
    {
        private readonly IMovieDiscoverServices _movieDiscoverServices;
        public DiscoverController(IMovieDiscoverServices movieDiscoverServices)
        {
            _movieDiscoverServices = movieDiscoverServices;
        }

        [HttpGet]
        [Route("Movie")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<IActionResult> Movie()
        {
            var content = await _movieDiscoverServices.DiscoverMovies();

            if (content.StatusCode == HttpStatusCode.Unauthorized)
            {
                return Unauthorized();
            }
            else if (content.StatusCode == HttpStatusCode.BadRequest)
            {
                return BadRequest();
            }
            else
            {
                return Ok(content);
            }
        }

        [HttpGet]
        [Route("DiscoverMovie")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<IActionResult> Movie(
             [FromQuery] MovieDiscoverRequest movieDiscoverRequest)
        {
            var content = await _movieDiscoverServices.DiscoverMovies(movieDiscoverRequest);

            if (content.StatusCode == HttpStatusCode.Unauthorized)
            {
                return Unauthorized();
            }
            else if (content.StatusCode == HttpStatusCode.BadRequest)
            {
                return BadRequest();
            }
            else
            {
                return Ok(content);
            }
        }
    }
}