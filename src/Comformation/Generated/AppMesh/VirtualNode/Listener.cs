using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppMesh.VirtualNode
{
    /// <summary>
    /// AWS::AppMesh::VirtualNode Listener
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-listener.html
    /// </summary>
    public class Listener
    {

        /// <summary>
        /// ConnectionPool
        /// The connection pool information for the listener.
        /// Required: No
        /// Type: VirtualNodeConnectionPool
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ConnectionPool")]
        public VirtualNodeConnectionPool ConnectionPool { get; set; }

        /// <summary>
        /// Timeout
        /// An object that represents timeouts for different protocols.
        /// Required: No
        /// Type: ListenerTimeout
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Timeout")]
        public ListenerTimeout Timeout { get; set; }

        /// <summary>
        /// HealthCheck
        /// The health check information for the listener.
        /// Required: No
        /// Type: HealthCheck
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("HealthCheck")]
        public HealthCheck HealthCheck { get; set; }

        /// <summary>
        /// TLS
        /// A reference to an object that represents the Transport Layer Security (TLS) properties for a
        /// listener.
        /// Required: No
        /// Type: ListenerTls
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TLS")]
        public ListenerTls TLS { get; set; }

        /// <summary>
        /// PortMapping
        /// The port mapping information for the listener.
        /// Required: Yes
        /// Type: PortMapping
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("PortMapping")]
        public PortMapping PortMapping { get; set; }

        /// <summary>
        /// OutlierDetection
        /// The outlier detection information for the listener.
        /// Required: No
        /// Type: OutlierDetection
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("OutlierDetection")]
        public OutlierDetection OutlierDetection { get; set; }

    }
}
