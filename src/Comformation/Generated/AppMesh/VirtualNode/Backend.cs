using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppMesh.VirtualNode
{
    /// <summary>
    /// AWS AppMesh VirtualNode Backend
    /// An object representing the backends that a virtual node is expected to send outbound traffic to.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-backend.html
    /// </summary>
    public class Backend
    {

        /// <summary>
        /// VirtualService
        /// Specifies a virtual service to use as a backend for a virtual node.
        /// Required: No
        /// Type: VirtualServiceBackend
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("VirtualService")]
        public VirtualServiceBackend VirtualService { get; set; }

    }
}
