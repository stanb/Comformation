using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.WAFv2.RuleGroup
{
    /// <summary>
    /// AWS::WAFv2::RuleGroup RuleAction
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-ruleaction.html
    /// </summary>
    public class RuleAction
    {

        /// <summary>
        /// Allow
        /// Instructs AWS WAF to allow the web request.
        /// Required: No
        /// Type: Json
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Allow")]
        public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> Allow { get; set; }

        /// <summary>
        /// Block
        /// Instructs AWS WAF to block the web request.
        /// Required: No
        /// Type: Json
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Block")]
        public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> Block { get; set; }

        /// <summary>
        /// Count
        /// Instructs AWS WAF to count the web request and allow it.
        /// Required: No
        /// Type: Json
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Count")]
        public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> Count { get; set; }

    }
}
