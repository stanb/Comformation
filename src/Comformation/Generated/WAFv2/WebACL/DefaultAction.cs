using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.WAFv2.WebACL
{
    /// <summary>
    /// AWS::WAFv2::WebACL DefaultAction
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-defaultaction.html
    /// </summary>
    public class DefaultAction
    {

        /// <summary>
        /// Allow
        /// Specifies that AWS WAF should allow requests by default.
        /// Required: No
        /// Type: Json
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Allow")]
        public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> Allow { get; set; }

        /// <summary>
        /// Block
        /// Specifies that AWS WAF should block requests by default.
        /// Required: No
        /// Type: Json
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Block")]
        public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> Block { get; set; }

    }
}
