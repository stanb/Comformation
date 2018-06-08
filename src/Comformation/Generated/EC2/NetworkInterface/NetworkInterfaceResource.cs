using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.NetworkInterface
{
    /// <summary>
    /// AWS::EC2::NetworkInterface
    /// Describes a network interface in an Elastic Compute Cloud (EC2) instance for AWS CloudFormation. This is
    /// provided in a list in the NetworkInterfaces property of AWS::EC2::Instance.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-network-interface.html
    /// </summary>
    public class NetworkInterfaceResource : ResourceBase
    {
        public class NetworkInterfaceProperties
        {
            /// <summary>
            /// Description
            /// The description of this network interface.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption.
            /// </summary>
			public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// GroupSet
            /// A list of security group IDs associated with this network interface.
            /// Required: No
            /// Type: List of strings.
            /// Update requires: No interruption
            /// </summary>
			public Union<List<string>, IntrinsicFunction> GroupSet { get; set; }

            /// <summary>
            /// InterfaceType
            /// </summary>
			public Union<string, IntrinsicFunction> InterfaceType { get; set; }

            /// <summary>
            /// Ipv6AddressCount
            /// The number of IPv6 addresses to associate with the network interface. EC2 automatically selects the
            /// IPv6 addresses from the subnet range. To specify specific IPv6 addresses, use the Ipv6Addresses
            /// property and don't specify this property.
            /// Required: No
            /// Type: Integer
            /// Update requires: No interruption
            /// </summary>
			public Union<int, IntrinsicFunction> Ipv6AddressCount { get; set; }

            /// <summary>
            /// Ipv6Addresses
            /// One or more specific IPv6 addresses from the IPv6 CIDR block range of your subnet to associate with
            /// the network interface. If you're specifying a number of IPv6 addresses, use the Ipv6AddressCount
            /// property and don't specify this property.
            /// Required: No
            /// Type: List of EC2 NetworkInterface Ipv6Addresses
            /// Update requires: No interruption
            /// </summary>
			public Union<InstanceIpv6Address, IntrinsicFunction> Ipv6Addresses { get; set; }

            /// <summary>
            /// PrivateIpAddress
            /// Assigns a single private IP address to the network interface, which is used as the primary private
            /// IP address. If you want to specify multiple private IP address, use the PrivateIpAddresses property.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement.
            /// </summary>
			public Union<string, IntrinsicFunction> PrivateIpAddress { get; set; }

            /// <summary>
            /// PrivateIpAddresses
            /// Assigns a list of private IP addresses to the network interface. You can specify a primary private
            /// IP address by setting the value of the Primary property to true in the PrivateIpAddressSpecification
            /// property. If you want EC2 to automatically assign private IP addresses, use the
            /// SecondaryPrivateIpAddressCount property and do not specify this property.
            /// For information about the maximum number of private IP addresses, see Private IP Addresses Per ENI
            /// Per Instance Type in the Amazon EC2 User Guide for Linux Instances.
            /// Required: No
            /// Type: list of PrivateIpAddressSpecification.
            /// Update requires: Replacement if you change the primary private IP address. If not, update requires
            /// No interruption.
            /// </summary>
			public Union<List<PrivateIpAddressSpecification>, IntrinsicFunction> PrivateIpAddresses { get; set; }

            /// <summary>
            /// SecondaryPrivateIpAddressCount
            /// The number of secondary private IP addresses that EC2 automatically assigns to the network
            /// interface. EC2 uses the value of the PrivateIpAddress property as the primary private IP address. If
            /// you don't specify that property, EC2 automatically assigns both the primary and secondary private IP
            /// addresses.
            /// If you want to specify your own list of private IP addresses, use the PrivateIpAddresses property
            /// and do not specify this property.
            /// For information about the maximum number of private IP addresses, see Private IP Addresses Per ENI
            /// Per Instance Type in the Amazon EC2 User Guide for Linux Instances.
            /// Required: No
            /// Type: Integer.
            /// Update requires: No interruption.
            /// </summary>
			public Union<int, IntrinsicFunction> SecondaryPrivateIpAddressCount { get; set; }

            /// <summary>
            /// SourceDestCheck
            /// Flag indicating whether traffic to or from the instance is validated.
            /// Required: No
            /// Type: Boolean
            /// Update requires: No interruption.
            /// </summary>
			public Union<bool, IntrinsicFunction> SourceDestCheck { get; set; }

            /// <summary>
            /// SubnetId
            /// The ID of the subnet to associate with the network interface.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement.
            /// </summary>
			public Union<string, IntrinsicFunction> SubnetId { get; set; }

            /// <summary>
            /// Tags
            /// An arbitrary set of tags (key–value pairs) for this network interface.
            /// Required: No
            /// Type: AWS CloudFormation Resource Tags
            /// Update requires: No interruption.
            /// </summary>
			public Union<List<Tag>, IntrinsicFunction> Tags { get; set; }

        }
    
        public string Type { get; } = "AWS::EC2::NetworkInterface";
        
        public NetworkInterfaceProperties Properties { get; } = new NetworkInterfaceProperties();
    }

	public static class NetworkInterfaceAttributes
	{
        public static readonly ResourceAttribute<string> PrimaryPrivateIpAddress = new ResourceAttribute<string>("PrimaryPrivateIpAddress");
        public static readonly ResourceAttribute<List<string>> SecondaryPrivateIpAddresses = new ResourceAttribute<List<string>>("SecondaryPrivateIpAddresses");
	}
}
