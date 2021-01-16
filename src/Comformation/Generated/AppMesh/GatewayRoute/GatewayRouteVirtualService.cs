using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppMesh.GatewayRoute
{
    /// <summary>
    /// AWS::AppMesh::GatewayRoute GatewayRouteVirtualService
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-gatewayroute-gatewayroutevirtualservice.html
    /// </summary>
    public class GatewayRouteVirtualService
    {

        /// <summary>
        /// VirtualServiceName
        /// The name of the virtual service that traffic is routed to.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("VirtualServiceName")]
        public Union<string, IntrinsicFunction> VirtualServiceName { get; set; }

    }
}
