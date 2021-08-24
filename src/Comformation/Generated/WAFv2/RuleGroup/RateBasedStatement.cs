using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.WAFv2.RuleGroup
{
    /// <summary>
    /// AWS::WAFv2::RuleGroup RateBasedStatement
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-ratebasedstatement.html
    /// </summary>
    public class RateBasedStatement
    {

        /// <summary>
        /// Limit
        /// The limit on requests per 5-minute period for a single originating IP address. If the statement
        /// includes a ScopeDownStatement, this limit is applied only to the requests that match the statement.
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
        /// An optional nested statement that narrows the scope of the rate-based statement to matching web
        /// requests. This can be any nestable statement, and you can nest statements at any level below this
        /// scope-down statement.
        /// Required: No
        /// Type: Statement
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ScopeDownStatement")]
        public Statement ScopeDownStatement { get; set; }

        /// <summary>
        /// ForwardedIPConfig
        /// The configuration for inspecting IP addresses in an HTTP header that you specify, instead of using
        /// the IP address that&#39;s reported by the web request origin. Commonly, this is the X-Forwarded-For
        /// (XFF) header, but you can specify any header name.
        /// Note If the specified header isn&#39;t present in the request, AWS WAF doesn&#39;t apply the rule to the web
        /// request at all.
        /// This is required if AggregateKeyType is set to FORWARDED_IP.
        /// Required: No
        /// Type: ForwardedIPConfiguration
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ForwardedIPConfig")]
        public ForwardedIPConfiguration ForwardedIPConfig { get; set; }

    }
}
