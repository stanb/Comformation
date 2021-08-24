using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.WAFv2.WebACL
{
    /// <summary>
    /// AWS::WAFv2::WebACL RuleAction
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-ruleaction.html
    /// </summary>
    public class RuleAction
    {

        /// <summary>
        /// Allow
        /// Instructs AWS WAF to allow the web request.
        /// Required: No
        /// Type: AllowAction
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Allow")]
        public AllowAction Allow { get; set; }

        /// <summary>
        /// Block
        /// Instructs AWS WAF to block the web request.
        /// Required: No
        /// Type: BlockAction
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Block")]
        public BlockAction Block { get; set; }

        /// <summary>
        /// Count
        /// Instructs AWS WAF to count the web request and allow it.
        /// Required: No
        /// Type: CountAction
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Count")]
        public CountAction Count { get; set; }

    }
}
