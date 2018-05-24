using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.NetworkInterface
{
    /// <summary>
    ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-network-interface.html
    /// </summary>
    public class NetworkInterfaceResource : ResourceBase
    {
        public class NetworkInterfaceProperties
        {
            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-network-interface.html#cfn-awsec2networkinterface-description
            /// </summary>
			public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-network-interface.html#cfn-awsec2networkinterface-groupset
            /// </summary>
			public Union<List<string>, IntrinsicFunction> GroupSet { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-network-interface.html#cfn-ec2-networkinterface-interfacetype
            /// </summary>
			public Union<string, IntrinsicFunction> InterfaceType { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-network-interface.html#cfn-ec2-networkinterface-ipv6addresscount
            /// </summary>
			public Union<int?, IntrinsicFunction> Ipv6AddressCount { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-network-interface.html#cfn-ec2-networkinterface-ipv6addresses
            /// </summary>
			public Union<InstanceIpv6Address, IntrinsicFunction> Ipv6Addresses { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-network-interface.html#cfn-awsec2networkinterface-privateipaddress
            /// </summary>
			public Union<string, IntrinsicFunction> PrivateIpAddress { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-network-interface.html#cfn-awsec2networkinterface-privateipaddresses
            /// </summary>
			public Union<List<PrivateIpAddressSpecification>, IntrinsicFunction> PrivateIpAddresses { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-network-interface.html#cfn-awsec2networkinterface-secondaryprivateipcount
            /// </summary>
			public Union<int?, IntrinsicFunction> SecondaryPrivateIpAddressCount { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-network-interface.html#cfn-awsec2networkinterface-sourcedestcheck
            /// </summary>
			public Union<bool?, IntrinsicFunction> SourceDestCheck { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-network-interface.html#cfn-awsec2networkinterface-subnetid
            /// </summary>
			public Union<string, IntrinsicFunction> SubnetId { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-network-interface.html#cfn-awsec2networkinterface-tags
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
