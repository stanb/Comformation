using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppMesh.VirtualGateway
{
    /// <summary>
    /// AWS::AppMesh::VirtualGateway VirtualGatewayListenerTlsCertificate
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualgateway-virtualgatewaylistenertlscertificate.html
    /// </summary>
    public class VirtualGatewayListenerTlsCertificate
    {

        /// <summary>
        /// SDS
        /// A reference to an object that represents a virtual gateway&#39;s listener&#39;s Secret Discovery Service
        /// certificate.
        /// Required: No
        /// Type: VirtualGatewayListenerTlsSdsCertificate
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SDS")]
        public VirtualGatewayListenerTlsSdsCertificate SDS { get; set; }

        /// <summary>
        /// ACM
        /// A reference to an object that represents an AWS Certificate Manager certificate.
        /// Required: No
        /// Type: VirtualGatewayListenerTlsAcmCertificate
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ACM")]
        public VirtualGatewayListenerTlsAcmCertificate ACM { get; set; }

        /// <summary>
        /// File
        /// A reference to an object that represents a local file certificate.
        /// Required: No
        /// Type: VirtualGatewayListenerTlsFileCertificate
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("File")]
        public VirtualGatewayListenerTlsFileCertificate File { get; set; }

    }
}
