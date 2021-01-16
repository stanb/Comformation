using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ElasticLoadBalancingV2.ListenerRule
{
    /// <summary>
    /// AWS::ElasticLoadBalancingV2::ListenerRule SourceIpConfig
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-listenerrule-sourceipconfig.html
    /// </summary>
    public class SourceIpConfig
    {

        /// <summary>
        /// Values
        /// One or more source IP addresses, in CIDR format. You can use both IPv4 and IPv6 addresses. Wildcards
        /// are not supported.
        /// If you specify multiple addresses, the condition is satisfied if the source IP address of the
        /// request matches one of the CIDR blocks. This condition is not satisfied by the addresses in the
        /// X-Forwarded-For header.
        /// Required: No
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Values")]
        public List<Union<string, IntrinsicFunction>> Values { get; set; }

    }
}
