using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppMesh.VirtualGateway
{
    /// <summary>
    /// AWS::AppMesh::VirtualGateway VirtualGatewayListenerTlsFileCertificate
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualgateway-virtualgatewaylistenertlsfilecertificate.html
    /// </summary>
    public class VirtualGatewayListenerTlsFileCertificate
    {

        /// <summary>
        /// PrivateKey
        /// The private key for a certificate stored on the file system of the mesh endpoint that the proxy is
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
