using System;
using System.Collections.Generic;
using System.Text;

namespace Ranat.Proxy.YouDaoTranslation
{
    /// <summary>
    ///  返回码
    /// </summary>
    public enum ErrorCode
    {
        /// <summary>
        /// 正常
        /// </summary>
        Success = 0,

        /// <summary>
        /// 要翻译的文本过长
        /// </summary>
        ContentTooLong = 20,

        /// <summary>
        /// 无法进行有效的翻译
        /// </summary>
        FailToTranslate = 30,

        /// <summary>
        /// 不支持的语言类型
        /// </summary>
        LanguageNotSupported = 40,

        /// <summary>
        /// 无效的key
        /// </summary>
        InvalidKey = 50,

        /// <summary>
        /// 无词典结果,仅在获取词典结果生效
        /// </summary>
        FailToLookup = 60,
    }
}
