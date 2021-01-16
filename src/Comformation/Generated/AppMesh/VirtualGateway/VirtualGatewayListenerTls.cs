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
