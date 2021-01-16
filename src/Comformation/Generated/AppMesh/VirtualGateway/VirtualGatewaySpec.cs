using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppMesh.VirtualGateway
{
    /// <summary>
    /// AWS::AppMesh::VirtualGateway VirtualGatewaySpec
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualgateway-virtualgatewayspec.html
    /// </summary>
    public class VirtualGatewaySpec
    {

        /// <summary>
        /// Logging
        /// An object that represents logging information.
        /// Required: No
        /// Type: VirtualGatewayLogging
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Logging")]
        public VirtualGatewayLogging Logging { get; set; }

        /// <summary>
        /// Listeners
        /// The listeners that the mesh endpoint is expected to receive inbound traffic from. You can specify
        /// one listener.
        /// Required: Yes
        /// Type: List of VirtualGatewayListener
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Listeners")]
        public List<VirtualGatewayListener> Listeners { get; set; }

        /// <summary>
        /// BackendDefaults
        /// A reference to an object that represents the defaults for backends.
        /// Required: No
        /// Type: VirtualGatewayBackendDefaults
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("BackendDefaults")]
        public VirtualGatewayBackendDefaults BackendDefaults { get; set; }

    }
}
