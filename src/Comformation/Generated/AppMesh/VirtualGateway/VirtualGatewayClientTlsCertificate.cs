using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppMesh.VirtualGateway
{
    /// <summary>
    /// AWS::AppMesh::VirtualGateway VirtualGatewayClientTlsCertificate
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualgateway-virtualgatewayclienttlscertificate.html
    /// </summary>
    public class VirtualGatewayClientTlsCertificate
    {

        /// <summary>
        /// SDS
        /// A reference to an object that represents a virtual gateway&#39;s client&#39;s Secret Discovery Service
        /// certificate.
        /// Required: No
        /// Type: VirtualGatewayListenerTlsSdsCertificate
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SDS")]
        public VirtualGatewayListenerTlsSdsCertificate SDS { get; set; }

        /// <summary>
        /// File
        /// An object that represents a local file certificate. The certificate must meet specific requirements
        /// and you must have proxy authorization enabled. For more information, see Transport Layer Security
        /// (TLS) .
        /// Required: No
        /// Type: VirtualGatewayListenerTlsFileCertificate
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("File")]
        public VirtualGatewayListenerTlsFileCertificate File { get; set; }

    }
}
