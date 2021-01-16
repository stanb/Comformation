using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ElasticLoadBalancingV2.ListenerRule
{
    /// <summary>
    /// AWS::ElasticLoadBalancingV2::ListenerRule TargetGroupStickinessConfig
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-listenerrule-targetgroupstickinessconfig.html
    /// </summary>
    public class TargetGroupStickinessConfig
    {

        /// <summary>
        /// Enabled
        /// Indicates whether target group stickiness is enabled.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Enabled")]
        public Union<bool, IntrinsicFunction> Enabled { get; set; }

        /// <summary>
        /// DurationSeconds
        /// The time period, in seconds, during which requests from a client should be routed to the same target
        /// group. The range is 1-604800 seconds (7 days).
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DurationSeconds")]
        public Union<int, IntrinsicFunction> DurationSeconds { get; set; }

    }
}
