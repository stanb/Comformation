using Newtonsoft.Json;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace Comformation.CodeBuilder
{
    public class SchemaLoader
    {
        private static readonly JsonSerializerSettings SerializerSettings = new JsonSerializerSettings
        {
            NullValueHandling = NullValueHandling.Ignore
        };

        public async Task<Schema> Load(string url)
        {
            var handler = new HttpClientHandler
            {
                AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate
            };

            string json;
            using (var client = new HttpClient(handler))
            {
                json = await client.GetStringAsync(url);
            }

            var schema = JsonConvert.DeserializeObject<Schema>(json, SerializerSettings);

            return schema;
        }
    }
}
