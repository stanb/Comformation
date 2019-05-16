using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AutoScaling.AutoScalingGroup
{
    /// <summary>
    /// AWS::AutoScaling::AutoScalingGroup MixedInstancesPolicy
    /// MixedInstancesPolicy is a property of AutoScalingGroup that describes a mixed instances policy for an Amazon
    /// EC2 Auto Scaling group. With mixed instances, your Auto Scaling group can provision a combination of On-Demand
    /// Instances and Spot Instances across multiple instance types. For more information, see Auto Scaling Groups
    /// with Multiple Instance Types and Purchase Options in the Amazon EC2 Auto Scaling User Guide.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-autoscalinggroup-mixedinstancespolicy.html
    /// </summary>
    public class MixedInstancesPolicy
    {

        /// <summary>
        /// InstancesDistribution
        /// The instances distribution to use.
        /// If you leave this property unspecified when creating a mixed instances policy, the default values
        /// are used.
        /// Required: No
        /// Type: InstancesDistribution
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("InstancesDistribution")]
        public InstancesDistribution InstancesDistribution { get; set; }

        /// <summary>
        /// LaunchTemplate
        /// The launch template and instance types (overrides).
        /// This property must be specified when creating a mixed instances policy.
        /// Required: Conditional
        /// Type: LaunchTemplate
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("LaunchTemplate")]
        public LaunchTemplate LaunchTemplate { get; set; }

    }
}
