using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppMesh.VirtualGateway
{
    /// <summary>
    /// AWS::AppMesh::VirtualGateway VirtualGatewayHttpConnectionPool
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualgateway-virtualgatewayhttpconnectionpool.html
    /// </summary>
    public class VirtualGatewayHttpConnectionPool
    {

        /// <summary>
        /// MaxConnections
        /// Maximum number of outbound TCP connections Envoy can establish concurrently with all hosts in
        /// upstream cluster.
        /// Required: Yes
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MaxConnections")]
        public Union<int, IntrinsicFunction> MaxConnections { get; set; }

        /// <summary>
        /// MaxPendingRequests
        /// Number of overflowing requests after max_connections Envoy will queue to upstream cluster.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MaxPendingRequests")]
        public Union<int, IntrinsicFunction> MaxPendingRequests { get; set; }

    }
}
