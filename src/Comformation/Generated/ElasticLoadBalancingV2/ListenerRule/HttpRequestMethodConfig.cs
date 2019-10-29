using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ElasticLoadBalancingV2.ListenerRule
{
    /// <summary>
    /// AWS::ElasticLoadBalancingV2::ListenerRule HttpRequestMethodConfig
    /// Information about an HTTP method condition.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-listenerrule-httprequestmethodconfig.html
    /// </summary>
    public class HttpRequestMethodConfig
    {

        /// <summary>
        /// Values
        /// The name of the request method. The maximum size is 40 characters. The allowed characters are A-Z,
        /// hyphen (-), and underscore (_). The comparison is case sensitive. Wildcards are not supported;
        /// therefore, the method name must be an exact match.
        /// If you specify multiple strings, the condition is satisfied if one of the strings matches the HTTP
        /// request method. We recommend that you route GET and HEAD requests in the same way, because the
        /// response to a HEAD request may be cached.
        /// Required: No
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Values")]
        public List<Union<string, IntrinsicFunction>> Values { get; set; }

    }
}
