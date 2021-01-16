using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ElasticLoadBalancingV2.Listener
{
    /// <summary>
    /// AWS::ElasticLoadBalancingV2::Listener RedirectConfig
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-listener-redirectconfig.html
    /// </summary>
    public class RedirectConfig
    {

        /// <summary>
        /// Path
        /// The absolute path, starting with the leading &quot;/&quot;. This component is not percent-encoded. The path
        /// can contain #{host}, #{path}, and #{port}.
        /// Required: No
        /// Type: String
        /// Minimum: 1
        /// Maximum: 128
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Path")]
        public Union<string, IntrinsicFunction> Path { get; set; }

        /// <summary>
        /// Query
        /// The query parameters, URL-encoded when necessary, but not percent-encoded. Do not include the
        /// leading &quot;?&quot;, as it is automatically added. You can specify any of the reserved keywords.
        /// Required: No
        /// Type: String
        /// Minimum: 0
        /// Maximum: 128
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Query")]
        public Union<string, IntrinsicFunction> Query { get; set; }

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
        /// Host
        /// The hostname. This component is not percent-encoded. The hostname can contain #{host}.
        /// Required: No
        /// Type: String
        /// Minimum: 1
        /// Maximum: 128
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Host")]
        public Union<string, IntrinsicFunction> Host { get; set; }

        /// <summary>
        /// Protocol
        /// The protocol. You can specify HTTP, HTTPS, or #{protocol}. You can redirect HTTP to HTTP, HTTP to
        /// HTTPS, and HTTPS to HTTPS. You cannot redirect HTTPS to HTTP.
        /// Required: No
        /// Type: String
        /// Pattern: ^(HTTPS?|#\{protocol\})$
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Protocol")]
        public Union<string, IntrinsicFunction> Protocol { get; set; }

        /// <summary>
        /// StatusCode
        /// The HTTP redirect code. The redirect is either permanent (HTTP 301) or temporary (HTTP 302).
        /// Required: Yes
        /// Type: String
        /// Allowed values: HTTP_301 | HTTP_302
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("StatusCode")]
        public Union<string, IntrinsicFunction> StatusCode { get; set; }

    }
}
