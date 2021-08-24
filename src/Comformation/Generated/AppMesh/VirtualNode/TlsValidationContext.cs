using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppMesh.VirtualNode
{
    /// <summary>
    /// AWS::AppMesh::VirtualNode TlsValidationContext
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-tlsvalidationcontext.html
    /// </summary>
    public class TlsValidationContext
    {

        /// <summary>
        /// SubjectAlternativeNames
        /// A reference to an object that represents the SANs for a Transport Layer Security (TLS) validation
        /// context.
        /// Required: No
        /// Type: SubjectAlternativeNames
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SubjectAlternativeNames")]
        public SubjectAlternativeNames SubjectAlternativeNames { get; set; }

        /// <summary>
        /// Trust
        /// A reference to where to retrieve the trust chain when validating a peer’s Transport Layer Security
        /// (TLS) certificate.
        /// Required: Yes
        /// Type: TlsValidationContextTrust
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Trust")]
        public TlsValidationContextTrust Trust { get; set; }

    }
}
