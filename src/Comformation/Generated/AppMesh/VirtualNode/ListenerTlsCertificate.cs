using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppMesh.VirtualNode
{
    /// <summary>
    /// AWS::AppMesh::VirtualNode ListenerTlsCertificate
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-listenertlscertificate.html
    /// </summary>
    public class ListenerTlsCertificate
    {

        /// <summary>
        /// SDS
        /// A reference to an object that represents a listener&#39;s Secret Discovery Service certificate.
        /// Required: No
        /// Type: ListenerTlsSdsCertificate
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SDS")]
        public ListenerTlsSdsCertificate SDS { get; set; }

        /// <summary>
        /// ACM
        /// A reference to an object that represents an AWS Certificate Manager certificate.
        /// Required: No
        /// Type: ListenerTlsAcmCertificate
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ACM")]
        public ListenerTlsAcmCertificate ACM { get; set; }

        /// <summary>
        /// File
        /// A reference to an object that represents a local file certificate.
        /// Required: No
        /// Type: ListenerTlsFileCertificate
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("File")]
        public ListenerTlsFileCertificate File { get; set; }

    }
}
