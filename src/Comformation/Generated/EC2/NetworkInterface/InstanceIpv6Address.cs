using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.NetworkInterface
{
    /// <summary>
    /// AWS::EC2::NetworkInterface InstanceIpv6Address
    /// Describes an IPv6 address to associate with the network interface.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinterface-instanceipv6address.html
    /// </summary>
    public class InstanceIpv6Address
    {

        /// <summary>
        /// Ipv6Address
        /// The IPv6 address to associate with the network interface.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Ipv6Address")]
        public Union<string, IntrinsicFunction> Ipv6Address { get; set; }

    }
}
