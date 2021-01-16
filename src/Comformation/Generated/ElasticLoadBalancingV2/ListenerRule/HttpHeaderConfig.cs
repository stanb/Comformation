using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ElasticLoadBalancingV2.ListenerRule
{
    /// <summary>
    /// AWS::ElasticLoadBalancingV2::ListenerRule HttpHeaderConfig
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-listenerrule-httpheaderconfig.html
    /// </summary>
    public class HttpHeaderConfig
    {

        /// <summary>
        /// Values
        /// One or more strings to compare against the value of the HTTP header. The maximum size of each string
        /// is 128 characters. The comparison strings are case insensitive. The following wildcard characters
        /// are supported: * (matches 0 or more characters) and ? (matches exactly 1 character).
        /// If the same header appears multiple times in the request, we search them in order until a match is
        /// found.
        /// If you specify multiple strings, the condition is satisfied if one of the strings matches the value
        /// of the HTTP header. To require that all of the strings are a match, create one condition per string.
        /// Required: No
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Values")]
        public List<Union<string, IntrinsicFunction>> Values { get; set; }

        /// <summary>
        /// HttpHeaderName
        /// The name of the HTTP header field. The maximum size is 40 characters. The header name is case
        /// insensitive. The allowed characters are specified by RFC 7230. Wildcards are not supported.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("HttpHeaderName")]
        public Union<string, IntrinsicFunction> HttpHeaderName { get; set; }

    }
}
