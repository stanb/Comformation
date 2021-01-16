using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.WAFv2.RuleGroup
{
    /// <summary>
    /// AWS::WAFv2::RuleGroup IPSetReferenceStatement
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-ipsetreferencestatement.html
    /// </summary>
    public class IPSetReferenceStatement
    {

        /// <summary>
        /// Arn
        /// The Amazon Resource Name (ARN) of the IPSet that this statement references.
        /// Required: Yes
        /// Type: String
        /// Minimum: 20
        /// Maximum: 2048
        /// Pattern: . *\S. *
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Arn")]
        public Union<string, IntrinsicFunction> Arn { get; set; }

        /// <summary>
        /// IPSetForwardedIPConfig
        /// The configuration for inspecting IP addresses in an HTTP header that you specify, instead of using
        /// the IP address that&#39;s reported by the web request origin. Commonly, this is the X-Forwarded-For
        /// (XFF) header, but you can specify any header name.
        /// Note If the specified header isn&#39;t present in the request, AWS WAF doesn&#39;t apply the rule to the web
        /// request at all.
        /// Required: No
        /// Type: IPSetForwardedIPConfiguration
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("IPSetForwardedIPConfig")]
        public IPSetForwardedIPConfiguration IPSetForwardedIPConfig { get; set; }

    }
}
