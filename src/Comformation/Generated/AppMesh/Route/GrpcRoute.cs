using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppMesh.Route
{
    /// <summary>
    /// AWS::AppMesh::Route GrpcRoute
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-grpcroute.html
    /// </summary>
    public class GrpcRoute
    {

        /// <summary>
        /// Action
        /// An object that represents the action to take if a match is determined.
        /// Required: Yes
        /// Type: GrpcRouteAction
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Action")]
        public GrpcRouteAction Action { get; set; }

        /// <summary>
        /// Timeout
        /// An object that represents types of timeouts.
        /// Required: No
        /// Type: GrpcTimeout
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Timeout")]
        public GrpcTimeout Timeout { get; set; }

        /// <summary>
        /// RetryPolicy
        /// An object that represents a retry policy.
        /// Required: No
        /// Type: GrpcRetryPolicy
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RetryPolicy")]
        public GrpcRetryPolicy RetryPolicy { get; set; }

        /// <summary>
        /// Match
        /// An object that represents the criteria for determining a request match.
        /// Required: Yes
        /// Type: GrpcRouteMatch
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Match")]
        public GrpcRouteMatch Match { get; set; }

    }
}
