using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.WAFv2.WebACL
{
    /// <summary>
    /// AWS::WAFv2::WebACL OverrideAction
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-overrideaction.html
    /// </summary>
    public class OverrideAction
    {

        /// <summary>
        /// Count
        /// Override the rule action settings to count.
        /// Required: No
        /// Type: Json
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Count")]
        public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> Count { get; set; }

        /// <summary>
        /// None
        /// Don&#39;t override the rule action settings.
        /// Required: No
        /// Type: Json
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("None")]
        public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> None { get; set; }

    }
}
