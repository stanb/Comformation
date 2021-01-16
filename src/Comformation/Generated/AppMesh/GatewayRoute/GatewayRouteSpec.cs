using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppMesh.GatewayRoute
{
    /// <summary>
    /// AWS::AppMesh::GatewayRoute GatewayRouteSpec
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-gatewayroute-gatewayroutespec.html
    /// </summary>
    public class GatewayRouteSpec
    {

        /// <summary>
        /// HttpRoute
        /// An object that represents the specification of an HTTP gateway route.
        /// Required: No
        /// Type: HttpGatewayRoute
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("HttpRoute")]
        public HttpGatewayRoute HttpRoute { get; set; }

        /// <summary>
        /// Http2Route
        /// An object that represents the specification of an HTTP/2 gateway route.
        /// Required: No
        /// Type: HttpGatewayRoute
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Http2Route")]
        public HttpGatewayRoute Http2Route { get; set; }

        /// <summary>
        /// GrpcRoute
        /// An object that represents the specification of a gRPC gateway route.
        /// Required: No
        /// Type: GrpcGatewayRoute
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("GrpcRoute")]
        public GrpcGatewayRoute GrpcRoute { get; set; }

    }
}
