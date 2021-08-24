using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppMesh.VirtualGateway
{
    /// <summary>
    /// AWS::AppMesh::VirtualGateway VirtualGatewayListenerTls
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualgateway-virtualgatewaylistenertls.html
    /// </summary>
    public class VirtualGatewayListenerTls
    {

        /// <summary>
        /// Validation
        /// A reference to an object that represents a virtual gateway&#39;s listener&#39;s Transport Layer Security
        /// (TLS) validation context.
        /// Required: No
        /// Type: VirtualGatewayListenerTlsValidationContext
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Validation")]
        public VirtualGatewayListenerTlsValidationContext Validation { get; set; }

        /// <summary>
        /// Mode
        /// Specify one of the following modes.
        /// STRICT – Listener only accepts connections with TLS enabled. PERMISSIVE – Listener accepts
        /// connections with or without TLS enabled. DISABLED – Listener only accepts connections without TLS.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Mode")]
        public Union<string, IntrinsicFunction> Mode { get; set; }

        /// <summary>
        /// Certificate
        /// An object that represents a Transport Layer Security (TLS) certificate.
        /// Required: Yes
        /// Type: VirtualGatewayListenerTlsCertificate
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Certificate")]
        public VirtualGatewayListenerTlsCertificate Certificate { get; set; }

    }
}
