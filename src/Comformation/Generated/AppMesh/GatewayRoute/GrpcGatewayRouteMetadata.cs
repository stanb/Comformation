using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppMesh.GatewayRoute
{
    /// <summary>
    /// AWS::AppMesh::GatewayRoute GrpcGatewayRouteMetadata
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-gatewayroute-grpcgatewayroutemetadata.html
    /// </summary>
    public class GrpcGatewayRouteMetadata
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
        /// A name for the gateway route metadata.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Name")]
        public Union<string, IntrinsicFunction> Name { get; set; }

        /// <summary>
        /// Match
        /// The criteria for determining a metadata match.
        /// Required: No
        /// Type: GatewayRouteMetadataMatch
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Match")]
        public GatewayRouteMetadataMatch Match { get; set; }

    }
}
