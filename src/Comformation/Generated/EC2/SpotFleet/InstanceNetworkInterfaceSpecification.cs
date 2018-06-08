using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.SpotFleet
{
    /// <summary>
    /// Amazon Elastic Compute Cloud SpotFleet NetworkInterfaces
    /// NetworkInterfaces is a property of the Amazon Elastic Compute Cloud SpotFleet LaunchSpecifications property
    /// that defines the network interface of the instances in a Spot fleet.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-spotfleetrequestconfigdata-launchspecifications-networkinterfaces.html
    /// </summary>
    public class InstanceNetworkInterfaceSpecification
    {

        /// <summary>
        /// AssociatePublicIpAddress
        /// Indicates whether to assign a public IP address to an instance that you launch in a VPC. You can
        /// assign the public IP address can only to a network interface for eth0, and only to a new network
        /// interface, not an existing one.
        /// Required: No
        /// Type: Boolean
        /// </summary>
        [JsonProperty("AssociatePublicIpAddress")]
        public Union<bool, IntrinsicFunction> AssociatePublicIpAddress { get; set; }

        /// <summary>
        /// DeleteOnTermination
        /// Indicates whether to delete the network interface when the instance terminates.
        /// Required: No
        /// Type: Boolean
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
        /// The network interface's position in the attachment order.
        /// Required: No
        /// Type: Integer
        /// </summary>
        [JsonProperty("DeviceIndex")]
        public Union<int, IntrinsicFunction> DeviceIndex { get; set; }

        /// <summary>
        /// Groups
        /// A list of security group IDs to associate with this network interface.
        /// Required: No
        /// Type: List of String values
        /// </summary>
        [JsonProperty("Groups")]
        public Union<List<string>, IntrinsicFunction> Groups { get; set; }

        /// <summary>
        /// Ipv6AddressCount
        /// The number of IPv6 addresses to associate with the network interface. Amazon Elastic Compute Cloud
        /// automatically selects the IPv6 addresses from the subnet range. To specify specific IPv6 addresses,
        /// use the Ipv6Addresses property and don't specify this property.
        /// Required: No
        /// Type: Integer
        /// </summary>
        [JsonProperty("Ipv6AddressCount")]
        public Union<int, IntrinsicFunction> Ipv6AddressCount { get; set; }

        /// <summary>
        /// Ipv6Addresses
        /// One or more specific IPv6 addresses from the IPv6 CIDR block range of your subnet to associate with
        /// the network interface. To specify a number of IPv6 addresses, use the Ipv6AddressCount property and
        /// don't specify this property.
        /// Required: No
        /// Type: List of EC2 NetworkInterface Ipv6Addresses
        /// </summary>
        [JsonProperty("Ipv6Addresses")]
        public Union<List<InstanceIpv6Address>, IntrinsicFunction> Ipv6Addresses { get; set; }

        /// <summary>
        /// NetworkInterfaceId
        /// A network interface ID.
        /// Required: No
        /// Type: String
        /// </summary>
        [JsonProperty("NetworkInterfaceId")]
        public Union<string, IntrinsicFunction> NetworkInterfaceId { get; set; }

        /// <summary>
        /// PrivateIpAddresses
        /// One or more private IP addresses to assign to the network interface.
        /// Required: No
        /// Type: List of Amazon Elastic Compute Cloud SpotFleet NetworkInterfaces PrivateIpAddresses
        /// </summary>
        [JsonProperty("PrivateIpAddresses")]
        public Union<List<PrivateIpAddressSpecification>, IntrinsicFunction> PrivateIpAddresses { get; set; }

        /// <summary>
        /// SecondaryPrivateIpAddressCount
        /// The number of secondary private IP addresses that Amazon EC2 automatically assigns to the network
        /// interface.
        /// Required: No
        /// Type: Integer
        /// </summary>
        [JsonProperty("SecondaryPrivateIpAddressCount")]
        public Union<int, IntrinsicFunction> SecondaryPrivateIpAddressCount { get; set; }

        /// <summary>
        /// SubnetId
        /// The ID of the subnet to associate with the network interface.
        /// Required: Conditional. If you don't specify the NetworkInterfaceId property, you must specify this
        /// property.
        /// Type: String
        /// </summary>
        [JsonProperty("SubnetId")]
        public Union<string, IntrinsicFunction> SubnetId { get; set; }

    }
}
