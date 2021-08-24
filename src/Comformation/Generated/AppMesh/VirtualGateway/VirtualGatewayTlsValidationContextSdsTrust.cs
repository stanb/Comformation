using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppMesh.VirtualGateway
{
    /// <summary>
    /// AWS::AppMesh::VirtualGateway VirtualGatewayTlsValidationContextSdsTrust
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualgateway-virtualgatewaytlsvalidationcontextsdstrust.html
    /// </summary>
    public class VirtualGatewayTlsValidationContextSdsTrust
    {

        /// <summary>
        /// SecretName
        /// A reference to an object that represents the name of the secret for a virtual gateway&#39;s Transport
        /// Layer Security (TLS) Secret Discovery Service validation context trust.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SecretName")]
        public Union<string, IntrinsicFunction> SecretName { get; set; }

    }
}
