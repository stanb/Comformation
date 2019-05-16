using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppMesh.Mesh
{
    /// <summary>
    /// AWS::AppMesh::Mesh EgressFilter
    /// An object representing the egress filter rules for a service mesh.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-mesh-egressfilter.html
    /// </summary>
    public class EgressFilter
    {

        /// <summary>
        /// Type
        /// The egress filter type. By default, the type is DROP_ALL, which allows egress only from virtual
        /// nodes to other defined resources in the service mesh (and any traffic to *. amazonaws. com for AWS
        /// API calls). You can set the egress filter type to ALLOW_ALL to allow egress to any endpoint inside
        /// or outside of the service mesh.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Type")]
        public Union<string, IntrinsicFunction> Type { get; set; }

    }
}
