using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppMesh.VirtualRouter
{
    /// <summary>
    /// AWS::AppMesh::VirtualRouter PortMapping
    /// An object representing a virtual router listener port mapping.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualrouter-portmapping.html
    /// </summary>
    public class PortMapping
    {

        /// <summary>
        /// Port
        /// The port used for the port mapping.
        /// Required: Yes
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Port")]
        public Union<int, IntrinsicFunction> Port { get; set; }

        /// <summary>
        /// Protocol
        /// The protocol used for the port mapping. Specify one protocol.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Protocol")]
        public Union<string, IntrinsicFunction> Protocol { get; set; }

    }
}
