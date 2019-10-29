using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ElasticLoadBalancingV2.ListenerRule
{
    /// <summary>
    /// AWS::ElasticLoadBalancingV2::ListenerRule PathPatternConfig
    /// Information about a path pattern condition.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-listenerrule-pathpatternconfig.html
    /// </summary>
    public class PathPatternConfig
    {

        /// <summary>
        /// Values
        /// One or more path patterns to compare against the request URL. The maximum size of each string is 128
        /// characters. The comparison is case sensitive. The following wildcard characters are supported: *
        /// (matches 0 or more characters) and ? (matches exactly 1 character).
        /// If you specify multiple strings, the condition is satisfied if one of them matches the request URL.
        /// The path pattern is compared only to the path of the URL, not to its query string.
        /// Required: No
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Values")]
        public List<Union<string, IntrinsicFunction>> Values { get; set; }

    }
}
