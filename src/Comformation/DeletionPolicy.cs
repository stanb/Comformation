using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Comformation
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum DeletionPolicy
    {
        Delete,
        Retain,
        Snapshot
    }
}
