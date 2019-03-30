using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppMesh.VirtualNode
{
    /// <summary>
    /// Missing documentation http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-healthcheck.html
    /// </summary>
    public class HealthCheck
    {

        /// <summary>
        /// Path
        /// </summary>
        [JsonProperty("Path")]
        public Union<string, IntrinsicFunction> Path { get; set; }

        /// <summary>
        /// UnhealthyThreshold
        /// </summary>
        [JsonProperty("UnhealthyThreshold")]
        public Union<int, IntrinsicFunction> UnhealthyThreshold { get; set; }

        /// <summary>
        /// Port
        /// </summary>
        [JsonProperty("Port")]
        public Union<int, IntrinsicFunction> Port { get; set; }

        /// <summary>
        /// HealthyThreshold
        /// </summary>
        [JsonProperty("HealthyThreshold")]
        public Union<int, IntrinsicFunction> HealthyThreshold { get; set; }

        /// <summary>
        /// TimeoutMillis
        /// </summary>
        [JsonProperty("TimeoutMillis")]
        public Union<int, IntrinsicFunction> TimeoutMillis { get; set; }

        /// <summary>
        /// Protocol
        /// </summary>
        [JsonProperty("Protocol")]
        public Union<string, IntrinsicFunction> Protocol { get; set; }

        /// <summary>
        /// IntervalMillis
        /// </summary>
        [JsonProperty("IntervalMillis")]
        public Union<int, IntrinsicFunction> IntervalMillis { get; set; }

    }
}
