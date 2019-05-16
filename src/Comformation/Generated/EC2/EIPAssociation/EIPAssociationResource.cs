using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.EIPAssociation
{
    /// <summary>
    /// AWS::EC2::EIPAssociation
    /// Associates an Elastic IP address with an instance or a network interface. 		 Before you can use an Elastic IP
    /// address, you must allocate it to your account.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-eip-association.html
    /// </summary>
    public class EIPAssociationResource : ResourceBase
    {
        public class EIPAssociationProperties
        {
            /// <summary>
            /// AllocationId
            /// [EC2-VPC] The allocation ID. This is required for EC2-VPC.
            /// Required: Conditional
            /// Type: String
            /// </summary>
			public Union<string, IntrinsicFunction> AllocationId { get; set; }

            /// <summary>
            /// EIP
            /// The Elastic IP address to associate with the instance. This is required for EC2-Classic.
            /// Required: Conditional
            /// Type: String
            /// </summary>
			public Union<string, IntrinsicFunction> EIP { get; set; }

            /// <summary>
            /// InstanceId
            /// The ID of the instance. This is required for EC2-Classic. For EC2-VPC, you can specify either the
            /// instance ID or the network interface ID, but not both. The operation fails if you specify an
            /// instance ID unless exactly one network interface is attached.
            /// Required: Conditional
            /// Type: String
            /// </summary>
			public Union<string, IntrinsicFunction> InstanceId { get; set; }

            /// <summary>
            /// NetworkInterfaceId
            /// [EC2-VPC] The ID of the network interface. If the instance has more than one network interface, you
            /// must specify a network interface ID.
            /// 	
            /// For EC2-VPC, you can specify either the instance ID or the network interface ID, but not both.
            /// Required: Conditional
            /// Type: String
            /// </summary>
			public Union<string, IntrinsicFunction> NetworkInterfaceId { get; set; }

            /// <summary>
            /// PrivateIpAddress
            /// [EC2-VPC] The primary or secondary private IP address to associate with the Elastic IP address. If
            /// no private IP address is specified, the Elastic IP address is associated with the primary private IP
            /// address.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> PrivateIpAddress { get; set; }

        }

        public string Type { get; } = "AWS::EC2::EIPAssociation";

        public EIPAssociationProperties Properties { get; } = new EIPAssociationProperties();

    }
}
