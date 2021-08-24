using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CodeDeploy.DeploymentConfig
{
    /// <summary>
    /// AWS::CodeDeploy::DeploymentConfig TimeBasedLinear
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codedeploy-deploymentconfig-timebasedlinear.html
    /// </summary>
    public class TimeBasedLinear
    {

        /// <summary>
        /// LinearInterval
        /// The number of minutes between each incremental traffic shift of a TimeBasedLinear deployment.
        /// Required: Yes
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("LinearInterval")]
        public Union<int, IntrinsicFunction> LinearInterval { get; set; }

        /// <summary>
        /// LinearPercentage
        /// The percentage of traffic that is shifted at the start of each increment of a TimeBasedLinear
        /// deployment.
        /// Required: Yes
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("LinearPercentage")]
        public Union<int, IntrinsicFunction> LinearPercentage { get; set; }

    }
}
