using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ranat.Proxy.YouDaoTranslation;

namespace Ranta.Proxy.Test
{
    /// <summary>
    /// YouDaoTranslationProxyTest 的摘要说明
    /// </summary>
    [TestClass]
    public class YouDaoTranslationProxyTest
    {
        [TestMethod]
        public void TestTranslate()
        {
            string keyFrom = "";

            string apiKey = "";

            var response = YouDaoTranslationProxy.Translate("世界你好", keyFrom, apiKey);
        }
    }
}
