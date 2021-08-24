using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppMesh.VirtualNode
{
    /// <summary>
    /// AWS::AppMesh::VirtualNode ListenerTlsSdsCertificate
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-listenertlssdscertificate.html
    /// </summary>
    public class ListenerTlsSdsCertificate
    {

        /// <summary>
        /// SecretName
        /// A reference to an object that represents the name of the secret requested from the Secret Discovery
        /// Service provider representing Transport Layer Security (TLS) materials like a certificate or
        /// certificate chain.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SecretName")]
        public Union<string, IntrinsicFunction> SecretName { get; set; }

    }
}
