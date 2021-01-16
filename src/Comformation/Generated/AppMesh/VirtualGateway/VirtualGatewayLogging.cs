using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppMesh.VirtualGateway
{
    /// <summary>
    /// AWS::AppMesh::VirtualGateway VirtualGatewayLogging
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualgateway-virtualgatewaylogging.html
    /// </summary>
    public class VirtualGatewayLogging
    {

        /// <summary>
        /// AccessLog
        /// The access log configuration.
        /// Required: No
        /// Type: VirtualGatewayAccessLog
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AccessLog")]
        public VirtualGatewayAccessLog AccessLog { get; set; }

    }
}
