using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppMesh.VirtualNode
{
    /// <summary>
    /// AWS::AppMesh::VirtualNode VirtualNodeConnectionPool
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-virtualnodeconnectionpool.html
    /// </summary>
    public class VirtualNodeConnectionPool
    {

        /// <summary>
        /// TCP
        /// An object that represents a type of connection pool.
        /// Required: No
        /// Type: VirtualNodeTcpConnectionPool
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TCP")]
        public VirtualNodeTcpConnectionPool TCP { get; set; }

        /// <summary>
        /// HTTP2
        /// An object that represents a type of connection pool.
        /// Required: No
        /// Type: VirtualNodeHttp2ConnectionPool
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("HTTP2")]
        public VirtualNodeHttp2ConnectionPool HTTP2 { get; set; }

        /// <summary>
        /// HTTP
        /// An object that represents a type of connection pool.
        /// Required: No
        /// Type: VirtualNodeHttpConnectionPool
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("HTTP")]
        public VirtualNodeHttpConnectionPool HTTP { get; set; }

        /// <summary>
        /// GRPC
        /// An object that represents a type of connection pool.
        /// Required: No
        /// Type: VirtualNodeGrpcConnectionPool
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("GRPC")]
        public VirtualNodeGrpcConnectionPool GRPC { get; set; }

    }
}
