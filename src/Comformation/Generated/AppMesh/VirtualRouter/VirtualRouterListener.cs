using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppMesh.VirtualRouter
{
    /// <summary>
    /// AWS::AppMesh::VirtualRouter VirtualRouterListener
    /// An object that represents a virtual router listener.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualrouter-virtualrouterlistener.html
    /// </summary>
    public class VirtualRouterListener
    {

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
