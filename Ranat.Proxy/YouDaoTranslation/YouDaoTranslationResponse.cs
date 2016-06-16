using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ranat.Proxy.YouDaoTranslation
{
    public class YouDaoTranslationResponse
    {
        /// <summary>
        /// 返回码
        /// </summary>
        [JsonProperty("errorCode")]
        public ErrorCode ErrorCode { get; set; }

        /// <summary>
        /// 原文
        /// </summary>
        [JsonProperty("query")]
        public string Query { get; set; }

        /// <summary>
        /// 有道翻译
        /// </summary>
        [JsonProperty("translation")]
        public List<string> Translation { get; set; }
    }
}
