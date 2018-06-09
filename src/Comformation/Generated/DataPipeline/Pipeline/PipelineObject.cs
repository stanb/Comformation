using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.DataPipeline.Pipeline
{
    /// <summary>
    /// AWS Data Pipeline PipelineObject
    /// PipelineObjects is a property of the AWS::DataPipeline::Pipeline resource that describes a data pipeline
    /// object.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datapipeline-pipeline-pipelineobjects.html
    /// </summary>
    public class PipelineObject
    {

        /// <summary>
        /// Fields
        /// Key-value pairs that define the properties of the object. Duplicates allowed. You can use the same
        /// key multiple times within a field to define array attributes.
        /// Required: Yes
        /// Type: List of AWS Data Pipeline Pipeline Field
        /// </summary>
        [JsonProperty("Fields")]
        public Union<List<Field>, IntrinsicFunction> Fields { get; set; }

        /// <summary>
        /// Id
        /// Identifier of the object.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("Id")]
        public Union<string, IntrinsicFunction> Id { get; set; }

        /// <summary>
        /// Name
        /// Name of the object.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("Name")]
        public Union<string, IntrinsicFunction> Name { get; set; }

    }
}
