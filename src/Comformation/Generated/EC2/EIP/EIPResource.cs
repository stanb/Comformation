using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.EIP
{
    /// <summary>
    /// AWS::EC2::EIP
    /// The AWS::EC2::EIP resource allocates an Elastic IP (EIP) address and can, optionally, associate it with an
    /// Amazon EC2 instance.
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-eip.html
    /// </summary>
    public class EIPResource : ResourceBase
    {
        public class EIPProperties
        {
            /// <summary>
            /// Domain
            /// Set to vpc to allocate the address to your Virtual Private Cloud (VPC). No other values are
            /// supported.
            /// Note If you define an Elastic IP address and associate it with a VPC that is defined in the same
            /// template, you must declare a dependency on the VPC-gateway attachment by using the DependsOn
            /// attribute on this resource. For more information, see DependsOn Attribute.
            /// For more information, see AllocateAddress in the Amazon EC2 API Reference. For more information
            /// about Elastic IP Addresses in VPC, go to IP Addressing in Your VPC in the Amazon VPC User Guide.
            /// Required: Conditional. Required when allocating an address to a VPC
            /// Type: String
            /// Update requires: Replacement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-eip.html#cfn-ec2-eip-domain
            /// </summary>
			public Union<string, IntrinsicFunction> Domain { get; set; }

            /// <summary>
            /// InstanceId
            /// The Instance ID of the Amazon EC2 instance that you want to associate with this Elastic IP address.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-eip.html#cfn-ec2-eip-instanceid
            /// </summary>
			public Union<string, IntrinsicFunction> InstanceId { get; set; }

        }
    
        public string Type { get; } = "AWS::EC2::EIP";
        
        public EIPProperties Properties { get; } = new EIPProperties();
    }

	public static class EIPAttributes
	{
        public static readonly ResourceAttribute<string> AllocationId = new ResourceAttribute<string>("AllocationId");
	}
}
