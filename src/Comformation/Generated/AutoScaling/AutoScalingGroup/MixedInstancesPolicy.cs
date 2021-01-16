using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AutoScaling.AutoScalingGroup
{
    /// <summary>
    /// AWS::AutoScaling::AutoScalingGroup MixedInstancesPolicy
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-autoscalinggroup-mixedinstancespolicy.html
    /// </summary>
    public class MixedInstancesPolicy
    {

        /// <summary>
        /// InstancesDistribution
        /// The instances distribution to use. If you leave this property unspecified, the value for each
        /// property in InstancesDistribution uses a default value.
        /// Required: No
        /// Type: InstancesDistribution
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("InstancesDistribution")]
        public InstancesDistribution InstancesDistribution { get; set; }

        /// <summary>
        /// LaunchTemplate
        /// Specifies the launch template to use and optionally the instance types (overrides) that are used to
        /// provision EC2 instances to fulfill On-Demand and Spot capacities.
        /// Required: Yes
        /// Type: LaunchTemplate
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("LaunchTemplate")]
        public LaunchTemplate LaunchTemplate { get; set; }

    }
}
