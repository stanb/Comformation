using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppMesh.VirtualGateway
{
    /// <summary>
    /// AWS::AppMesh::VirtualGateway VirtualGatewayHttp2ConnectionPool
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualgateway-virtualgatewayhttp2connectionpool.html
    /// </summary>
    public class VirtualGatewayHttp2ConnectionPool
    {

        /// <summary>
        /// MaxRequests
        /// Maximum number of inflight requests Envoy can concurrently support across hosts in upstream cluster.
        /// Required: Yes
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MaxRequests")]
        public Union<int, IntrinsicFunction> MaxRequests { get; set; }

    }
}
