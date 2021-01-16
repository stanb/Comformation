using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppMesh.VirtualNode
{
    /// <summary>
    /// AWS::AppMesh::VirtualNode BackendDefaults
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-backenddefaults.html
    /// </summary>
    public class BackendDefaults
    {

        /// <summary>
        /// ClientPolicy
        /// A reference to an object that represents a client policy.
        /// Required: No
        /// Type: ClientPolicy
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ClientPolicy")]
        public ClientPolicy ClientPolicy { get; set; }

    }
}
