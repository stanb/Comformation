using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppMesh.VirtualGateway
{
    /// <summary>
    /// AWS::AppMesh::VirtualGateway VirtualGatewayListener
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualgateway-virtualgatewaylistener.html
    /// </summary>
    public class VirtualGatewayListener
    {

        /// <summary>
        /// ConnectionPool
        /// The connection pool information for the listener.
        /// Required: No
        /// Type: VirtualGatewayConnectionPool
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ConnectionPool")]
        public VirtualGatewayConnectionPool ConnectionPool { get; set; }

        /// <summary>
        /// HealthCheck
        /// The health check information for the listener.
        /// Required: No
        /// Type: VirtualGatewayHealthCheckPolicy
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("HealthCheck")]
        public VirtualGatewayHealthCheckPolicy HealthCheck { get; set; }

        /// <summary>
        /// TLS
        /// A reference to an object that represents the Transport Layer Security (TLS) properties for the
        /// listener.
        /// Required: No
        /// Type: VirtualGatewayListenerTls
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TLS")]
        public VirtualGatewayListenerTls TLS { get; set; }

        /// <summary>
        /// PortMapping
        /// The port mapping information for the listener.
        /// Required: Yes
        /// Type: VirtualGatewayPortMapping
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("PortMapping")]
        public VirtualGatewayPortMapping PortMapping { get; set; }

    }
}
