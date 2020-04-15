
using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using API.Models.Movie;
using External.Movie.Client.Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CertificationsController : ControllerBase
    {
        public static string _Key;
        public static string _URI;
        public CertificationsController(IConfiguration configuration, IMovieCertificationsServices certifications)
        {
            _configuration = configuration;
            _certifications = certifications;
            _Key = _configuration["MovieAPI:Key"];
            _URI = _configuration["MovieAPI:URI"];
        }

        public IConfiguration _configuration { get; set; }
        private readonly IMovieCertificationsServices _certifications;


        [HttpGet]
        [Route("Movie")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<IActionResult> Movie()
        {
            var content = await _certifications.GetMovieCertifications(_Key, _URI);

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
                return Ok();
            }
        }

        [HttpGet]
        [Route("TV")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<IActionResult> TV()
        {
            var content = await _certifications.GetTVCertifications(_Key, _URI);

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
                return Ok();
            }
        }
    }
}