using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppMesh.VirtualNode
{
    /// <summary>
    /// AWS::AppMesh::VirtualNode TlsValidationContext
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-tlsvalidationcontext.html
    /// </summary>
    public class TlsValidationContext
    {

        /// <summary>
        /// Trust
        /// A reference to an object that represents a TLS validation context trust.
        /// Required: Yes
        /// Type: TlsValidationContextTrust
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Trust")]
        public TlsValidationContextTrust Trust { get; set; }

    }
}
