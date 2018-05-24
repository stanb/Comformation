using Newtonsoft.Json;

namespace Comformation
{
    public interface ITemplateItem
    {
        [JsonIgnore]
        string LogicalId { get; }
    }
}