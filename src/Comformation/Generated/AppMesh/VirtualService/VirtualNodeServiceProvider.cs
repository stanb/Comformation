using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppMesh.VirtualService
{
    /// <summary>
    /// AWS::AppMesh::VirtualService VirtualNodeServiceProvider
    /// An object representing a virtual node service provider.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualservice-virtualnodeserviceprovider.html
    /// </summary>
    public class VirtualNodeServiceProvider
    {

        /// <summary>
        /// VirtualNodeName
        /// The name of the virtual node that is acting as a service provider.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("VirtualNodeName")]
        public Union<string, IntrinsicFunction> VirtualNodeName { get; set; }

    }
}
