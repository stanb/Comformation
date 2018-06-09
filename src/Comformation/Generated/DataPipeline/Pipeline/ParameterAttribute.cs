using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.DataPipeline.Pipeline
{
    /// <summary>
    /// AWS Data Pipeline Parameter Objects Attributes
    /// Attribute is a property of the AWS Data Pipeline Pipeline ParameterObjects property that defines the
    /// attributes of a parameter object as key-value pairs.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datapipeline-pipeline-parameterobjects-attributes.html
    /// </summary>
    public class ParameterAttribute
    {

        /// <summary>
        /// Key
        /// Specifies the name of a parameter attribute. To view parameter attributes, see Creating a Pipeline
        /// Using Parameterized Templates in the AWS Data Pipeline Developer Guide.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("Key")]
        public Union<string, IntrinsicFunction> Key { get; set; }

        /// <summary>
        /// StringValue
        /// A parameter attribute value.
        /// Required: Conditional if the key that you are using requires it.
        /// Type: String
        /// </summary>
        [JsonProperty("StringValue")]
        public Union<string, IntrinsicFunction> StringValue { get; set; }

    }
}
