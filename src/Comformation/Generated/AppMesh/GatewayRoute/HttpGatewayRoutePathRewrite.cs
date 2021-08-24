using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppMesh.GatewayRoute
{
    /// <summary>
    /// AWS::AppMesh::GatewayRoute HttpGatewayRoutePathRewrite
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-gatewayroute-httpgatewayroutepathrewrite.html
    /// </summary>
    public class HttpGatewayRoutePathRewrite
    {

        /// <summary>
        /// Exact
        /// The exact path to rewrite.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Exact")]
        public Union<string, IntrinsicFunction> Exact { get; set; }

    }
}
