using System.Collections.Generic;
using Comformation.IntrinsicFunctions;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Comformation
{
    /// <summary>
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/outputs-section-structure.html
    /// </summary>
    [JsonConverter(typeof(TemplateItemsConverter))]
    public class Outputs : List<Output>
    {
        
    }

    public class Output : ITemplateItem
    {
        /// <summary>
        /// An identifier for the current output. The logical ID must be alphanumeric (a-z, A-Z, 0-9) and unique within the template.
        /// </summary>
        public string LogicalId { get; set; }

        /// <summary>
        /// A String type that describes the output value. The description can be a maximum of 4 K in length.
        /// </summary>
        public string Description { get; set; }
        
        /// <summary>
        /// The value of the property returned by the aws cloudformation describe-stacks command.
        /// The value of an output can include literals, parameter references, pseudo-parameters, a mapping value, or intrinsic functions.
        /// </summary>
        public Union<string, IntrinsicFunction, PseudoParameter> Value { get; set; }
        
        /// <summary>
        /// The name of the resource output to be exported for a cross-stack reference 
        /// See also ImportValue intrinsic function 
        /// </summary>
        public IDictionary<string, Union<string, IntrinsicFunction>> Export { get; set; }
    }
}
