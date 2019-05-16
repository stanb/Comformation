using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppMesh.VirtualNode
{
    /// <summary>
    /// AWS::AppMesh::VirtualNode VirtualServiceBackend
    /// An object representing a virtual service backend for a virtual node.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-virtualservicebackend.html
    /// </summary>
    public class VirtualServiceBackend
    {

        /// <summary>
        /// VirtualServiceName
        /// The name of the virtual service that is acting as a virtual node backend.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("VirtualServiceName")]
        public Union<string, IntrinsicFunction> VirtualServiceName { get; set; }

    }
}
