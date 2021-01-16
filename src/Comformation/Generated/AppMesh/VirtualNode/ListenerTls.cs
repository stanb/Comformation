using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppMesh.VirtualNode
{
    /// <summary>
    /// AWS::AppMesh::VirtualNode ListenerTls
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-listenertls.html
    /// </summary>
    public class ListenerTls
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
        /// A reference to an object that represents a listener&#39;s TLS certificate.
        /// Required: Yes
        /// Type: ListenerTlsCertificate
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Certificate")]
        public ListenerTlsCertificate Certificate { get; set; }

    }
}
