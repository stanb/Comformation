using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.SageMaker.Endpoint
{
    /// <summary>
    /// AWS::SageMaker::Endpoint DeploymentConfig
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpoint-deploymentconfig.html
    /// </summary>
    public class DeploymentConfig
    {

        /// <summary>
        /// AutoRollbackConfiguration
        /// Required: No
        /// Type: AutoRollbackConfig
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AutoRollbackConfiguration")]
        public AutoRollbackConfig AutoRollbackConfiguration { get; set; }

        /// <summary>
        /// BlueGreenUpdatePolicy
        /// Required: Yes
        /// Type: BlueGreenUpdatePolicy
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("BlueGreenUpdatePolicy")]
        public BlueGreenUpdatePolicy BlueGreenUpdatePolicy { get; set; }

    }
}
