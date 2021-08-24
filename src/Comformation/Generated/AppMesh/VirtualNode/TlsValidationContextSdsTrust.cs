using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppMesh.VirtualNode
{
    /// <summary>
    /// AWS::AppMesh::VirtualNode TlsValidationContextSdsTrust
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-tlsvalidationcontextsdstrust.html
    /// </summary>
    public class TlsValidationContextSdsTrust
    {

        /// <summary>
        /// SecretName
        /// A reference to an object that represents the name of the secret for a Transport Layer Security (TLS)
        /// Secret Discovery Service validation context trust.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SecretName")]
        public Union<string, IntrinsicFunction> SecretName { get; set; }

    }
}
