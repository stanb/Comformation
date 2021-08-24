using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppMesh.VirtualNode
{
    /// <summary>
    /// AWS::AppMesh::VirtualNode TlsValidationContextTrust
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-tlsvalidationcontexttrust.html
    /// </summary>
    public class TlsValidationContextTrust
    {

        /// <summary>
        /// SDS
        /// A reference to an object that represents a Transport Layer Security (TLS) Secret Discovery Service
        /// validation context trust.
        /// Required: No
        /// Type: TlsValidationContextSdsTrust
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SDS")]
        public TlsValidationContextSdsTrust SDS { get; set; }

        /// <summary>
        /// ACM
        /// A reference to an object that represents a Transport Layer Security (TLS) validation context trust
        /// for an AWS Certificate Manager certificate.
        /// Required: No
        /// Type: TlsValidationContextAcmTrust
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ACM")]
        public TlsValidationContextAcmTrust ACM { get; set; }

        /// <summary>
        /// File
        /// An object that represents a Transport Layer Security (TLS) validation context trust for a local
        /// file.
        /// Required: No
        /// Type: TlsValidationContextFileTrust
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("File")]
        public TlsValidationContextFileTrust File { get; set; }

    }
}
