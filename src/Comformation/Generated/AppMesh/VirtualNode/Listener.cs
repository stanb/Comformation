using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppMesh.VirtualNode
{
    /// <summary>
    /// AWS AppMesh VirtualNode Listener
    /// An object representing a listener for a virtual node.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-listener.html
    /// </summary>
    public class Listener
    {

        /// <summary>
        /// HealthCheck
        /// </summary>
        [JsonProperty("HealthCheck")]
        public HealthCheck HealthCheck { get; set; }

        /// <summary>
        /// PortMapping
        /// The port mapping information for the listener.
        /// Required: Yes
        /// Type: PortMapping
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("PortMapping")]
        public PortMapping PortMapping { get; set; }

    }
}