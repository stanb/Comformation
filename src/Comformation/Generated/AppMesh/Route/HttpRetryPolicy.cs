using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppMesh.Route
{
    /// <summary>
    /// AWS::AppMesh::Route HttpRetryPolicy
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-httpretrypolicy.html
    /// </summary>
    public class HttpRetryPolicy
    {

        /// <summary>
        /// MaxRetries
        /// The maximum number of retry attempts.
        /// Required: Yes
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MaxRetries")]
        public Union<int, IntrinsicFunction> MaxRetries { get; set; }

        /// <summary>
        /// PerRetryTimeout
        /// The timeout for each retry attempt.
        /// Required: Yes
        /// Type: Duration
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("PerRetryTimeout")]
        public Duration PerRetryTimeout { get; set; }

        /// <summary>
        /// HttpRetryEvents
        /// Specify at least one of the following values.
        /// server-error – HTTP status codes 500, 501, 502, 503, 504, 505, 506, 507, 508, 510, and 511
        /// gateway-error – HTTP status codes 502, 503, and 504 client-error – HTTP status code 409 stream-error
        /// – Retry on refused stream
        /// Required: No
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("HttpRetryEvents")]
        public List<Union<string, IntrinsicFunction>> HttpRetryEvents { get; set; }

        /// <summary>
        /// TcpRetryEvents
        /// Specify a valid value. The event occurs before any processing of a request has started and is
        /// encountered when the upstream is temporarily or permanently unavailable.
        /// Required: No
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TcpRetryEvents")]
        public List<Union<string, IntrinsicFunction>> TcpRetryEvents { get; set; }

    }
}
