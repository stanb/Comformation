using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppMesh.GatewayRoute
{
    /// <summary>
    /// AWS::AppMesh::GatewayRoute HttpGatewayRouteHeader
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-gatewayroute-httpgatewayrouteheader.html
    /// </summary>
    public class HttpGatewayRouteHeader
    {

        /// <summary>
        /// Invert
        /// Specify True to match anything except the match criteria. The default value is False.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Invert")]
        public Union<bool, IntrinsicFunction> Invert { get; set; }

        /// <summary>
        /// Name
        /// A name for the HTTP header in the gateway route that will be matched on.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Name")]
        public Union<string, IntrinsicFunction> Name { get; set; }

        /// <summary>
        /// Match
        /// An object that represents the method and value to match with the header value sent in a request.
        /// Specify one match method.
        /// Required: No
        /// Type: HttpGatewayRouteHeaderMatch
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Match")]
        public HttpGatewayRouteHeaderMatch Match { get; set; }

    }
}
