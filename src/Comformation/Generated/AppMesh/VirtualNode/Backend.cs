using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppMesh.VirtualNode
{
    /// <summary>
    /// AWS::AppMesh::VirtualNode Backend
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-backend.html
    /// </summary>
    public class Backend
    {

        /// <summary>
        /// VirtualService
        /// Specifies a virtual service to use as a backend.
        /// Required: No
        /// Type: VirtualServiceBackend
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("VirtualService")]
        public VirtualServiceBackend VirtualService { get; set; }

    }
}
