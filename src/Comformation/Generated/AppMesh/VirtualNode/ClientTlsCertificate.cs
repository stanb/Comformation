using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppMesh.VirtualNode
{
    /// <summary>
    /// AWS::AppMesh::VirtualNode ClientTlsCertificate
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-clienttlscertificate.html
    /// </summary>
    public class ClientTlsCertificate
    {

        /// <summary>
        /// SDS
        /// A reference to an object that represents a client&#39;s TLS Secret Discovery Service certificate.
        /// Required: No
        /// Type: ListenerTlsSdsCertificate
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SDS")]
        public ListenerTlsSdsCertificate SDS { get; set; }

        /// <summary>
        /// File
        /// An object that represents a local file certificate. The certificate must meet specific requirements
        /// and you must have proxy authorization enabled. For more information, see Transport Layer Security
        /// (TLS).
        /// Required: No
        /// Type: ListenerTlsFileCertificate
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("File")]
        public ListenerTlsFileCertificate File { get; set; }

    }
}
