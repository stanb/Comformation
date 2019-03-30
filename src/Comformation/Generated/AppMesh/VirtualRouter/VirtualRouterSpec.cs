using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppMesh.VirtualRouter
{
    /// <summary>
    /// AWS AppMesh VirtualRouter VirtualRouterSpec
    /// An object representing the specification of a virtual router.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualrouter-virtualrouterspec.html
    /// </summary>
    public class VirtualRouterSpec
    {

        /// <summary>
        /// Listeners
        /// The listeners that the virtual router is expected to receive inbound traffic from. Currently only
        /// one listener is supported per virtual router.
        /// Required: Yes
        /// Type: List of VirtualRouterListener
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Listeners")]
        public List<VirtualRouterListener> Listeners { get; set; }

    }
}
