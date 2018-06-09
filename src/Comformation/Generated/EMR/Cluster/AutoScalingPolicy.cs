using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EMR.Cluster
{
    /// <summary>
    /// Amazon EMR Cluster AutoScalingPolicy
    /// AutoScalingPolicy is a subproperty of the Amazon EMR Cluster InstanceGroupConfig property type that specifies
    /// the constraints and rules for an Auto Scaling group policy. For more information, see PutAutoScalingPolicy in
    /// the Amazon EMR API Reference.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-cluster-jobflowinstancesconfig-instancegroupconfig-autoscalingpolicy.html
    /// </summary>
    public class AutoScalingPolicy
    {

        /// <summary>
        /// Constraints
        /// The upper and lower Amazon EC2 instance limits for an automatic scaling policy. Automatic scaling
        /// activity will not cause an instance group to grow above or below these limits.
        /// Required: Yes
        /// Type: Amazon EMR Cluster ScalingConstraints
        /// </summary>
        [JsonProperty("Constraints")]
        public Union<ScalingConstraints, IntrinsicFunction> Constraints { get; set; }

        /// <summary>
        /// Rules
        /// The scale-in and scale-out rules that comprise the automatic scaling policy.
        /// Required: Yes
        /// Type: Amazon EMR Cluster ScalingRule
        /// </summary>
        [JsonProperty("Rules")]
        public Union<List<ScalingRule>, IntrinsicFunction> Rules { get; set; }

    }
}
