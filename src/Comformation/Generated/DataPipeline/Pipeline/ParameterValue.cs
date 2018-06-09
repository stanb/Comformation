using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.DataPipeline.Pipeline
{
    /// <summary>
    /// AWS Data Pipeline Pipeline ParameterValues
    /// ParameterValues is a property of the AWS::DataPipeline::Pipeline resource that sets values for parameters that
    /// are used in a pipeline definition.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datapipeline-pipeline-parametervalues.html
    /// </summary>
    public class ParameterValue
    {

        /// <summary>
        /// Id
        /// The ID of a parameter object.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("Id")]
        public Union<string, IntrinsicFunction> Id { get; set; }

        /// <summary>
        /// StringValue
        /// A value to associate with the parameter object.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("StringValue")]
        public Union<string, IntrinsicFunction> StringValue { get; set; }

    }
}
