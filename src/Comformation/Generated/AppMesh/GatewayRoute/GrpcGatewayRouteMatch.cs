using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppMesh.GatewayRoute
{
    /// <summary>
    /// AWS::AppMesh::GatewayRoute GrpcGatewayRouteMatch
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-gatewayroute-grpcgatewayroutematch.html
    /// </summary>
    public class GrpcGatewayRouteMatch
    {

        /// <summary>
        /// ServiceName
        /// The fully qualified domain name for the service to match from the request.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ServiceName")]
        public Union<string, IntrinsicFunction> ServiceName { get; set; }

        /// <summary>
        /// Hostname
        /// The gateway route host name to be matched on.
        /// Required: No
        /// Type: GatewayRouteHostnameMatch
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Hostname")]
        public GatewayRouteHostnameMatch Hostname { get; set; }

        /// <summary>
        /// Metadata
        /// The gateway route metadata to be matched on.
        /// Required: No
        /// Type: List of GrpcGatewayRouteMetadata
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Metadata")]
        public List<GrpcGatewayRouteMetadata> Metadata { get; set; }

    }
}
