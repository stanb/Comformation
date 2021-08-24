using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Route53RecoveryControl.SafetyRule
{
    /// <summary>
    /// AWS::Route53RecoveryControl::SafetyRule GatingRule
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53recoverycontrol-safetyrule-gatingrule.html
    /// </summary>
    public class GatingRule
    {

        /// <summary>
        /// GatingControls
        /// The gating controls for the gating rule. That is, routing controls that are evaluated by the rule
        /// 				configuration that you specify.
        /// Required: Yes
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("GatingControls")]
        public List<Union<string, IntrinsicFunction>> GatingControls { get; set; }

        /// <summary>
        /// TargetControls
        /// Routing controls that can only be set or unset if the specified RuleConfig evaluates to true 				for
        /// the specified GatingControls. For example, say you have three gating controls, one for each 				of
        /// three AWS Regions. Now you specify AtLeast 2 as your RuleConfig. With these 				settings, you can
        /// only change (set or unset) the routing controls that you have specified as TargetControls 				if
        /// that rule evaluates to true.
        /// In other words, your ability to change the routing controls that you have specified as
        /// TargetControls 				is gated by the rule that you set for the routing controls in GatingControls.
        /// Required: Yes
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TargetControls")]
        public List<Union<string, IntrinsicFunction>> TargetControls { get; set; }

        /// <summary>
        /// WaitPeriodMs
        /// An evaluation period, in milliseconds (ms), during which any request against the target routing
        /// controls 				will fail. This helps prevent &quot;flapping&quot; of state. The wait period is 5000 ms by
        /// default, but you can choose 				a custom value.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("WaitPeriodMs")]
        public Union<int, IntrinsicFunction> WaitPeriodMs { get; set; }

    }
}
