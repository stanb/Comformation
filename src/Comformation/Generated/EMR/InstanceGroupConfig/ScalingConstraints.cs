using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EMR.InstanceGroupConfig
{
    /// <summary>
    /// Amazon EMR InstanceGroupConfig ScalingConstraints
    /// The ScalingConstraints property type specifies the upper and lower EC2 instance limits for an automatic
    /// scaling policy. ScalingConstraints is the property type for the Constraints subproperty of the Amazon EMR
    /// InstanceGroupConfig AutoScalingPolicy property type.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-instancegroupconfig-scalingconstraints.html
    /// </summary>
    public class ScalingConstraints
    {

        /// <summary>
        /// MaxCapacity
        /// For autoscaling, the maximum number of EC2 instances in an instance group. Scale-out activities add
        /// instances only up to this boundary.
        /// Required: Yes
        /// Type: Integer
        /// </summary>
        [JsonProperty("MaxCapacity")]
        public Union<int, IntrinsicFunction> MaxCapacity { get; set; }

        /// <summary>
        /// MinCapacity
        /// For autoscaling, the minimum number of EC2 instances in an instance group. Scale-in activities do
        /// not terminate instances below this boundary.
        /// Required: Yes
        /// Type: Integer
        /// </summary>
        [JsonProperty("MinCapacity")]
        public Union<int, IntrinsicFunction> MinCapacity { get; set; }

    }
}
