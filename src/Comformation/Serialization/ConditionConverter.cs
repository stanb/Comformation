using System;
using System.Linq;
using Newtonsoft.Json;

namespace Comformation
{
    public class ConditionConverter : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            var fn = ((Condition) value).IntrinsicFunction;
            serializer.Serialize(writer, fn);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(Condition);
        }

        public override bool CanRead => false;
    }
}