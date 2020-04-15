
using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using API.Models.Movie;
using External.Movie.Client.Contracts;
using External.Movie.Client.Responses.Base;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CertificationsController : ControllerBase
    {
        public CertificationsController(IConfiguration configuration, IMovieCertificationsServices certifications)
        {
            _configuration = configuration;
            _certifications = certifications;
        }

        public IConfiguration _configuration { get; set; }
        private readonly IMovieCertificationsServices _certifications;


        [HttpGet]
        [Route("Movie")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<ActionResult<BaseResponse>> Movie()
        {
            var content = await _certifications.GetMovieCertifications();
                
            if (content.BaseResponse.StatusCode == HttpStatusCode.Unauthorized)
            {
                return Unauthorized(content.BaseResponse);
            }
            else if (content.BaseResponse.StatusCode == HttpStatusCode.BadRequest)
            {
                return BadRequest(content.BaseResponse);
            }
            else
            {
                return Ok(content);
            }
        }

        [HttpGet]
        [Route("TV")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<ActionResult> TV()
        {
            var content = await _certifications.GetTVCertifications();

            if (content.BaseResponse.StatusCode == HttpStatusCode.Unauthorized)
            {
                return Unauthorized(content.BaseResponse);
            }
            else if (content.BaseResponse.StatusCode == HttpStatusCode.BadRequest)
            {
                return BadRequest(content.BaseResponse);
            }
            else
            {
                return Ok(content);
            }
        }
    }
}