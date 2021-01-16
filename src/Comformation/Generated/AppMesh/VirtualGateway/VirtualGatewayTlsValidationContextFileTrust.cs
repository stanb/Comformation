using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppMesh.VirtualGateway
{
    /// <summary>
    /// AWS::AppMesh::VirtualGateway VirtualGatewayTlsValidationContextFileTrust
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualgateway-virtualgatewaytlsvalidationcontextfiletrust.html
    /// </summary>
    public class VirtualGatewayTlsValidationContextFileTrust
    {

        /// <summary>
        /// CertificateChain
        /// The certificate trust chain for a certificate stored on the file system of the virtual node that the
        /// proxy is running on.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CertificateChain")]
        public Union<string, IntrinsicFunction> CertificateChain { get; set; }

    }
}
