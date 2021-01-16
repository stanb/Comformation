using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.SageMaker.ModelExplainabilityJobDefinition
{
    /// <summary>
    /// AWS::SageMaker::ModelExplainabilityJobDefinition ModelExplainabilityJobInput
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelexplainabilityjobdefinition-modelexplainabilityjobinput.html
    /// </summary>
    public class ModelExplainabilityJobInput
    {

        /// <summary>
        /// EndpointInput
        /// Not currently supported by AWS CloudFormation.
        /// Required: Yes
        /// Type: EndpointInput
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("EndpointInput")]
        public EndpointInput EndpointInput { get; set; }

    }
}
