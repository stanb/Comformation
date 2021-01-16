using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppMesh.VirtualNode
{
    /// <summary>
    /// AWS::AppMesh::VirtualNode ClientPolicy
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-clientpolicy.html
    /// </summary>
    public class ClientPolicy
    {

        /// <summary>
        /// TLS
        /// A reference to an object that represents a Transport Layer Security (TLS) client policy.
        /// Required: No
        /// Type: ClientPolicyTls
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TLS")]
        public ClientPolicyTls TLS { get; set; }

    }
}
