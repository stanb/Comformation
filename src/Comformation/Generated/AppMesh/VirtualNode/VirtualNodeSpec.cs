using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppMesh.VirtualNode
{
    /// <summary>
    /// AWS::AppMesh::VirtualNode VirtualNodeSpec
    /// An object representing the specification of a virtual node.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-virtualnodespec.html
    /// </summary>
    public class VirtualNodeSpec
    {

        /// <summary>
        /// Logging
        /// The inbound and outbound access logging information for the virtual node.
        /// Required: No
        /// Type: Logging
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Logging")]
        public Logging Logging { get; set; }

        /// <summary>
        /// Backends
        /// The backends that the virtual node is expected to send outbound traffic to.
        /// Required: No
        /// Type: List of Backend
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Backends")]
        public List<Backend> Backends { get; set; }

        /// <summary>
        /// Listeners
        /// The listeners that the virtual node is expected to receive inbound traffic from. Currently only one
        /// listener is supported per virtual node.
        /// Required: No
        /// Type: List of Listener
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Listeners")]
        public List<Listener> Listeners { get; set; }

        /// <summary>
        /// ServiceDiscovery
        /// The service discovery information for the virtual node. If your virtual node does not expect ingress
        /// traffic, you can omit this parameter.
        /// Required: No
        /// Type: ServiceDiscovery
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ServiceDiscovery")]
        public ServiceDiscovery ServiceDiscovery { get; set; }

    }
}
