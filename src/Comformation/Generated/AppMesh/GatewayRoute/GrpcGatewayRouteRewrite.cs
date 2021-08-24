using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppMesh.GatewayRoute
{
    /// <summary>
    /// AWS::AppMesh::GatewayRoute GrpcGatewayRouteRewrite
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-gatewayroute-grpcgatewayrouterewrite.html
    /// </summary>
    public class GrpcGatewayRouteRewrite
    {

        /// <summary>
        /// Hostname
        /// The host name of the gateway route to rewrite.
        /// Required: No
        /// Type: GatewayRouteHostnameRewrite
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Hostname")]
        public GatewayRouteHostnameRewrite Hostname { get; set; }

    }
}
