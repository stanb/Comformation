using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppMesh.VirtualGateway
{
    /// <summary>
    /// AWS::AppMesh::VirtualGateway VirtualGatewayAccessLog
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualgateway-virtualgatewayaccesslog.html
    /// </summary>
    public class VirtualGatewayAccessLog
    {

        /// <summary>
        /// File
        /// The file object to send virtual gateway access logs to.
        /// Required: No
        /// Type: VirtualGatewayFileAccessLog
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("File")]
        public VirtualGatewayFileAccessLog File { get; set; }

    }
}
