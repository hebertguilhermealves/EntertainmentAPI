using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace External.Communications.Client
{
    public interface IBaseClient
    {
        HttpClient InitializeClient();
    }
}
