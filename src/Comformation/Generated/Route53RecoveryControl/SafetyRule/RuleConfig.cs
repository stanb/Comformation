using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Route53RecoveryControl.SafetyRule
{
    /// <summary>
    /// AWS::Route53RecoveryControl::SafetyRule RuleConfig
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53recoverycontrol-safetyrule-ruleconfig.html
    /// </summary>
    public class RuleConfig
    {

        /// <summary>
        /// Type
        /// A rule can be one of the following: ATLEAST, AND, or OR.
        /// Required: Yes
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Type")]
        public Union<string, IntrinsicFunction> Type { get; set; }

        /// <summary>
        /// Threshold
        /// The value of N, when you specify an ATLEAST rule type. That is, Threshold is the number 				of
        /// controls that must be set when you specify an ATLEAST type.
        /// Required: Yes
        /// Type: Integer
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Threshold")]
        public Union<int, IntrinsicFunction> Threshold { get; set; }

        /// <summary>
        /// Inverted
        /// Logical negation of the rule. If the rule would usually evaluate true, it&#39;s evaluated as false, and
        /// vice versa.
        /// Required: Yes
        /// Type: Boolean
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Inverted")]
        public Union<bool, IntrinsicFunction> Inverted { get; set; }

    }
}
