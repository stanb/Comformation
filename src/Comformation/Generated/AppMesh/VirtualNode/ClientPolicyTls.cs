using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppMesh.VirtualNode
{
    /// <summary>
    /// AWS::AppMesh::VirtualNode ClientPolicyTls
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-clientpolicytls.html
    /// </summary>
    public class ClientPolicyTls
    {

        /// <summary>
        /// Validation
        /// A reference to an object that represents a TLS validation context.
        /// Required: Yes
        /// Type: TlsValidationContext
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Validation")]
        public TlsValidationContext Validation { get; set; }

        /// <summary>
        /// Enforce
        /// Whether the policy is enforced. The default is True, if a value isn&#39;t specified.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Enforce")]
        public Union<bool, IntrinsicFunction> Enforce { get; set; }

        /// <summary>
        /// Ports
        /// One or more ports that the policy is enforced for.
        /// Required: No
        /// Type: List of Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Ports")]
        public List<Union<int, IntrinsicFunction>> Ports { get; set; }

    }
}
