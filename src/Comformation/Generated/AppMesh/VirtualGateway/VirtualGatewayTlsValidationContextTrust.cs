using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppMesh.VirtualGateway
{
    /// <summary>
    /// AWS::AppMesh::VirtualGateway VirtualGatewayTlsValidationContextTrust
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualgateway-virtualgatewaytlsvalidationcontexttrust.html
    /// </summary>
    public class VirtualGatewayTlsValidationContextTrust
    {

        /// <summary>
        /// ACM
        /// A reference to an object that represents a TLS validation context trust for an AWS Certicate Manager
        /// (ACM) certificate.
        /// Required: No
        /// Type: VirtualGatewayTlsValidationContextAcmTrust
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ACM")]
        public VirtualGatewayTlsValidationContextAcmTrust ACM { get; set; }

        /// <summary>
        /// File
        /// An object that represents a TLS validation context trust for a local file.
        /// Required: No
        /// Type: VirtualGatewayTlsValidationContextFileTrust
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("File")]
        public VirtualGatewayTlsValidationContextFileTrust File { get; set; }

    }
}
