using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.NetworkInterfaceAttachment
{
    /// <summary>
    /// AWS::EC2::NetworkInterfaceAttachment
    /// Attaches an elastic network interface (ENI) to an Amazon EC2 instance. You can use this resource type to
    /// attach additional network interfaces to an instances without interruption.
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-network-interface-attachment.html
    /// </summary>
    public class NetworkInterfaceAttachmentResource : ResourceBase
    {
        public class NetworkInterfaceAttachmentProperties
        {
            /// <summary>
            /// DeleteOnTermination
            /// Whether to delete the network interface when the instance terminates. By default, this value is set
            /// to True.
            /// Required: No
            /// Type: Boolean.
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-network-interface-attachment.html#cfn-ec2-network-interface-attachment-deleteonterm
            /// </summary>
			public Union<bool, IntrinsicFunction> DeleteOnTermination { get; set; }

            /// <summary>
            /// DeviceIndex
            /// The network interface's position in the attachment order. For example, the first attached network
            /// interface has a DeviceIndex of 0.
            /// Required: Yes.
            /// Type: String.
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-network-interface-attachment.html#cfn-ec2-network-interface-attachment-deviceindex
            /// </summary>
			public Union<string, IntrinsicFunction> DeviceIndex { get; set; }

            /// <summary>
            /// InstanceId
            /// The ID of the instance to which you will attach the ENI.
            /// Required: Yes.
            /// Type: String.
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-network-interface-attachment.html#cfn-ec2-network-interface-attachment-instanceid
            /// </summary>
			public Union<string, IntrinsicFunction> InstanceId { get; set; }

            /// <summary>
            /// NetworkInterfaceId
            /// The ID of the ENI that you want to attach.
            /// Required: Yes.
            /// Type: String.
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-network-interface-attachment.html#cfn-ec2-network-interface-attachment-networkinterfaceid
            /// </summary>
			public Union<string, IntrinsicFunction> NetworkInterfaceId { get; set; }

        }
    
        public string Type { get; } = "AWS::EC2::NetworkInterfaceAttachment";
        
        public NetworkInterfaceAttachmentProperties Properties { get; } = new NetworkInterfaceAttachmentProperties();
    }
}
