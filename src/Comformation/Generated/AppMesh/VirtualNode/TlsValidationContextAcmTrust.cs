using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppMesh.VirtualNode
{
    /// <summary>
    /// AWS::AppMesh::VirtualNode TlsValidationContextAcmTrust
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-tlsvalidationcontextacmtrust.html
    /// </summary>
    public class TlsValidationContextAcmTrust
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
