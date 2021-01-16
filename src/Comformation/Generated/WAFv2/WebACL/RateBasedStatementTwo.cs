using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.WAFv2.WebACL
{
    /// <summary>
    /// AWS::WAFv2::WebACL RateBasedStatementTwo
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-ratebasedstatementtwo.html
    /// </summary>
    public class RateBasedStatementTwo
    {

        /// <summary>
        /// Limit
        /// Limit on the web request that match any nested statement criteria in any 5 minute period.
        /// Required: Yes
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Limit")]
        public Union<int, IntrinsicFunction> Limit { get; set; }

        /// <summary>
        /// AggregateKeyType
        /// Setting that indicates how to aggregate the request counts. The options are the following:
        /// IP - Aggregate the request counts on the IP address from the web request origin. FORWARDED_IP -
        /// Aggregate the request counts on the first IP address in an HTTP header. If you use this, configure
        /// the ForwardedIPConfig, to specify the header to use.
        /// Required: Yes
        /// Type: String
        /// Allowed values: FORWARDED_IP | IP
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AggregateKeyType")]
        public Union<string, IntrinsicFunction> AggregateKeyType { get; set; }

        /// <summary>
        /// ScopeDownStatement
        /// Statement nested inside a rate-based statement to narrow the scope of the requests that AWS WAF
        /// counts.
        /// Required: No
        /// Type: StatementThree
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ScopeDownStatement")]
        public StatementThree ScopeDownStatement { get; set; }

        /// <summary>
        /// ForwardedIPConfig
        /// The configuration for inspecting IP addresses in an HTTP header that you specify, instead of using
        /// the IP address that&#39;s reported by the web request origin. Commonly, this is the X-Forwarded-For
        /// (XFF) header, but you can specify any header name.
        /// Note If the specified header isn&#39;t present in the request, AWS WAF doesn&#39;t apply the rule to the web
        /// request at all.
        /// This configuration is used for GeoMatchStatement and RateBasedStatement. For
        /// IPSetReferenceStatement, use IPSetForwardedIPConfig instead.
        /// AWS WAF only evaluates the first IP address found in the specified HTTP header.
        /// Required: No
        /// Type: ForwardedIPConfiguration
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ForwardedIPConfig")]
        public ForwardedIPConfiguration ForwardedIPConfig { get; set; }

    }
}
