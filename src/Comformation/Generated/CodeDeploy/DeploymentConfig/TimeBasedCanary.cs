using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CodeDeploy.DeploymentConfig
{
    /// <summary>
    /// AWS::CodeDeploy::DeploymentConfig TimeBasedCanary
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codedeploy-deploymentconfig-timebasedcanary.html
    /// </summary>
    public class TimeBasedCanary
    {

        /// <summary>
        /// CanaryInterval
        /// The number of minutes between the first and second traffic shifts of a TimeBasedCanary deployment.
        /// Required: Yes
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CanaryInterval")]
        public Union<int, IntrinsicFunction> CanaryInterval { get; set; }

        /// <summary>
        /// CanaryPercentage
        /// The percentage of traffic to shift in the first increment of a TimeBasedCanary deployment.
        /// Required: Yes
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CanaryPercentage")]
        public Union<int, IntrinsicFunction> CanaryPercentage { get; set; }

    }
}
