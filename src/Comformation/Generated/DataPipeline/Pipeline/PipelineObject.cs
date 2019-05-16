using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.DataPipeline.Pipeline
{
    /// <summary>
    /// AWS::DataPipeline::Pipeline PipelineObject
    /// PipelineObject is property of the AWS::DataPipeline::Pipeline resource that contains information about a
    /// pipeline object. This can be a logical, physical, or physical attempt pipeline object. The complete set of
    /// components of a pipeline defines the pipeline.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datapipeline-pipeline-pipelineobjects.html
    /// </summary>
    public class PipelineObject
    {

        /// <summary>
        /// Fields
        /// Key-value pairs that define the properties of the object.
        /// Required: Yes
        /// Type: List of Field
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Fields")]
        public List<Field> Fields { get; set; }

        /// <summary>
        /// Id
        /// The ID of the object.
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Maximum: 1024
        /// Pattern: [\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\n\t]*
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Id")]
        public Union<string, IntrinsicFunction> Id { get; set; }

        /// <summary>
        /// Name
        /// The name of the object.
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Maximum: 1024
        /// Pattern: [\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\n\t]*
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Name")]
        public Union<string, IntrinsicFunction> Name { get; set; }

    }
}
