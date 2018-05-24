using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace Comformation
{
    public class MappingsConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(Mappings);
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            var mappings = (Mappings) value;
            var items = mappings.ToDictionary(x => x.Name,
                x => x.Regions.ToDictionary(m => m.Region.SystemName, m => m.Map));
            
            serializer.Serialize(writer, items);
        }
        
        public override bool CanRead => false;
        
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }
        
    }
}