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
            var url = DwzProxy.GetShortUrl("https://www.baidu.com");

            var x = 0;
        }
    }
}
