using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppMesh.VirtualService
{
    /// <summary>
    /// AWS::AppMesh::VirtualService VirtualRouterServiceProvider
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualservice-virtualrouterserviceprovider.html
    /// </summary>
    public class VirtualRouterServiceProvider
    {

        /// <summary>
        /// VirtualRouterName
        /// The name of the virtual router that is acting as a service provider.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("VirtualRouterName")]
        public Union<string, IntrinsicFunction> VirtualRouterName { get; set; }

    }
}
