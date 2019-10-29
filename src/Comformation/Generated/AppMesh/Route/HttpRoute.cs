using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppMesh.Route
{
    /// <summary>
    /// AWS::AppMesh::Route HttpRoute
    /// An object that represents an HTTP or HTTP/2 route type.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-httproute.html
    /// </summary>
    public class HttpRoute
    {

        /// <summary>
        /// Action
        /// An object that represents the action to take if a match is determined.
        /// Required: Yes
        /// Type: HttpRouteAction
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Action")]
        public HttpRouteAction Action { get; set; }

        /// <summary>
        /// RetryPolicy
        /// An object that represents a retry policy.
        /// Required: No
        /// Type: HttpRetryPolicy
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RetryPolicy")]
        public HttpRetryPolicy RetryPolicy { get; set; }

        /// <summary>
        /// Match
        /// An object that represents the criteria for determining a request match.
        /// Required: Yes
        /// Type: HttpRouteMatch
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Match")]
        public HttpRouteMatch Match { get; set; }

    }
}
