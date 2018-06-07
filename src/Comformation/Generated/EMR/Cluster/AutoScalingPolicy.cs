using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EMR.Cluster
{
    /// <summary>
    ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-autoscalingpolicy.html
    /// </summary>
    public class AutoScalingPolicy
    {

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-autoscalingpolicy.html#cfn-emr-cluster-autoscalingpolicy-constraints
        /// </summary>
        [JsonProperty("Constraints")]
        public Union<ScalingConstraints, IntrinsicFunction> Constraints { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-autoscalingpolicy.html#cfn-emr-cluster-autoscalingpolicy-rules
        /// </summary>
        [JsonProperty("Rules")]
        public Union<List<ScalingRule>, IntrinsicFunction> Rules { get; set; }

    }
}
