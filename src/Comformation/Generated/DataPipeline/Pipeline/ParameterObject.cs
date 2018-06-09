using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.DataPipeline.Pipeline
{
    /// <summary>
    /// AWS Data Pipeline Pipeline ParameterObjects
    /// ParameterObjects is a property of the AWS::DataPipeline::Pipeline resource that describes parameters that are
    /// used in a pipeline definition.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datapipeline-pipeline-parameterobjects.html
    /// </summary>
    public class ParameterObject
    {

        /// <summary>
        /// Attributes
        /// Key-value pairs that define the attributes of the parameter object.
        /// Required: Yes
        /// Type: AWS Data Pipeline Parameter Objects Attributes
        /// </summary>
        [JsonProperty("Attributes")]
        public Union<List<ParameterAttribute>, IntrinsicFunction> Attributes { get; set; }

        /// <summary>
        /// Id
        /// The identifier of the parameter object.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("Id")]
        public Union<string, IntrinsicFunction> Id { get; set; }

    }
}
