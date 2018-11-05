using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace cQuery.Extension.ExtendMethods
{
    public static class HttpClientExtend
    {
        public static async Task<HttpResponseMessage> GetAsyncExt(this HttpClient client,string url,Dictionary<string,string> paras = null)
        {
            if (paras != null && paras.Count > 0)
            {
                url += "?";
                foreach (var item in paras)
                {
                    url += item.Key + "=" + item.Value + "&";
                }

                url = url.TrimEnd('&');
            }

            var result = await client.GetAsync(url);
            return result;
        }

        public static async Task<HttpResponseMessage> PostAsyncExt(this HttpClient client,string url,object data = null)
        {
            var json = data == null ? "" : JsonConvert.SerializeObject(data);
            HttpContent content = new StringContent(json);
            content.Headers.ContentType =
                MediaTypeHeaderValue.Parse("application/json;charset=UTF-8");
            var result = await client.PostAsync(new Uri(url), content);
            return result;
        }
    }
}
