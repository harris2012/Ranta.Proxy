using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ranat.Proxy.ShortUrl;

namespace Ranta.Proxy.Test
{
    [TestClass]
    public class DwzProxyTest
    {
        [TestMethod]
        public void TestGetShortUrl()
        {
            var url1 = DwzProxy.GetShortUrl("https://www.savory.cn");

            var url2 = DwzProxy.GetShortUrl("https://www.baidu.com");

            Assert.IsTrue(string.IsNullOrEmpty(url1));

            Assert.IsFalse(string.IsNullOrEmpty(url2));
        }
    }
}
