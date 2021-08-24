using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppMesh.VirtualNode
{
    /// <summary>
    /// AWS::AppMesh::VirtualNode ListenerTimeout
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-listenertimeout.html
    /// </summary>
    public class ListenerTimeout
    {

        /// <summary>
        /// TCP
        /// An object that represents types of timeouts.
        /// Required: No
        /// Type: TcpTimeout
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TCP")]
        public TcpTimeout TCP { get; set; }

        /// <summary>
        /// HTTP2
        /// An object that represents types of timeouts.
        /// Required: No
        /// Type: HttpTimeout
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("HTTP2")]
        public HttpTimeout HTTP2 { get; set; }

        /// <summary>
        /// HTTP
        /// An object that represents types of timeouts.
        /// Required: No
        /// Type: HttpTimeout
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("HTTP")]
        public HttpTimeout HTTP { get; set; }

        /// <summary>
        /// GRPC
        /// An object that represents types of timeouts.
        /// Required: No
        /// Type: GrpcTimeout
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("GRPC")]
        public GrpcTimeout GRPC { get; set; }

    }
}
