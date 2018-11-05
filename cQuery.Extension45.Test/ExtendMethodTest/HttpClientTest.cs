using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using cQuery.Extension.ExtendMethods;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace cQuery.Extension45.Test.ExtendMethodTest
{
    [TestClass]
    public class HttpClientTest
    {
        [TestMethod]
        public void GetAsyncExtTest()
        {
            using (var client = new HttpClient())
            {
                var paras = new Dictionary<string, string>
                {
                    {"username", "admin"}
                };
                var response = client.GetAsyncExt("http://localhost:8010/user/GetApiBaseUrlByUser",paras).Result;
                Assert.AreEqual(response.StatusCode , HttpStatusCode.OK);
            }
        }

        [TestMethod]
        public void PostAsyncExtTest()
        {
            using (var client = new HttpClient())
            {
                var response = client.PostAsyncExt("http://localhost:8010/user/sync").Result;
                Assert.AreEqual(response.StatusCode , HttpStatusCode.OK);
            }
        }
    }
}
