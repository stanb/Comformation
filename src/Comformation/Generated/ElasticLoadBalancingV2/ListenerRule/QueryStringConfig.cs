using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ElasticLoadBalancingV2.ListenerRule
{
    /// <summary>
    /// AWS::ElasticLoadBalancingV2::ListenerRule QueryStringConfig
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-listenerrule-querystringconfig.html
    /// </summary>
    public class QueryStringConfig
    {

        /// <summary>
        /// Values
        /// One or more key/value pairs or values to find in the query string. The maximum size of each string
        /// is 128 characters. The comparison is case insensitive. The following wildcard characters are
        /// supported: * (matches 0 or more characters) and ? (matches exactly 1 character). To search for a
        /// literal &#39;*&#39; or &#39;?&#39; character in a query string, you must escape these characters in Values using a
        /// &#39;\&#39; character.
        /// If you specify multiple key/value pairs or values, the condition is satisfied if one of them is
        /// found in the query string.
        /// Required: No
        /// Type: List of QueryStringKeyValue
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Values")]
        public List<QueryStringKeyValue> Values { get; set; }

    }
}
