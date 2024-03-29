using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppMesh.VirtualNode
{
    /// <summary>
    /// AWS::AppMesh::VirtualNode DnsServiceDiscovery
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-dnsservicediscovery.html
    /// </summary>
    public class DnsServiceDiscovery
    {

        /// <summary>
        /// Hostname
        /// Specifies the DNS service discovery hostname for the virtual node.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Hostname")]
        public Union<string, IntrinsicFunction> Hostname { get; set; }

        /// <summary>
        /// ResponseType
        /// Specifies the DNS response type for the virtual node.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ResponseType")]
        public Union<string, IntrinsicFunction> ResponseType { get; set; }

    }
}
