using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppMesh.GatewayRoute
{
    /// <summary>
    /// AWS::AppMesh::GatewayRoute GrpcGatewayRoute
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-gatewayroute-grpcgatewayroute.html
    /// </summary>
    public class GrpcGatewayRoute
    {

        /// <summary>
        /// Action
        /// An object that represents the action to take if a match is determined.
        /// Required: Yes
        /// Type: GrpcGatewayRouteAction
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Action")]
        public GrpcGatewayRouteAction Action { get; set; }

        /// <summary>
        /// Match
        /// An object that represents the criteria for determining a request match.
        /// Required: Yes
        /// Type: GrpcGatewayRouteMatch
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Match")]
        public GrpcGatewayRouteMatch Match { get; set; }

    }
}
