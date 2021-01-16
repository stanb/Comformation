using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppMesh.Route
{
    /// <summary>
    /// AWS::AppMesh::Route RouteSpec
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-routespec.html
    /// </summary>
    public class RouteSpec
    {

        /// <summary>
        /// HttpRoute
        /// An object that represents the specification of an HTTP route.
        /// Required: No
        /// Type: HttpRoute
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("HttpRoute")]
        public HttpRoute HttpRoute { get; set; }

        /// <summary>
        /// Priority
        /// The priority for the route. Routes are matched based on the specified value, where 0 is the highest
        /// priority.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Priority")]
        public Union<int, IntrinsicFunction> Priority { get; set; }

        /// <summary>
        /// Http2Route
        /// An object that represents the specification of an HTTP/2 route.
        /// Required: No
        /// Type: HttpRoute
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Http2Route")]
        public HttpRoute Http2Route { get; set; }

        /// <summary>
        /// GrpcRoute
        /// An object that represents the specification of a gRPC route.
        /// Required: No
        /// Type: GrpcRoute
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("GrpcRoute")]
        public GrpcRoute GrpcRoute { get; set; }

        /// <summary>
        /// TcpRoute
        /// An object that represents the specification of a TCP route.
        /// Required: No
        /// Type: TcpRoute
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TcpRoute")]
        public TcpRoute TcpRoute { get; set; }

    }
}
