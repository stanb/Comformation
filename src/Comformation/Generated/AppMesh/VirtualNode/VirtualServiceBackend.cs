using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppMesh.VirtualNode
{
    /// <summary>
    /// AWS::AppMesh::VirtualNode VirtualServiceBackend
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-virtualservicebackend.html
    /// </summary>
    public class VirtualServiceBackend
    {

        /// <summary>
        /// ClientPolicy
        /// A reference to an object that represents the client policy for a backend.
        /// Required: No
        /// Type: ClientPolicy
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ClientPolicy")]
        public ClientPolicy ClientPolicy { get; set; }

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
