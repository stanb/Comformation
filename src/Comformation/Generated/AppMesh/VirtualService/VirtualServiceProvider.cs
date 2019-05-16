using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppMesh.VirtualService
{
    /// <summary>
    /// AWS::AppMesh::VirtualService VirtualServiceProvider
    /// An object representing the provider for a virtual service.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualservice-virtualserviceprovider.html
    /// </summary>
    public class VirtualServiceProvider
    {

        /// <summary>
        /// VirtualNode
        /// The virtual node associated with a virtual service.
        /// Required: No
        /// Type: VirtualNodeServiceProvider
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("VirtualNode")]
        public VirtualNodeServiceProvider VirtualNode { get; set; }

        /// <summary>
        /// VirtualRouter
        /// The virtual router associated with a virtual service.
        /// Required: No
        /// Type: VirtualRouterServiceProvider
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("VirtualRouter")]
        public VirtualRouterServiceProvider VirtualRouter { get; set; }

    }
}
