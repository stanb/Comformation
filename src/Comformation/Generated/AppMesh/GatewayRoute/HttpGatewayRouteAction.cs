using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppMesh.GatewayRoute
{
    /// <summary>
    /// AWS::AppMesh::GatewayRoute HttpGatewayRouteAction
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-gatewayroute-httpgatewayrouteaction.html
    /// </summary>
    public class HttpGatewayRouteAction
    {

        /// <summary>
        /// Target
        /// An object that represents the target that traffic is routed to when a request matches the gateway
        /// route.
        /// Required: Yes
        /// Type: GatewayRouteTarget
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Target")]
        public GatewayRouteTarget Target { get; set; }

        /// <summary>
        /// Rewrite
        /// The gateway route action to rewrite.
        /// Required: No
        /// Type: HttpGatewayRouteRewrite
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Rewrite")]
        public HttpGatewayRouteRewrite Rewrite { get; set; }

    }
}
