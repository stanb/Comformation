using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.WAFv2.RuleGroup
{
    /// <summary>
    /// AWS::WAFv2::RuleGroup ForwardedIPConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-forwardedipconfiguration.html
    /// </summary>
    public class ForwardedIPConfiguration
    {

        /// <summary>
        /// HeaderName
        /// The name of the HTTP header to use for the IP address. For example, to use the X-Forwarded-For (XFF)
        /// header, set this to X-Forwarded-For.
        /// Note If the specified header isn&#39;t present in the request, AWS WAF doesn&#39;t apply the rule to the web
        /// request at all.
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Maximum: 255
        /// Pattern: ^[a-zA-Z0-9-]+$
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("HeaderName")]
        public Union<string, IntrinsicFunction> HeaderName { get; set; }

        /// <summary>
        /// FallbackBehavior
        /// The match status to assign to the web request if the request doesn&#39;t have a valid IP address in the
        /// specified position.
        /// Note If the specified header isn&#39;t present in the request, AWS WAF doesn&#39;t apply the rule to the web
        /// request at all.
        /// You can specify the following fallback behaviors:
        /// MATCH - Treat the web request as matching the rule statement. AWS WAF applies the rule action to the
        /// request. NO_MATCH - Treat the web request as not matching the rule statement.
        /// Required: Yes
        /// Type: String
        /// Allowed values: MATCH | NO_MATCH
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("FallbackBehavior")]
        public Union<string, IntrinsicFunction> FallbackBehavior { get; set; }

    }
}
