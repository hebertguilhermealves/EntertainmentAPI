using External.Movie.Client.Responses.Base;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace External.Movie.Client.Responses
{
    public class MovieCertificationResponse : BaseResponse
    {
        public MovieCertificationResponse Certifications { get; set; }
        public List<US> US { get; set; }
        public List<CA> CA { get; set; }
        public List<AU> AU { get; set; }
        public List<DE> DE { get; set; }
        public List<FR> FR { get; set; }
        public List<NZ> NZ { get; set; }
        public List<IN> IN { get; set; }
        public List<GB> GB { get; set; }
        public List<NL> NL { get; set; }
        public List<BR> BR { get; set; }
        public List<FI> FI { get; set; }
        public List<BG> BG { get; set; }
        public List<ES> ES { get; set; }
        public List<PT> PT { get; set; }
        public List<MY> MY { get; set; }
        [JsonProperty("CA-QC")]
        public List<CAQC> CAQC { get; set; }
        public List<SE> SE { get; set; }
        public List<DK> DK { get; set; }
        public List<NO> NO { get; set; }
        public List<HU> HU { get; set; }
        public List<LT> LT { get; set; }
        public List<RU> RU { get; set; }
        public List<PH> PH { get; set; }
        public List<IT> IT { get; set; }
    }
}
public class US
{
    public string certification { get; set; }
    public string meaning { get; set; }
    public int order { get; set; }
}

public class CA
{
    public string certification { get; set; }
    public string meaning { get; set; }
    public int order { get; set; }
}

public class AU
{
    public string certification { get; set; }
    public string meaning { get; set; }
    public int order { get; set; }
}

public class DE
{
    public string certification { get; set; }
    public string meaning { get; set; }
    public int order { get; set; }
}

public class FR
{
    public string certification { get; set; }
    public string meaning { get; set; }
    public int order { get; set; }
}

public class NZ
{
    public string certification { get; set; }
    public string meaning { get; set; }
    public int order { get; set; }
}

public class IN
{
    public string certification { get; set; }
    public string meaning { get; set; }
    public int order { get; set; }
}

public class GB
{
    public string certification { get; set; }
    public string meaning { get; set; }
    public int order { get; set; }
}

public class NL
{
    public string certification { get; set; }
    public string meaning { get; set; }
    public int order { get; set; }
}

public class BR
{
    public string certification { get; set; }
    public string meaning { get; set; }
    public int order { get; set; }
}

public class FI
{
    public string certification { get; set; }
    public string meaning { get; set; }
    public int order { get; set; }
}

public class BG
{
    public string certification { get; set; }
    public string meaning { get; set; }
    public int order { get; set; }
}

public class ES
{
    public string certification { get; set; }
    public string meaning { get; set; }
    public int order { get; set; }
}

public class PT
{
    public string certification { get; set; }
    public string meaning { get; set; }
    public int order { get; set; }
}

public class MY
{
    public string certification { get; set; }
    public string meaning { get; set; }
    public int order { get; set; }
}


public class CAQC
{
    public string certification { get; set; }
    public string meaning { get; set; }
    public int order { get; set; }
}

public class SE
{
    public string certification { get; set; }
    public string meaning { get; set; }
    public int order { get; set; }
}

public class DK
{
    public string certification { get; set; }
    public string meaning { get; set; }
    public int order { get; set; }
}

public class NO
{
    public string certification { get; set; }
    public string meaning { get; set; }
    public int order { get; set; }
}

public class HU
{
    public string certification { get; set; }
    public string meaning { get; set; }
    public int order { get; set; }
}

public class LT
{
    public string certification { get; set; }
    public string meaning { get; set; }
    public int order { get; set; }
}

public class RU
{
    public string certification { get; set; }
    public string meaning { get; set; }
    public int order { get; set; }
}

public class PH
{
    public string certification { get; set; }
    public string meaning { get; set; }
    public int order { get; set; }
}

public class IT
{
    public string certification { get; set; }
    public string meaning { get; set; }
    public int order { get; set; }
}


