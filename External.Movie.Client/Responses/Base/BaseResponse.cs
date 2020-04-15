using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;

namespace External.Movie.Client.Responses.Base
{
    public class BaseResponse
    {
        public HttpStatusCode StatusCode { get; set; }
        public bool IsSuccessStatusCode { get; set; }
        public HttpResponseMessage Message { get; set; }
       
    }
}