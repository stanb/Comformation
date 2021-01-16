using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EMR.Cluster
{
    /// <summary>
    /// AWS::EMR::Cluster AutoScalingPolicy
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-autoscalingpolicy.html
    /// </summary>
    public class AutoScalingPolicy
    {

        /// <summary>
        /// Constraints
        /// The upper and lower EC2 instance limits for an automatic scaling policy. Automatic scaling activity
        /// will not cause an instance group to grow above or below these limits.
        /// Required: Yes
        /// Type: ScalingConstraints
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Constraints")]
        public ScalingConstraints Constraints { get; set; }

        /// <summary>
        /// Rules
        /// The scale-in and scale-out rules that comprise the automatic scaling policy.
        /// Required: Yes
        /// Type: List of ScalingRule
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Rules")]
        public List<ScalingRule> Rules { get; set; }

    }
}
