using System;
using Newtonsoft.Json;

namespace Comformation
{
    public class UnionConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return typeof(UnionBase).IsAssignableFrom(objectType);
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            var union = (UnionBase)value;
            union.ToJson().WriteTo(writer);
        }

        public override bool CanRead => false;

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }
    }

}