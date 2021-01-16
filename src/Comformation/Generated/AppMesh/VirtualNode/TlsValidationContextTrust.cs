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
        /// ACM
        /// A reference to an object that represents a TLS validation context trust for an AWS Certicate Manager
        /// (ACM) certificate.
        /// Required: No
        /// Type: TlsValidationContextAcmTrust
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ACM")]
        public TlsValidationContextAcmTrust ACM { get; set; }

        /// <summary>
        /// File
        /// An object that represents a TLS validation context trust for a local file.
        /// Required: No
        /// Type: TlsValidationContextFileTrust
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("File")]
        public TlsValidationContextFileTrust File { get; set; }

    }
}
