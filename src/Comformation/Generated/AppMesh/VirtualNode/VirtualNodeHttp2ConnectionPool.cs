using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppMesh.VirtualNode
{
    /// <summary>
    /// AWS::AppMesh::VirtualNode VirtualNodeHttp2ConnectionPool
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-virtualnodehttp2connectionpool.html
    /// </summary>
    public class VirtualNodeHttp2ConnectionPool
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
