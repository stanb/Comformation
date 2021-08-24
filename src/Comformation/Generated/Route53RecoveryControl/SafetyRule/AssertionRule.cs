using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Route53RecoveryControl.SafetyRule
{
    /// <summary>
    /// AWS::Route53RecoveryControl::SafetyRule AssertionRule
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53recoverycontrol-safetyrule-assertionrule.html
    /// </summary>
    public class AssertionRule
    {

        /// <summary>
        /// WaitPeriodMs
        /// An evaluation period, in milliseconds (ms), during which any request against the target routing
        /// controls 				will fail. This helps prevent &quot;flapping&quot; of state. The wait period is 5000 ms by
        /// default, but you can choose 				a custom value.
        /// Required: Yes
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("WaitPeriodMs")]
        public Union<int, IntrinsicFunction> WaitPeriodMs { get; set; }

        /// <summary>
        /// AssertedControls
        /// The routing controls that are part of transactions that are evaluated to determine if a request
        /// 				to change a routing control state is allowed. For example, you might include three routing
        /// controls, 				one for each of three AWS Regions.
        /// Required: Yes
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AssertedControls")]
        public List<Union<string, IntrinsicFunction>> AssertedControls { get; set; }

    }
}
