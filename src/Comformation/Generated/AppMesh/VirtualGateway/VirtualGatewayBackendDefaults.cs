using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppMesh.VirtualGateway
{
    /// <summary>
    /// AWS::AppMesh::VirtualGateway VirtualGatewayBackendDefaults
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualgateway-virtualgatewaybackenddefaults.html
    /// </summary>
    public class VirtualGatewayBackendDefaults
    {

        /// <summary>
        /// ClientPolicy
        /// A reference to an object that represents a client policy.
        /// Required: No
        /// Type: VirtualGatewayClientPolicy
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ClientPolicy")]
        public VirtualGatewayClientPolicy ClientPolicy { get; set; }

    }
}
