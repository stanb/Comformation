using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.Instance
{
    /// <summary>
    /// AWS::EC2::Instance NetworkInterface
    /// Specifies a network interface that is to be attached to an instance.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-network-iface-embedded.html
    /// </summary>
    public class NetworkInterface
    {

        /// <summary>
        /// AssociatePublicIpAddress
        /// One or more IPv6 addresses to assign to the network interface. You cannot specify this option and
        /// the option to assign a number of IPv6 addresses in the same request. You cannot specify this option
        /// if you&#39;ve specified a minimum number of instances to launch.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AssociatePublicIpAddress")]
        public Union<bool, IntrinsicFunction> AssociatePublicIpAddress { get; set; }

        /// <summary>
        /// DeleteOnTermination
        /// If set to true, the interface is deleted when the instance is terminated. You can specify true only
        /// if creating a new network interface when launching an instance.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DeleteOnTermination")]
        public Union<bool, IntrinsicFunction> DeleteOnTermination { get; set; }

        /// <summary>
        /// Description
        /// The description of the network interface. Applies only if creating a network interface when
        /// launching an instance.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Description")]
        public Union<string, IntrinsicFunction> Description { get; set; }

        /// <summary>
        /// DeviceIndex
        /// The position of the network interface in the attachment order. A primary network interface has a
        /// device index of 0.
        /// If you specify a network interface when launching an instance, you must specify the device index.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DeviceIndex")]
        public Union<string, IntrinsicFunction> DeviceIndex { get; set; }

        /// <summary>
        /// GroupSet
        /// The IDs of the security groups for the network interface. Applies only if creating a network
        /// interface when launching an instance.
        /// Required: No
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("GroupSet")]
        public List<Union<string, IntrinsicFunction>> GroupSet { get; set; }

        /// <summary>
        /// Ipv6AddressCount
        /// A number of IPv6 addresses to assign to the network interface. Amazon EC2 chooses the IPv6 addresses
        /// from the range of the subnet. You cannot specify this option and the option to assign specific IPv6
        /// addresses in the same request. You can specify this option if you&#39;ve specified a minimum number of
        /// instances to launch.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Ipv6AddressCount")]
        public Union<int, IntrinsicFunction> Ipv6AddressCount { get; set; }

        /// <summary>
        /// Ipv6Addresses
        /// The IPv6 addresses associated with the network interface.
        /// Required: No
        /// Type: List of InstanceIpv6Address
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Ipv6Addresses")]
        public List<InstanceIpv6Address> Ipv6Addresses { get; set; }

        /// <summary>
        /// NetworkInterfaceId
        /// The ID of the network interface.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("NetworkInterfaceId")]
        public Union<string, IntrinsicFunction> NetworkInterfaceId { get; set; }

        /// <summary>
        /// PrivateIpAddress
        /// The private IPv4 address of the network interface. Applies only if creating a network interface when
        /// launching an instance. You cannot specify this option if you&#39;re launching 	more than one instance in
        /// a RunInstances request.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("PrivateIpAddress")]
        public Union<string, IntrinsicFunction> PrivateIpAddress { get; set; }

        /// <summary>
        /// PrivateIpAddresses
        /// One or more private IPv4 addresses to assign to the network interface. Only one private IPv4 address
        /// can be designated as primary. You cannot specify this option if you&#39;re 	launching more than one
        /// instance in a RunInstances request.
        /// Required: No
        /// Type: List of PrivateIpAddressSpecification
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("PrivateIpAddresses")]
        public List<PrivateIpAddressSpecification> PrivateIpAddresses { get; set; }

        /// <summary>
        /// SecondaryPrivateIpAddressCount
        /// The number of secondary private IPv4 addresses. You can&#39;t specify this option and specify more than
        /// one private IP address using the private IP addresses option. You cannot specify this option if
        /// you&#39;re 	launching more than one instance in a RunInstances request.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SecondaryPrivateIpAddressCount")]
        public Union<int, IntrinsicFunction> SecondaryPrivateIpAddressCount { get; set; }

        /// <summary>
        /// SubnetId
        /// The ID of the subnet.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SubnetId")]
        public Union<string, IntrinsicFunction> SubnetId { get; set; }

    }
}
