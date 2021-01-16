using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.SageMaker.ModelQualityJobDefinition
{
    /// <summary>
    /// AWS::SageMaker::ModelQualityJobDefinition ModelQualityJobInput
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelqualityjobdefinition-modelqualityjobinput.html
    /// </summary>
    public class ModelQualityJobInput
    {

        /// <summary>
        /// EndpointInput
        /// Input object for the endpoint
        /// Required: Yes
        /// Type: EndpointInput
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("EndpointInput")]
        public EndpointInput EndpointInput { get; set; }

        /// <summary>
        /// GroundTruthS3Input
        /// The ground truth label provided for the model.
        /// Required: Yes
        /// Type: MonitoringGroundTruthS3Input
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("GroundTruthS3Input")]
        public MonitoringGroundTruthS3Input GroundTruthS3Input { get; set; }

    }
}
