using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.DataPipeline.Pipeline
{
    /// <summary>
    /// AWS::DataPipeline::Pipeline ParameterValue
    /// A value or list of parameter values.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datapipeline-pipeline-parametervalues.html
    /// </summary>
    public class ParameterValue
    {

        /// <summary>
        /// Id
        /// The ID of the parameter value.
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Maximum: 256
        /// Pattern: [\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\n\t]*
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Id")]
        public Union<string, IntrinsicFunction> Id { get; set; }

        /// <summary>
        /// StringValue
        /// The field value, expressed as a String.
        /// Required: Yes
        /// Type: String
        /// Minimum: 0
        /// Maximum: 10240
        /// Pattern: [\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\n\t]*
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("StringValue")]
        public Union<string, IntrinsicFunction> StringValue { get; set; }

    }
}
