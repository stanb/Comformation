using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.SageMaker.MonitoringSchedule
{
    /// <summary>
    /// AWS::SageMaker::MonitoringSchedule MonitoringResources
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-monitoringschedule-monitoringresources.html
    /// </summary>
    public class MonitoringResources
    {

        /// <summary>
        /// ClusterConfig
        /// The configuration for the cluster resources used to run the processing job.
        /// Required: Yes
        /// Type: ClusterConfig
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ClusterConfig")]
        public ClusterConfig ClusterConfig { get; set; }

    }
}
