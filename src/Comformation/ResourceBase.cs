using System.Collections.Generic;
using Newtonsoft.Json;

namespace Comformation
{
    public abstract class ResourceBase : ITemplateItem
    {
        public string LogicalId { get; set; }
    }
    
    [JsonConverter(typeof(TemplateItemsConverter))]
    public class Resources : List<ResourceBase>
    {
        
    }
}
