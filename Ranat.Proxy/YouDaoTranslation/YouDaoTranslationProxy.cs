using Ranta.Utility;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace Ranat.Proxy.YouDaoTranslation
{
    /// <summary>
    /// 有道翻译代理
    /// </summary>
    public static class YouDaoTranslationProxy
    {
        private const string Host = "http://fanyi.youdao.com/openapi.do";

        /// <summary>
        /// 使用有道翻译进行翻译
        /// </summary>
        /// <param name="content">要翻译的文本，必须是UTF-8编码，字符长度不能超过200个字符，需要进行urlencode编码</param>
        /// <param name="apiKey">有道ApiKey，需要自己去申请</param>
        /// <param name="keyFrom">有道KeyFrom，需要自己去申请</param>
        /// <returns>翻译的结果</returns>
        public static YouDaoTranslationResponse Translate(string content, string keyFrom, string apiKey)
        {
            string result = string.Empty;

            NameValueCollection collection = new NameValueCollection();

            collection.Add("keyfrom", keyFrom);
            collection.Add("key", apiKey);
            collection.Add("type", "data");
            collection.Add("doctype", "json");
            collection.Add("version", "1.1");
            collection.Add("q", content);
            collection.Add("only", "translate");

            YouDaoTranslationResponse returnValue = RestfulUtility.GetJson<YouDaoTranslationResponse>(Host, collection);

            return returnValue;
        }
    }
}
