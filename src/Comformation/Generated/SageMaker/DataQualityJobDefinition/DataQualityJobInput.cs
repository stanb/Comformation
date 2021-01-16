using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.SageMaker.DataQualityJobDefinition
{
    /// <summary>
    /// AWS::SageMaker::DataQualityJobDefinition DataQualityJobInput
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-dataqualityjobdefinition-dataqualityjobinput.html
    /// </summary>
    public class DataQualityJobInput
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
