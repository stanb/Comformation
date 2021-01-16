using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppMesh.VirtualNode
{
    /// <summary>
    /// AWS::AppMesh::VirtualNode ListenerTlsAcmCertificate
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-listenertlsacmcertificate.html
    /// </summary>
    public class ListenerTlsAcmCertificate
    {

        /// <summary>
        /// CertificateArn
        /// The Amazon Resource Name (ARN) for the certificate. The certificate must meet specific requirements
        /// and you must have proxy authorization enabled. For more information, see Transport Layer Security
        /// (TLS).
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CertificateArn")]
        public Union<string, IntrinsicFunction> CertificateArn { get; set; }

    }
}
