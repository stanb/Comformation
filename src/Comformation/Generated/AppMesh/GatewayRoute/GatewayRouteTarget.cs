using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppMesh.GatewayRoute
{
    /// <summary>
    /// AWS::AppMesh::GatewayRoute GatewayRouteTarget
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-gatewayroute-gatewayroutetarget.html
    /// </summary>
    public class GatewayRouteTarget
    {

        /// <summary>
        /// VirtualService
        /// An object that represents a virtual service gateway route target.
        /// Required: Yes
        /// Type: GatewayRouteVirtualService
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("VirtualService")]
        public GatewayRouteVirtualService VirtualService { get; set; }

    }
}
