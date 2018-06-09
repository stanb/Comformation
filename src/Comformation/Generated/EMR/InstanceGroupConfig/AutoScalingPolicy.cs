using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EMR.InstanceGroupConfig
{
    /// <summary>
    /// Amazon EMR InstanceGroupConfig AutoScalingPolicy
    /// AutoScalingPolicy is a property of the AWS::EMR::InstanceGroupConfig resource that specifies the constraints
    /// and rules for an Auto Scaling group policy. For more information, see PutAutoScalingPolicy in the Amazon EMR
    /// API Reference.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-instancegroupconfig-autoscalingpolicy.html
    /// </summary>
    public class AutoScalingPolicy
    {

        /// <summary>
        /// Constraints
        /// The upper and lower Amazon EC2 instance limits for an automatic scaling policy. Automatic scaling
        /// activity doesn&#39;t cause an instance group to grow above or below these limits.
        /// Required: Yes
        /// Type: Amazon EMR InstanceGroupConfig ScalingConstraints
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Constraints")]
        public Union<ScalingConstraints, IntrinsicFunction> Constraints { get; set; }

        /// <summary>
        /// Rules
        /// The scale-in and scale-out rules that compose the automatic scaling policy.
        /// Required: Yes
        /// Type: List of Amazon EMR InstanceGroupConfig ScalingRule
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Rules")]
        public Union<List<ScalingRule>, IntrinsicFunction> Rules { get; set; }

    }
}
