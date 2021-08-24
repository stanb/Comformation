using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CodeDeploy.DeploymentConfig
{
    /// <summary>
    /// AWS::CodeDeploy::DeploymentConfig TrafficRoutingConfig
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codedeploy-deploymentconfig-trafficroutingconfig.html
    /// </summary>
    public class TrafficRoutingConfig
    {

        /// <summary>
        /// TimeBasedCanary
        /// A configuration that shifts traffic from one version of a Lambda function or ECS task set to another
        /// in two increments. The original and target Lambda function versions or ECS task sets are specified
        /// in the deployment&#39;s AppSpec file.
        /// Required: No
        /// Type: TimeBasedCanary
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TimeBasedCanary")]
        public TimeBasedCanary TimeBasedCanary { get; set; }

        /// <summary>
        /// TimeBasedLinear
        /// A configuration that shifts traffic from one version of a Lambda function or Amazon ECS task set to
        /// another in equal increments, with an equal number of minutes between each increment. The original
        /// and target Lambda function versions or Amazon ECS task sets are specified in the deployment&#39;s
        /// AppSpec file.
        /// Required: No
        /// Type: TimeBasedLinear
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TimeBasedLinear")]
        public TimeBasedLinear TimeBasedLinear { get; set; }

        /// <summary>
        /// Type
        /// The type of traffic shifting (TimeBasedCanary or TimeBasedLinear) used by a deployment
        /// configuration.
        /// Required: Yes
        /// Type: String
        /// Allowed values: AllAtOnce | TimeBasedCanary | TimeBasedLinear
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Type")]
        public Union<string, IntrinsicFunction> Type { get; set; }

    }
}
