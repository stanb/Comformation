using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppMesh.VirtualGateway
{
    /// <summary>
    /// AWS::AppMesh::VirtualGateway VirtualGatewayTlsValidationContext
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualgateway-virtualgatewaytlsvalidationcontext.html
    /// </summary>
    public class VirtualGatewayTlsValidationContext
    {

        /// <summary>
        /// Trust
        /// A reference to an object that represents a TLS validation context trust.
        /// Required: Yes
        /// Type: VirtualGatewayTlsValidationContextTrust
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Trust")]
        public VirtualGatewayTlsValidationContextTrust Trust { get; set; }

    }
}
