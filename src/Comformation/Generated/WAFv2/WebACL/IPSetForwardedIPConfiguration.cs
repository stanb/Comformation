using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.WAFv2.WebACL
{
    /// <summary>
    /// AWS::WAFv2::WebACL IPSetForwardedIPConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-ipsetforwardedipconfiguration.html
    /// </summary>
    public class IPSetForwardedIPConfiguration
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

        /// <summary>
        /// Position
        /// The position in the header to search for the IP address. The header can contain IP addresses of the
        /// original client and also of proxies. For example, the header value could be 10. 1. 1. 1, 127. 0. 0.
        /// 0, 10. 10. 10. 10 where the first IP address identifies the original client and the rest identify
        /// proxies that the request went through.
        /// The options for this setting are the following:
        /// FIRST - Inspect the first IP address in the list of IP addresses in the header. This is usually the
        /// client&#39;s original IP. LAST - Inspect the last IP address in the list of IP addresses in the header.
        /// ANY - Inspect all IP addresses in the header for a match. If the header contains more than 10 IP
        /// addresses, AWS WAF inspects the last 10.
        /// Required: Yes
        /// Type: String
        /// Allowed values: ANY | FIRST | LAST
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Position")]
        public Union<string, IntrinsicFunction> Position { get; set; }

    }
}
