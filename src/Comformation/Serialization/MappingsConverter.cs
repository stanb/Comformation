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

            var items = new Dictionary<string, IDictionary<string, IDictionary<string, string>>>();
            foreach (var mapping in mappings)
            {
                var x = new Dictionary<string, IDictionary<string, string>>();
                foreach (var map in mapping.Maps)
                {
                    x.Add(map.Name, map.Map);
                }
                foreach (var regionMap in mapping.Regions)
                {
                    x.Add(regionMap.Region.SystemName, regionMap.Map);
                }
                items.Add(mapping.Name, x);
            }
            serializer.Serialize(writer, items);
        }
        
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var items = serializer.Deserialize<IDictionary<string, IDictionary<string, IDictionary<string, string>>>>(reader);
            var mappings = new Mappings();
            foreach (var item in items)
            {
                var mapping = new Mapping { Name = item.Key };
                foreach (var m in item.Value)
                {
                    var map = new NamedMap { Name = m.Key };
                    foreach (var kvp in m.Value)
                    {
                        map.Map.Add(kvp);
                    }
                    mapping.Maps.Add(map);
                }
                mappings.Add(mapping);
            }
            return mappings;
        }
    }
}
