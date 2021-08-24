using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppMesh.GatewayRoute
{
    /// <summary>
    /// AWS::AppMesh::GatewayRoute HttpGatewayRouteRewrite
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-gatewayroute-httpgatewayrouterewrite.html
    /// </summary>
    public class HttpGatewayRouteRewrite
    {

        /// <summary>
        /// Path
        /// The path to rewrite.
        /// Required: No
        /// Type: HttpGatewayRoutePathRewrite
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Path")]
        public HttpGatewayRoutePathRewrite Path { get; set; }

        /// <summary>
        /// Hostname
        /// The host name to rewrite.
        /// Required: No
        /// Type: GatewayRouteHostnameRewrite
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Hostname")]
        public GatewayRouteHostnameRewrite Hostname { get; set; }

        /// <summary>
        /// Prefix
        /// The specified beginning characters to rewrite.
        /// Required: No
        /// Type: HttpGatewayRoutePrefixRewrite
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Prefix")]
        public HttpGatewayRoutePrefixRewrite Prefix { get; set; }

    }
}
