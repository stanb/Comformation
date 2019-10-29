using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.LaunchTemplate
{
    /// <summary>
    /// AWS::EC2::LaunchTemplate NetworkInterface
    /// Specifies the parameters for a network interface.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-networkinterface.html
    /// </summary>
    public class NetworkInterface
    {

        /// <summary>
        /// Description
        /// A description for the network interface.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Description")]
        public Union<string, IntrinsicFunction> Description { get; set; }

        /// <summary>
        /// PrivateIpAddress
        /// The primary private IPv4 address of the network interface.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("PrivateIpAddress")]
        public Union<string, IntrinsicFunction> PrivateIpAddress { get; set; }

        /// <summary>
        /// PrivateIpAddresses
        /// One or more private IPv4 addresses.
        /// Required: No
        /// Type: List of PrivateIpAdd
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("PrivateIpAddresses")]
        public List<PrivateIpAdd> PrivateIpAddresses { get; set; }

        /// <summary>
        /// SecondaryPrivateIpAddressCount
        /// The number of secondary private IPv4 addresses to assign to a network interface.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SecondaryPrivateIpAddressCount")]
        public Union<int, IntrinsicFunction> SecondaryPrivateIpAddressCount { get; set; }

        /// <summary>
        /// DeviceIndex
        /// The device index for the network interface attachment.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DeviceIndex")]
        public Union<int, IntrinsicFunction> DeviceIndex { get; set; }

        /// <summary>
        /// SubnetId
        /// The ID of the subnet for the network interface.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SubnetId")]
        public Union<string, IntrinsicFunction> SubnetId { get; set; }

        /// <summary>
        /// Ipv6Addresses
        /// One or more specific IPv6 addresses from the IPv6 CIDR block range of your subnet. You can&#39;t use
        /// this option if you&#39;re specifying a number of IPv6 addresses.
        /// Required: No
        /// Type: List of Ipv6Add
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Ipv6Addresses")]
        public List<Ipv6Add> Ipv6Addresses { get; set; }

        /// <summary>
        /// AssociatePublicIpAddress
        /// Associates a public IPv4 address with eth0 for a new network interface.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AssociatePublicIpAddress")]
        public Union<bool, IntrinsicFunction> AssociatePublicIpAddress { get; set; }

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
        /// InterfaceType
        /// 		
        /// The type of network interface. To create an Elastic Fabric Adapter (EFA), specify 			efa. For more
        /// information, see Elastic Fabric Adapter in the 			Amazon Elastic Compute Cloud User Guide.
        /// 		
        /// If you are not creating an EFA, specify interface or omit this parameter.
        /// 		
        /// Valid values: interface | efa
        /// 	
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("InterfaceType")]
        public Union<string, IntrinsicFunction> InterfaceType { get; set; }

        /// <summary>
        /// Ipv6AddressCount
        /// The number of IPv6 addresses to assign to a network interface. Amazon EC2 automatically selects the
        /// IPv6 addresses from the subnet range. You can&#39;t use this option if specifying specific IPv6
        /// addresses.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Ipv6AddressCount")]
        public Union<int, IntrinsicFunction> Ipv6AddressCount { get; set; }

        /// <summary>
        /// Groups
        /// The IDs of one or more security groups.
        /// Required: No
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Groups")]
        public List<Union<string, IntrinsicFunction>> Groups { get; set; }

        /// <summary>
        /// DeleteOnTermination
        /// Indicates whether the network interface is deleted when the instance is terminated.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DeleteOnTermination")]
        public Union<bool, IntrinsicFunction> DeleteOnTermination { get; set; }

    }
}
