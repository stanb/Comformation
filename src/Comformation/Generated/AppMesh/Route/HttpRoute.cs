using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppMesh.Route
{
    /// <summary>
    /// AWS::AppMesh::Route HttpRoute
    /// An object representing the HTTP routing specification for a route.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-httproute.html
    /// </summary>
    public class HttpRoute
    {

        /// <summary>
        /// Action
        /// The action to take if a match is determined.
        /// Required: Yes
        /// Type: HttpRouteAction
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Action")]
        public HttpRouteAction Action { get; set; }

        /// <summary>
        /// Match
        /// The criteria for determining an HTTP request match.
        /// Required: Yes
        /// Type: HttpRouteMatch
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Match")]
        public HttpRouteMatch Match { get; set; }

    }
}
