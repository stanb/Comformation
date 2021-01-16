using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.GameLift.GameServerGroup
{
    /// <summary>
    /// AWS::GameLift::GameServerGroup AutoScalingPolicy
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-gameservergroup-autoscalingpolicy.html
    /// </summary>
    public class AutoScalingPolicy
    {

        /// <summary>
        /// EstimatedInstanceWarmup
        /// Not currently supported by AWS CloudFormation.
        /// Required: No
        /// Type: Double
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("EstimatedInstanceWarmup")]
        public Union<double, IntrinsicFunction> EstimatedInstanceWarmup { get; set; }

        /// <summary>
        /// TargetTrackingConfiguration
        /// Not currently supported by AWS CloudFormation.
        /// Required: Yes
        /// Type: TargetTrackingConfiguration
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TargetTrackingConfiguration")]
        public TargetTrackingConfiguration TargetTrackingConfiguration { get; set; }

    }
}
