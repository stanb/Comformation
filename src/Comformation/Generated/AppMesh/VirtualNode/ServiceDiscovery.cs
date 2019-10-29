using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppMesh.VirtualNode
{
    /// <summary>
    /// AWS::AppMesh::VirtualNode ServiceDiscovery
    /// An object that represents the service discovery information for a virtual node.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-servicediscovery.html
    /// </summary>
    public class ServiceDiscovery
    {

        /// <summary>
        /// DNS
        /// Specifies the DNS information for the virtual node.
        /// Required: No
        /// Type: DnsServiceDiscovery
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DNS")]
        public DnsServiceDiscovery DNS { get; set; }

        /// <summary>
        /// AWSCloudMap
        /// Specifies any AWS Cloud Map information for the virtual node.
        /// Required: No
        /// Type: AwsCloudMapServiceDiscovery
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AWSCloudMap")]
        public AwsCloudMapServiceDiscovery AWSCloudMap { get; set; }

    }
}
