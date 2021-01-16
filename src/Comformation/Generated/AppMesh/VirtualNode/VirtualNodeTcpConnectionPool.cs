using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppMesh.VirtualNode
{
    /// <summary>
    /// AWS::AppMesh::VirtualNode VirtualNodeTcpConnectionPool
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-virtualnodetcpconnectionpool.html
    /// </summary>
    public class VirtualNodeTcpConnectionPool
    {

        /// <summary>
        /// MaxConnections
        /// Maximum number of outbound TCP connections Envoy can establish concurrently with all hosts in
        /// upstream cluster.
        /// Required: Yes
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MaxConnections")]
        public Union<int, IntrinsicFunction> MaxConnections { get; set; }

    }
}
