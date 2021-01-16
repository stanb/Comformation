using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.DataPipeline.Pipeline
{
    /// <summary>
    /// AWS::DataPipeline::Pipeline ParameterObject
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datapipeline-pipeline-parameterobjects.html
    /// </summary>
    public class ParameterObject
    {

        /// <summary>
        /// Attributes
        /// The attributes of the parameter object.
        /// Required: Yes
        /// Type: List of ParameterAttribute
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Attributes")]
        public List<ParameterAttribute> Attributes { get; set; }

        /// <summary>
        /// Id
        /// The ID of the parameter object.
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Maximum: 256
        /// Pattern: [\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\n\t]*
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Id")]
        public Union<string, IntrinsicFunction> Id { get; set; }

    }
}
