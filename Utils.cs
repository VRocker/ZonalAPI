using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using Windows.Web.Http;

namespace ZonalAPI
{
    public class Utils
    {
        public static async Task<string> PostHTTPString(Uri requestUri, string request)
        {
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("Accept", "application/json");

                Dictionary<string, string> items = new Dictionary<string, string>();
                items.Add("request", request);

                HttpFormUrlEncodedContent content = new HttpFormUrlEncodedContent(items);

                HttpResponseMessage resp = await client.PostAsync(requestUri, content);

                if (resp.IsSuccessStatusCode)
                    return await resp.Content.ReadAsStringAsync();
                else
                    return string.Empty;
            }
        }

        public static string SerializeJson(object instance)
        {
            using (MemoryStream _Stream = new MemoryStream())
            {
                var _Serializer = new DataContractJsonSerializer(instance.GetType());
                _Serializer.WriteObject(_Stream, instance);
                return Encoding.UTF8.GetString(_Stream.ToArray(), 0, (int)_Stream.Length);
            }
        }
    }
}
