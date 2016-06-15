using Newtonsoft.Json;
using Ranta.Utility;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ranat.Proxy.ShortUrl
{
    /// <summary>
    /// dwz.cn提供的短网址服务
    /// </summary>
    public static class DwzProxy
    {
        private const string DwzHost = "http://dwz.cn/create.php";

        public static string GetShortUrl(string longUrl)
        {
            string url = string.Empty;

            //var dict = new Dictionary<string, string>();

            //dict.Add("url", longUrl);

            string requestContent = string.Format("url={0}", longUrl);

            var response = RestfulUtility.PostJson<string, DwzResponse>(DwzHost, requestContent);

            return url;
        }

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
}
