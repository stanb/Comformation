using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.WAFv2.WebACL
{
    /// <summary>
    /// AWS::WAFv2::WebACL RateBasedStatementOne
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-ratebasedstatementone.html
    /// </summary>
    public class RateBasedStatementOne
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
        /// Type: StatementTwo
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ScopeDownStatement")]
        public StatementTwo ScopeDownStatement { get; set; }

        /// <summary>
        /// ForwardedIPConfig
        /// Not currently supported by AWS CloudFormation.
        /// Required: No
        /// Type: ForwardedIPConfiguration
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ForwardedIPConfig")]
        public ForwardedIPConfiguration ForwardedIPConfig { get; set; }

    }
}
