using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ranat.Proxy.ShortUrl
{
    public class DwzResponse
    {
        [JsonProperty("tinyurl")]
        public string TinyUrl { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("longurl")]
        public string LongUrl { get; set; }

        [JsonProperty("err_msg")]
        public string ErrorMessage { get; set; }
    }
}
