using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ElasticLoadBalancingV2.ListenerRule
{
    /// <summary>
    /// AWS::ElasticLoadBalancingV2::ListenerRule HostHeaderConfig
    /// Information about a host header condition.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-listenerrule-hostheaderconfig.html
    /// </summary>
    public class HostHeaderConfig
    {

        /// <summary>
        /// Values
        /// One or more host names. The maximum size of each name is 128 characters. The comparison is case
        /// insensitive. The following wildcard characters are supported: * (matches 0 or more characters) and ?
        /// (matches exactly 1 character).
        /// If you specify multiple strings, the condition is satisfied if one of the strings matches the host
        /// name.
        /// Required: No
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Values")]
        public List<Union<string, IntrinsicFunction>> Values { get; set; }

    }
}
