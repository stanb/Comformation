using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppMesh.VirtualNode
{
    /// <summary>
    /// AWS::AppMesh::VirtualNode ListenerTlsFileCertificate
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-listenertlsfilecertificate.html
    /// </summary>
    public class ListenerTlsFileCertificate
    {

        /// <summary>
        /// PrivateKey
        /// The private key for a certificate stored on the file system of the virtual node that the proxy is
        /// running on.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("PrivateKey")]
        public Union<string, IntrinsicFunction> PrivateKey { get; set; }

        /// <summary>
        /// CertificateChain
        /// The certificate chain for the certificate.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CertificateChain")]
        public Union<string, IntrinsicFunction> CertificateChain { get; set; }

    }
}
