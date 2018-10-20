using System;
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
        [Obsolete("Use Maps property instead")]
        public IList<RegionMap> Regions { get; } = new List<RegionMap>();
        public IList<IMap> Maps { get; } = new List<IMap>();
    }

    public interface IMap
    {
        string Name { get; }
        IDictionary<string, string> Map { get; }
    }

    public class RegionMap : IMap
    {
        public RegionEndpoint Region { get; set; }
        public IDictionary<string, string> Map { get; } = new Dictionary<string, string>();

        string IMap.Name => Region.SystemName;
    }

    public class NamedMap : IMap
    {
        public string Name { get; set; }
        public IDictionary<string, string> Map { get; } = new Dictionary<string, string>();
    }
}
