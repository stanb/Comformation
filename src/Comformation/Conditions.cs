using System.Collections.Generic;
using Comformation.IntrinsicFunctions;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Comformation
{
    [JsonConverter(typeof(TemplateItemsConverter))]
    public class Conditions : List<Condition>
    {
        
    }
    
    [JsonConverter(typeof(ConditionConverter))]
    public class Condition : ITemplateItem
    {
        public string LogicalId { get; set; }
        public ConditionFunction IntrinsicFunction { get; set; }
    }
}