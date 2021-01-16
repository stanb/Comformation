using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.SageMaker.ModelBiasJobDefinition
{
    /// <summary>
    /// AWS::SageMaker::ModelBiasJobDefinition MonitoringResources
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelbiasjobdefinition-monitoringresources.html
    /// </summary>
    public class MonitoringResources
    {

        /// <summary>
        /// ClusterConfig
        /// The configuration for the cluster resources used to run the processing job.
        /// Required: Yes
        /// Type: ClusterConfig
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("ClusterConfig")]
        public ClusterConfig ClusterConfig { get; set; }

    }
}
