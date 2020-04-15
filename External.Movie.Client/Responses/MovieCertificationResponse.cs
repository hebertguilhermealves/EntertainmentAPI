using External.Movie.Client.Responses.Base;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace External.Movie.Client.Responses
{
    public class MovieCertificationResponse
    {
        public Certification Certifications { get; set; }
        public BaseResponse BaseResponse { get; set; } = new BaseResponse();

    }
}
public class Certification
{
    [JsonProperty("US")]
    public List<Item> US { get; set; }
    [JsonProperty("CA")]
    public List<Item> CA { get; set; }
    [JsonProperty("AU")]
    public List<Item> AU { get; set; }
    [JsonProperty("DE")]
    public List<Item> DE { get; set; }
    [JsonProperty("FR")]
    public List<Item> FR { get; set; }
    [JsonProperty("NZ")]
    public List<Item> NZ { get; set; }
    [JsonProperty("IN")]
    public List<Item> IN { get; set; }
    [JsonProperty("GB")]
    public List<Item> GB { get; set; }
    [JsonProperty("NL")]
    public List<Item> NL { get; set; }
    [JsonProperty("BR")]
    public List<Item> BR { get; set; }
    [JsonProperty("FI")]
    public List<Item> FI { get; set; }
    [JsonProperty("BG")]
    public List<Item> BG { get; set; }
    [JsonProperty("ES")]
    public List<Item> ES { get; set; }
    [JsonProperty("PT")]
    public List<Item> PT { get; set; }
    [JsonProperty("MY")]
    public List<Item> MY { get; set; }
    [JsonProperty("CA-QC")]
    public List<Item> CAQC { get; set; }
    [JsonProperty("SE")]
    public List<Item> SE { get; set; }
    [JsonProperty("DK")]
    public List<Item> DK { get; set; }
    [JsonProperty("NO")]
    public List<Item> NO { get; set; }
    [JsonProperty("HU")]
    public List<Item> HU { get; set; }
    [JsonProperty("LT")]
    public List<Item> LT { get; set; }
    [JsonProperty("RU")]
    public List<Item> RU { get; set; }
    [JsonProperty("PH")]
    public List<Item> PH { get; set; }
    [JsonProperty("IT")]
    public List<Item> IT { get; set; }

}
public class Item
{
    public string certification { get; set; }
    public string meaning { get; set; }
    public int order { get; set; }
}
