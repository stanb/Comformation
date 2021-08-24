using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppMesh.VirtualGateway
{
    /// <summary>
    /// AWS::AppMesh::VirtualGateway VirtualGatewayClientPolicyTls
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualgateway-virtualgatewayclientpolicytls.html
    /// </summary>
    public class VirtualGatewayClientPolicyTls
    {

        /// <summary>
        /// Validation
        /// A reference to an object that represents a Transport Layer Security (TLS) validation context.
        /// Required: Yes
        /// Type: VirtualGatewayTlsValidationContext
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Validation")]
        public VirtualGatewayTlsValidationContext Validation { get; set; }

        /// <summary>
        /// Enforce
        /// Whether the policy is enforced. The default is True, if a value isn&#39;t specified.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Enforce")]
        public Union<bool, IntrinsicFunction> Enforce { get; set; }

        /// <summary>
        /// Ports
        /// One or more ports that the policy is enforced for.
        /// Required: No
        /// Type: List of Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Ports")]
        public List<Union<int, IntrinsicFunction>> Ports { get; set; }

        /// <summary>
        /// Certificate
        /// A reference to an object that represents a virtual gateway&#39;s client&#39;s Transport Layer Security (TLS)
        /// certificate.
        /// Required: No
        /// Type: VirtualGatewayClientTlsCertificate
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Certificate")]
        public VirtualGatewayClientTlsCertificate Certificate { get; set; }

    }
}
