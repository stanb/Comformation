using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.Instance
{
    /// <summary>
    /// EC2 NetworkInterface Embedded Property Type
    /// The EC2 Network Interface type is an embedded property of the AWS::EC2::Instance type. It specifies a network
    /// interface that is to be attached.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-network-iface-embedded.html
    /// </summary>
    public class NetworkInterface
    {

        /// <summary>
        /// AssociatePublicIpAddress
        /// Indicates whether the network interface receives a public IP address. You can associate a public IP
        /// address with a network interface only if it has a device index of eth0 and if it is a new network
        /// interface (not an existing one). In other words, if you specify true, don&#39;t specify a network
        /// interface ID. For more information, see Amazon EC2 Instance IP Addressing.
        /// Required: No
        /// Type: Boolean.
        /// </summary>
        [JsonProperty("AssociatePublicIpAddress")]
        public Union<bool, IntrinsicFunction> AssociatePublicIpAddress { get; set; }

        /// <summary>
        /// DeleteOnTermination
        /// Whether to delete the network interface when the instance terminates.
        /// Required: No
        /// Type: Boolean.
        /// </summary>
        [JsonProperty("DeleteOnTermination")]
        public Union<bool, IntrinsicFunction> DeleteOnTermination { get; set; }

        /// <summary>
        /// Description
        /// The description of this network interface.
        /// Required: No
        /// Type: String
        /// </summary>
        [JsonProperty("Description")]
        public Union<string, IntrinsicFunction> Description { get; set; }

        /// <summary>
        /// DeviceIndex
        /// The network interface&#39;s position in the attachment order.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("DeviceIndex")]
        public Union<string, IntrinsicFunction> DeviceIndex { get; set; }

        /// <summary>
        /// GroupSet
        /// A list of security group IDs associated with this network interface.
        /// Required: No
        /// Type: List of strings.
        /// </summary>
        [JsonProperty("GroupSet")]
        public Union<List<string>, IntrinsicFunction> GroupSet { get; set; }

        /// <summary>
        /// Ipv6AddressCount
        /// The number of IPv6 addresses to associate with the network interface. Amazon EC2 automatically
        /// selects the IPv6 addresses from the subnet range. To specify specific IPv6 addresses, use the
        /// Ipv6Addresses property and don&#39;t specify this property.
        /// For restrictions on which instance types support IPv6 addresses, see the RunInstances action in the
        /// Amazon EC2 API Reference.
        /// Required: No
        /// Type: Integer
        /// </summary>
        [JsonProperty("Ipv6AddressCount")]
        public Union<int, IntrinsicFunction> Ipv6AddressCount { get; set; }

        /// <summary>
        /// Ipv6Addresses
        /// One or more specific IPv6 addresses from the IPv6 CIDR block range of your subnet to associate with
        /// the network interface. To specify a number of IPv6 addresses, use the Ipv6AddressCount property and
        /// don&#39;t specify this property.
        /// For information about restrictions on which instance types support IPv6 addresses, see the
        /// RunInstances action in the Amazon EC2 API Reference.
        /// Required: No
        /// Type: List of EC2 NetworkInterface Ipv6Addresses
        /// </summary>
        [JsonProperty("Ipv6Addresses")]
        public Union<List<InstanceIpv6Address>, IntrinsicFunction> Ipv6Addresses { get; set; }

        /// <summary>
        /// NetworkInterfaceId
        /// An existing network interface ID.
        /// Required: Conditional. If you don&#39;t specify the SubnetId property, you must specify this property.
        /// Type: String
        /// </summary>
        [JsonProperty("NetworkInterfaceId")]
        public Union<string, IntrinsicFunction> NetworkInterfaceId { get; set; }

        /// <summary>
        /// PrivateIpAddress
        /// Assigns a single private IP address to the network interface, which is used as the primary private
        /// IP address. If you want to specify multiple private IP address, use the PrivateIpAddresses property.
        /// Required: No
        /// Type: String
        /// </summary>
        [JsonProperty("PrivateIpAddress")]
        public Union<string, IntrinsicFunction> PrivateIpAddress { get; set; }

        /// <summary>
        /// PrivateIpAddresses
        /// Assigns a list of private IP addresses to the network interface. You can specify a primary private
        /// IP address by setting the value of the Primary property to true in the PrivateIpAddressSpecification
        /// property. If you want Amazon EC2 to automatically assign private IP addresses, use the
        /// SecondaryPrivateIpCount property and do not specify this property.
        /// For information about the maximum number of private IP addresses, see Private IP Addresses Per ENI
        /// Per Instance Type in the Amazon EC2 User Guide for Linux Instances.
        /// Required: No
        /// Type: list of PrivateIpAddressSpecification
        /// </summary>
        [JsonProperty("PrivateIpAddresses")]
        public Union<List<PrivateIpAddressSpecification>, IntrinsicFunction> PrivateIpAddresses { get; set; }

        /// <summary>
        /// SecondaryPrivateIpAddressCount
        /// The number of secondary private IP addresses that Amazon EC2 auto assigns to the network interface.
        /// Amazon EC2 uses the value of the PrivateIpAddress property as the primary private IP address. If you
        /// don&#39;t specify that property, Amazon EC2 auto assigns both the primary and secondary private IP
        /// addresses.
        /// If you want to specify your own list of private IP addresses, use the PrivateIpAddresses property
        /// and do not specify this property.
        /// For information about the maximum number of private IP addresses, see Private IP Addresses Per ENI
        /// Per Instance Type in the Amazon EC2 User Guide for Linux Instances.
        /// Required: No
        /// Type: Integer.
        /// </summary>
        [JsonProperty("SecondaryPrivateIpAddressCount")]
        public Union<int, IntrinsicFunction> SecondaryPrivateIpAddressCount { get; set; }

        /// <summary>
        /// SubnetId
        /// The ID of the subnet to associate with the network interface.
        /// Required: Conditional. If you don&#39;t specify the NetworkInterfaceId property, you must specify this
        /// property.
        /// Type: String
        /// </summary>
        [JsonProperty("SubnetId")]
        public Union<string, IntrinsicFunction> SubnetId { get; set; }

    }
}
