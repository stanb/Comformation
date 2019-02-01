using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ElasticLoadBalancingV2.ListenerRule
{
    /// <summary>
    /// Elastic Load Balancing V2 RedirectConfig
    /// The RedirectConfig property type specifies information about a redirect action.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-listenerrule-redirectconfig.html
    /// </summary>
    public class RedirectConfig
    {

        /// <summary>
        /// Host
        /// The hostname. This component is not percent-encoded. The hostname can contain #{host}.
        /// Length Constraints: Minimum length of 1. Maximum length of 128.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Host")]
        public Union<string, IntrinsicFunction> Host { get; set; }

        /// <summary>
        /// Path
        /// The absolute path, starting with the leading &quot;/&quot;. This component is not percent-encoded. The path
        /// can contain #{host}, #{path}, and #{port}.
        /// Length Constraints: Minimum length of 1. Maximum length of 128.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Path")]
        public Union<string, IntrinsicFunction> Path { get; set; }

        /// <summary>
        /// Port
        /// The port. You can specify a value from 1 to 65535 or #{port}.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Port")]
        public Union<string, IntrinsicFunction> Port { get; set; }

        /// <summary>
        /// Protocol
        /// The protocol. You can specify HTTP, HTTPS, or #{protocol}. You can redirect HTTP to HTTP, HTTP to
        /// HTTPS, and HTTPS to HTTPS. You cannot redirect HTTPS to HTTP.
        /// Pattern: ^(HTTPS?|#\{protocol\})$
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Protocol")]
        public Union<string, IntrinsicFunction> Protocol { get; set; }

        /// <summary>
        /// Query
        /// The query parameters, URL-encoded when necessary, but not percent-encoded. Do not include the
        /// leading &quot;?&quot;, as it is automatically added. You can specify any of the reserved keywords.
        /// Length Constraints: Minimum length of 0. Maximum length of 128.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Query")]
        public Union<string, IntrinsicFunction> Query { get; set; }

        /// <summary>
        /// StatusCode
        /// The HTTP redirect code. The redirect is either permanent (HTTP 301) or temporary (HTTP 302).
        /// Valid Values: HTTP_301 | HTTP_302
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("StatusCode")]
        public Union<string, IntrinsicFunction> StatusCode { get; set; }

    }
}
