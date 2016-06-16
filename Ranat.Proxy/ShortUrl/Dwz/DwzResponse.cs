using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ranat.Proxy.ShortUrl
{
    /// <summary>
    /// Dwz响应内容
    /// </summary>
    public class DwzResponse
    {
        /// <summary>
        /// 短链Url
        /// </summary>
        [JsonProperty("tinyurl")]
        public string TinyUrl { get; set; }

        /// <summary>
        /// 处理结果状态
        /// </summary>
        [JsonProperty("status")]
        public int Status { get; set; }

        /// <summary>
        /// 长链Url
        /// </summary>
        [JsonProperty("longurl")]
        public string LongUrl { get; set; }

        /// <summary>
        /// 错误消息
        /// </summary>
        [JsonProperty("err_msg")]
        public string ErrorMessage { get; set; }
    }
}
