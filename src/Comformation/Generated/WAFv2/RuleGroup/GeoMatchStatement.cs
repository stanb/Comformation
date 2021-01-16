using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.WAFv2.RuleGroup
{
    /// <summary>
    /// AWS::WAFv2::RuleGroup GeoMatchStatement
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-geomatchstatement.html
    /// </summary>
    public class GeoMatchStatement
    {

        /// <summary>
        /// CountryCodes
        /// An array of two-character country codes, for example, [ &quot;US&quot;, &quot;CN&quot; ], from the alpha-2 country ISO
        /// codes of the ISO 3166 international standard.
        /// Required: No
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CountryCodes")]
        public List<Union<string, IntrinsicFunction>> CountryCodes { get; set; }

        /// <summary>
        /// ForwardedIPConfig
        /// The configuration for inspecting IP addresses in an HTTP header that you specify, instead of using
        /// the IP address that&#39;s reported by the web request origin. Commonly, this is the X-Forwarded-For
        /// (XFF) header, but you can specify any header name.
        /// Note If the specified header isn&#39;t present in the request, AWS WAF doesn&#39;t apply the rule to the web
        /// request at all.
        /// Required: No
        /// Type: ForwardedIPConfiguration
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ForwardedIPConfig")]
        public ForwardedIPConfiguration ForwardedIPConfig { get; set; }

    }
}
