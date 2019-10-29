using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppMesh.VirtualService
{
    /// <summary>
    /// AWS::AppMesh::VirtualService VirtualServiceSpec
    /// An object that represents the specification of a virtual service.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualservice-virtualservicespec.html
    /// </summary>
    public class VirtualServiceSpec
    {

        /// <summary>
        /// Provider
        /// The App Mesh object that is acting as the provider for a virtual service. You can specify a single
        /// virtual node or virtual router.
        /// Required: No
        /// Type: VirtualServiceProvider
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Provider")]
        public VirtualServiceProvider Provider { get; set; }

    }
}
