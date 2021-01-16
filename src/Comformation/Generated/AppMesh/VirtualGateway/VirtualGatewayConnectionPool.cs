using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppMesh.VirtualGateway
{
    /// <summary>
    /// AWS::AppMesh::VirtualGateway VirtualGatewayConnectionPool
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualgateway-virtualgatewayconnectionpool.html
    /// </summary>
    public class VirtualGatewayConnectionPool
    {

        /// <summary>
        /// HTTP2
        /// An object that represents a type of connection pool.
        /// Required: No
        /// Type: VirtualGatewayHttp2ConnectionPool
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("HTTP2")]
        public VirtualGatewayHttp2ConnectionPool HTTP2 { get; set; }

        /// <summary>
        /// HTTP
        /// An object that represents a type of connection pool.
        /// Required: No
        /// Type: VirtualGatewayHttpConnectionPool
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("HTTP")]
        public VirtualGatewayHttpConnectionPool HTTP { get; set; }

        /// <summary>
        /// GRPC
        /// An object that represents a type of connection pool.
        /// Required: No
        /// Type: VirtualGatewayGrpcConnectionPool
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("GRPC")]
        public VirtualGatewayGrpcConnectionPool GRPC { get; set; }

    }
}
