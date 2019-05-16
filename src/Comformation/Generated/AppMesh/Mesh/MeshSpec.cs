using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppMesh.Mesh
{
    /// <summary>
    /// AWS::AppMesh::Mesh MeshSpec
    /// An object representing the specification of a service mesh.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-mesh-meshspec.html
    /// </summary>
    public class MeshSpec
    {

        /// <summary>
        /// EgressFilter
        /// The egress filter rules for the service mesh.
        /// Required: No
        /// Type: EgressFilter
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("EgressFilter")]
        public EgressFilter EgressFilter { get; set; }

    }
}
