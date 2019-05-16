using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppMesh.Route
{
    /// <summary>
    /// AWS::AppMesh::Route RouteSpec
    /// An object representing the specification of a route.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-routespec.html
    /// </summary>
    public class RouteSpec
    {

        /// <summary>
        /// HttpRoute
        /// The HTTP routing information for the route.
        /// Required: No
        /// Type: HttpRoute
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("HttpRoute")]
        public HttpRoute HttpRoute { get; set; }

        /// <summary>
        /// TcpRoute
        /// The TCP routing information for the route.
        /// Required: No
        /// Type: TcpRoute
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TcpRoute")]
        public TcpRoute TcpRoute { get; set; }

    }
}
