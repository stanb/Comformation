using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.DataPipeline.Pipeline
{
    /// <summary>
    /// AWS::DataPipeline::Pipeline PipelineTag
    /// A list of arbitrary tags (key-value pairs) to associate with the pipeline, which you can use to control
    /// permissions. For more information, see Controlling Access to Pipelines and Resources in the AWS Data Pipeline
    /// Developer Guide.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datapipeline-pipeline-pipelinetags.html
    /// </summary>
    public class PipelineTag
    {

        /// <summary>
        /// Key
        /// The key name of a tag.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Key")]
        public Union<string, IntrinsicFunction> Key { get; set; }

        /// <summary>
        /// Value
        /// The value to associate with the key name.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Value")]
        public Union<string, IntrinsicFunction> Value { get; set; }

    }
}
