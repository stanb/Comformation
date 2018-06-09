using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.EIPAssociation
{
    /// <summary>
    /// AWS::EC2::EIPAssociation
    /// The AWS::EC2::EIPAssociation resource type associates an Elastic IP address with an Amazon EC2 instance. The
    /// Elastic IP address can be an existing Elastic IP address or an Elastic IP address allocated through an
    /// AWS::EC2::EIP resource.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-eip-association.html
    /// </summary>
    public class EIPAssociationResource : ResourceBase
    {
        public class EIPAssociationProperties
        {
            /// <summary>
            /// AllocationId
            /// [EC2-VPC] Allocation ID for the VPC Elastic IP address you want to associate with an Amazon EC2
            /// instance in your VPC.
            /// Required: Conditional. Required for EC2-VPC.
            /// Type: String
            /// Update requires: Replacement if you also change the InstanceId or NetworkInterfaceId property. If
            /// not, update requires No interruption.
            /// </summary>
			public Union<string, IntrinsicFunction> AllocationId { get; set; }

            /// <summary>
            /// EIP
            /// Elastic IP address that you want to associate with the Amazon EC2 instance specified by the
            /// InstanceId property. You can specify an existing Elastic IP address or a reference to an Elastic IP
            /// address allocated with a AWS::EC2::EIP resource.
            /// Required: Conditional. Required for EC2-Classic.
            /// Type: String
            /// Update requires: Replacement if you also change the InstanceId or NetworkInterfaceId property. If
            /// not, update requires No interruption.
            /// </summary>
			public Union<string, IntrinsicFunction> EIP { get; set; }

            /// <summary>
            /// InstanceId
            /// Instance ID of the Amazon EC2 instance that you want to associate with the Elastic IP address
            /// specified by the EIP property. If the instance has more than one network interface, you must specify
            /// a network interface ID.
            /// Required: Conditional. If you specify the EIP property, you must specify this property. If you
            /// specify the AllocationId property, you must specify this property or the NetworkInterfaceId
            /// property.
            /// Type: String
            /// Update requires: Replacement if you also change the AllocationId or EIP property. If not, update
            /// requires No interruption.
            /// </summary>
			public Union<string, IntrinsicFunction> InstanceId { get; set; }

            /// <summary>
            /// NetworkInterfaceId
            /// [EC2-VPC] The ID of the network interface to associate with the Elastic IP address. If the instance
            /// has more than one network interface, you must specify a network interface ID.
            /// Required: Conditional. If you specify the AllocationId property, you must specify this property or
            /// the InstanceId property.
            /// Type: String
            /// Update requires: Replacement if you also change the AllocationId or EIP property. If not, update
            /// requires No interruption.
            /// </summary>
			public Union<string, IntrinsicFunction> NetworkInterfaceId { get; set; }

            /// <summary>
            /// PrivateIpAddress
            /// [EC2-VPC] The private IP address that you want to associate with the Elastic IP address. The private
            /// IP address is restricted to the primary and secondary private IP addresses that are associated with
            /// the network interface. By default, the private IP address that is associated with the EIP is the
            /// primary private IP address of the network interface.
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
