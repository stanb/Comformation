using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppMesh.VirtualGateway
{
    /// <summary>
    /// AWS::AppMesh::VirtualGateway VirtualGatewayTlsValidationContextAcmTrust
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualgateway-virtualgatewaytlsvalidationcontextacmtrust.html
    /// </summary>
    public class VirtualGatewayTlsValidationContextAcmTrust
    {

        /// <summary>
        /// CertificateAuthorityArns
        /// One or more ACM Amazon Resource Name (ARN)s.
        /// Required: Yes
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CertificateAuthorityArns")]
        public List<Union<string, IntrinsicFunction>> CertificateAuthorityArns { get; set; }

    }
}
