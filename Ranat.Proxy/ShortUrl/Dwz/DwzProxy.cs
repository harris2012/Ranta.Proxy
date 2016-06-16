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

        /// <summary>
        /// 获取短链Url
        /// </summary>
        /// <param name="longUrl">长链Url</param>
        /// <returns>短链Url，若dwz.cn不支持，则返回string.Empty</returns>
        public static string GetShortUrl(string longUrl)
        {
            string shortUrl = string.Empty;

            string requestContent = string.Format("url={0}", longUrl);

            var response = RestfulUtility.PostForJson<DwzResponse>(DwzHost, requestContent, ContentType.FormUrlEncoded);

            if (response.Status == 0)
            {
                shortUrl = response.TinyUrl;
            }

            return shortUrl;
        }

        /// <summary>
        /// 获取短链Url
        /// </summary>
        /// <param name="longUrl">长链Url</param>
        /// <returns>直接返回dwz.cn的响应</returns>
        public static DwzResponse GetDwzShortUrl(string longUrl)
        {
            string requestContent = string.Format("url={0}", longUrl);

            DwzResponse response = RestfulUtility.PostForJson<DwzResponse>(DwzHost, requestContent, ContentType.FormUrlEncoded);

            return response;
        }
    }
}
