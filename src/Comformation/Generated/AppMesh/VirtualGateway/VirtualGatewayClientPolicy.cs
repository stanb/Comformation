using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppMesh.VirtualGateway
{
    /// <summary>
    /// AWS::AppMesh::VirtualGateway VirtualGatewayClientPolicy
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualgateway-virtualgatewayclientpolicy.html
    /// </summary>
    public class VirtualGatewayClientPolicy
    {

        /// <summary>
        /// TLS
        /// A reference to an object that represents a Transport Layer Security (TLS) client policy.
        /// Required: No
        /// Type: VirtualGatewayClientPolicyTls
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TLS")]
        public VirtualGatewayClientPolicyTls TLS { get; set; }

    }
}
