using System.Collections.Generic;
using Amazon;
using Newtonsoft.Json;

namespace Comformation
{
    [JsonConverter(typeof(MappingsConverter))]
    public class Mappings : List<Mapping>
    {
        
    }

    public class Mapping
    {
        public string Name { get; set; }
        public IList<RegionMap> Regions { get; } = new List<RegionMap>(); 
    }

    public class RegionMap
    {
        public RegionEndpoint Region { get; set; }
        public IDictionary<string, string> Map { get; } = new Dictionary<string, string>();
    }
}
