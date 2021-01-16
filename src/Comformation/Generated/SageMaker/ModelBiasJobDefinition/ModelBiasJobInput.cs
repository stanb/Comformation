using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.SageMaker.ModelBiasJobDefinition
{
    /// <summary>
    /// AWS::SageMaker::ModelBiasJobDefinition ModelBiasJobInput
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelbiasjobdefinition-modelbiasjobinput.html
    /// </summary>
    public class ModelBiasJobInput
    {

        /// <summary>
        /// EndpointInput
        /// Input object for the endpoint.
        /// Required: Yes
        /// Type: EndpointInput
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("EndpointInput")]
        public EndpointInput EndpointInput { get; set; }

        /// <summary>
        /// GroundTruthS3Input
        /// Location of ground truth labels to use in model bias job.
        /// Required: Yes
        /// Type: MonitoringGroundTruthS3Input
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("GroundTruthS3Input")]
        public MonitoringGroundTruthS3Input GroundTruthS3Input { get; set; }

    }
}
