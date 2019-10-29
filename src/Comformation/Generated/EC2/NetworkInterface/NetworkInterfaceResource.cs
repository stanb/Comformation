using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.NetworkInterface
{
    /// <summary>
    /// AWS::EC2::NetworkInterface
    /// Describes a network interface in an Elastic Compute Cloud (EC2) instance for AWS CloudFormation.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-network-interface.html
    /// </summary>
    public class NetworkInterfaceResource : ResourceBase
    {
        public class NetworkInterfaceProperties
        {
            /// <summary>
            /// Description
            /// A description for the network interface.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// GroupSet
            /// A list of security group IDs associated with this network interface.
            /// Required: No
            /// Type: List of String
            /// Update requires: No interruption
            /// </summary>
			public List<Union<string, IntrinsicFunction>> GroupSet { get; set; }

            /// <summary>
            /// InterfaceType
            /// 		
            /// Indicates the type of network interface. To create an Elastic Fabric Adapter (EFA), specify 			efa.
            /// For more information, see 		 Elastic Fabric Adapter in the Amazon Elastic Compute Cloud User Guide.
            /// 	
            /// Required: No
            /// Type: String
            /// Allowed Values: efa
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> InterfaceType { get; set; }

            /// <summary>
            /// Ipv6AddressCount
            /// The number of IPv6 addresses to assign to a network interface. Amazon EC2 automatically selects the
            /// IPv6 addresses from the subnet range. To specify specific IPv6 addresses, use the Ipv6Addresses
            /// property and don&#39;t specify this property.
            /// Required: No
            /// Type: Integer
            /// Update requires: No interruption
            /// </summary>
			public Union<int, IntrinsicFunction> Ipv6AddressCount { get; set; }

            /// <summary>
            /// Ipv6Addresses
            /// One or more specific IPv6 addresses from the IPv6 CIDR block range of your subnet to associate with
            /// the network interface. If you&#39;re specifying a number of IPv6 addresses, use the Ipv6AddressCount
            /// property and don&#39;t specify this property.
            /// Required: No
            /// Type: InstanceIpv6Address
            /// Update requires: No interruption
            /// </summary>
			public InstanceIpv6Address Ipv6Addresses { get; set; }

            /// <summary>
            /// PrivateIpAddress
            /// Assigns a single private IP address to the network interface, which is used as the primary private
            /// IP address. If you want to specify multiple private IP address, use the PrivateIpAddresses property.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> PrivateIpAddress { get; set; }

            /// <summary>
            /// PrivateIpAddresses
            /// Assigns a list of private IP addresses to the network interface. You can specify a primary private
            /// IP address by setting the value of the Primary property to true in the PrivateIpAddressSpecification
            /// property. If you want EC2 to automatically assign private IP addresses, use the
            /// SecondaryPrivateIpAddressCount property and do not specify this property.
            /// Required: No
            /// Type: List of PrivateIpAddressSpecification
            /// Update requires: Some interruptions
            /// </summary>
			public List<PrivateIpAddressSpecification> PrivateIpAddresses { get; set; }

            /// <summary>
            /// SecondaryPrivateIpAddressCount
            /// The number of secondary private IPv4 addresses to assign to a network interface. When you specify a
            /// number of secondary IPv4 addresses, Amazon EC2 selects these IP addresses within the subnet&#39;s IPv4
            /// CIDR range. You can&#39;t specify this option and specify more than one private IP address using
            /// privateIpAddresses.
            /// The number of IP addresses you can assign to a network interface varies by instance type. For more
            /// information, see IP Addresses Per ENI Per Instance Type in the Amazon Virtual Private Cloud User
            /// Guide.
            /// Required: No
            /// Type: Integer
            /// Update requires: No interruption
            /// </summary>
			public Union<int, IntrinsicFunction> SecondaryPrivateIpAddressCount { get; set; }

            /// <summary>
            /// SourceDestCheck
            /// Indicates whether traffic to or from the instance is validated.
            /// Required: No
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
			public Union<bool, IntrinsicFunction> SourceDestCheck { get; set; }

            /// <summary>
            /// SubnetId
            /// The ID of the subnet to associate with the network interface.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> SubnetId { get; set; }

            /// <summary>
            /// Tags
            /// An arbitrary set of tags (key–value pairs) for this network interface.
            /// Required: No
            /// Type: List of Tag
            /// Update requires: No interruption
            /// </summary>
			public List<Tag> Tags { get; set; }

        }

        public string Type { get; } = "AWS::EC2::NetworkInterface";

        public NetworkInterfaceProperties Properties { get; } = new NetworkInterfaceProperties();

    }

	public static class NetworkInterfaceAttributes
	{
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> PrimaryPrivateIpAddress = new ResourceAttribute<Union<string, IntrinsicFunction>>("PrimaryPrivateIpAddress");
        public static readonly ResourceAttribute<List<Union<string, IntrinsicFunction>>> SecondaryPrivateIpAddresses = new ResourceAttribute<List<Union<string, IntrinsicFunction>>>("SecondaryPrivateIpAddresses");
	}
}
