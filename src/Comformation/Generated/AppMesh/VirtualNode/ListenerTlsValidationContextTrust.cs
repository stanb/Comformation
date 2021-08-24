using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppMesh.VirtualNode
{
    /// <summary>
    /// AWS::AppMesh::VirtualNode ListenerTlsValidationContextTrust
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-listenertlsvalidationcontexttrust.html
    /// </summary>
    public class ListenerTlsValidationContextTrust
    {

        /// <summary>
        /// SDS
        /// A reference to an object that represents a listener&#39;s Transport Layer Security (TLS) Secret
        /// Discovery Service validation context trust.
        /// Required: No
        /// Type: TlsValidationContextSdsTrust
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SDS")]
        public TlsValidationContextSdsTrust SDS { get; set; }

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
