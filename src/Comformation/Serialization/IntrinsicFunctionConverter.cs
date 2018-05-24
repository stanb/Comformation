using System;
using Comformation.IntrinsicFunctions;
using Newtonsoft.Json;

namespace Comformation
{
    public class IntrinsicFunctionConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return typeof(IntrinsicFunction).IsAssignableFrom(objectType);
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            var func = (IntrinsicFunction)value;
            func.ToJson().WriteTo(writer);
        }

        public override bool CanRead => false;

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }
    }
}