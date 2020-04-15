using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace External.Movie.Client.Requests
{
    public class MovieDiscoverRequest
    {
        public string Language { get; set; }
        public string Region { get; set; }
        [JsonProperty("Sort_By")]
        public string SortBy { get; set; }
        [JsonProperty("Certification_country")]
        public string CertificationCountry { get; set; }
        public string Page { get; set; }
    }
}
