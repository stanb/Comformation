using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppMesh.VirtualNode
{
    /// <summary>
    /// AWS::AppMesh::VirtualNode HealthCheck
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-healthcheck.html
    /// </summary>
    public class HealthCheck
    {

        /// <summary>
        /// Path
        /// The destination path for the health check request. This value is only used if the specified protocol
        /// is HTTP or HTTP/2. For any other protocol, this value is ignored.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Path")]
        public Union<string, IntrinsicFunction> Path { get; set; }

        /// <summary>
        /// UnhealthyThreshold
        /// The number of consecutive failed health checks that must occur before declaring a virtual node
        /// unhealthy.
        /// Required: Yes
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("UnhealthyThreshold")]
        public Union<int, IntrinsicFunction> UnhealthyThreshold { get; set; }

        /// <summary>
        /// Port
        /// The destination port for the health check request. This port must match the port defined in the
        /// PortMapping for the listener.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Port")]
        public Union<int, IntrinsicFunction> Port { get; set; }

        /// <summary>
        /// HealthyThreshold
        /// The number of consecutive successful health checks that must occur before declaring listener
        /// healthy.
        /// Required: Yes
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("HealthyThreshold")]
        public Union<int, IntrinsicFunction> HealthyThreshold { get; set; }

        /// <summary>
        /// TimeoutMillis
        /// The amount of time to wait when receiving a response from the health check, in milliseconds.
        /// Required: Yes
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TimeoutMillis")]
        public Union<int, IntrinsicFunction> TimeoutMillis { get; set; }

        /// <summary>
        /// Protocol
        /// The protocol for the health check request. If you specify grpc, then your service must conform to
        /// the GRPC Health Checking Protocol.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Protocol")]
        public Union<string, IntrinsicFunction> Protocol { get; set; }

        /// <summary>
        /// IntervalMillis
        /// The time period in milliseconds between each health check execution.
        /// Required: Yes
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("IntervalMillis")]
        public Union<int, IntrinsicFunction> IntervalMillis { get; set; }

    }
}
