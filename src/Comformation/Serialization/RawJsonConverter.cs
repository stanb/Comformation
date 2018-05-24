using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Comformation
{
    /// <summary>
    /// Used to serialize strings that represents json
    /// </summary>
    public class RawJsonConverter : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            var str = value.ToString();
            // TODO: verify that value is JSON
            if (str.StartsWith("[") && str.EndsWith("]") || str.StartsWith("{") && str.EndsWith("}"))
                writer.WriteRawValue(str);
            else
                writer.WriteValue(value);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        public override bool CanConvert(Type objectType)
        {
            return typeof(string).IsAssignableFrom(objectType);
        }

        public override bool CanRead => false;
    }
}