using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ElasticLoadBalancingV2.Listener
{
    /// <summary>
    /// AWS::ElasticLoadBalancingV2::Listener ForwardConfig
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-listener-forwardconfig.html
    /// </summary>
    public class ForwardConfig
    {

        /// <summary>
        /// TargetGroupStickinessConfig
        /// Information about the target group stickiness for a rule.
        /// Required: No
        /// Type: TargetGroupStickinessConfig
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TargetGroupStickinessConfig")]
        public TargetGroupStickinessConfig TargetGroupStickinessConfig { get; set; }

        /// <summary>
        /// TargetGroups
        /// Information about how traffic will be distributed between multiple target groups in a forward rule.
        /// Required: No
        /// Type: List of TargetGroupTuple
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TargetGroups")]
        public List<TargetGroupTuple> TargetGroups { get; set; }

    }
}
