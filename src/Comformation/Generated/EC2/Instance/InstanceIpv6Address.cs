using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.Instance
{
    /// <summary>
    /// EC2 NetworkInterface Ipv6Addresses
    /// Ipv6Addresses is a property of the AWS::EC2::NetworkInterface resource that specifies an IPv6 address to
    /// associate with the network interface.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinterface-ipv6addresses.html
    /// </summary>
    public class InstanceIpv6Address
    {

        /// <summary>
        /// Ipv6Address
        /// The IPv6 address to associate with the network interface.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("Ipv6Address")]
        public Union<string, IntrinsicFunction> Ipv6Address { get; set; }

    }
}
