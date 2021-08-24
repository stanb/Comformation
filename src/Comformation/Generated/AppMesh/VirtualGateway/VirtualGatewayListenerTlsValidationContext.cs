using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppMesh.VirtualGateway
{
    /// <summary>
    /// AWS::AppMesh::VirtualGateway VirtualGatewayListenerTlsValidationContext
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualgateway-virtualgatewaylistenertlsvalidationcontext.html
    /// </summary>
    public class VirtualGatewayListenerTlsValidationContext
    {

        /// <summary>
        /// SubjectAlternativeNames
        /// A reference to an object that represents the SANs for a virtual gateway listener&#39;s Transport Layer
        /// Security (TLS) validation context.
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
        /// Type: VirtualGatewayListenerTlsValidationContextTrust
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Trust")]
        public VirtualGatewayListenerTlsValidationContextTrust Trust { get; set; }

    }
}
