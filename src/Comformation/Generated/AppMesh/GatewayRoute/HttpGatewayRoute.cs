using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppMesh.GatewayRoute
{
    /// <summary>
    /// AWS::AppMesh::GatewayRoute HttpGatewayRoute
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-gatewayroute-httpgatewayroute.html
    /// </summary>
    public class HttpGatewayRoute
    {

        /// <summary>
        /// Action
        /// An object that represents the action to take if a match is determined.
        /// Required: Yes
        /// Type: HttpGatewayRouteAction
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Action")]
        public HttpGatewayRouteAction Action { get; set; }

        /// <summary>
        /// Match
        /// An object that represents the criteria for determining a request match.
        /// Required: Yes
        /// Type: HttpGatewayRouteMatch
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Match")]
        public HttpGatewayRouteMatch Match { get; set; }

    }
}
