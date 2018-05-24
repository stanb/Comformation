using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.NetworkInterfaceAttachment
{
    /// <summary>
    ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-network-interface-attachment.html
    /// </summary>
    public class NetworkInterfaceAttachmentResource : ResourceBase
    {
        public class NetworkInterfaceAttachmentProperties
        {
            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-network-interface-attachment.html#cfn-ec2-network-interface-attachment-deleteonterm
            /// </summary>
			public Union<bool?, IntrinsicFunction> DeleteOnTermination { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-network-interface-attachment.html#cfn-ec2-network-interface-attachment-deviceindex
            /// </summary>
			public Union<string, IntrinsicFunction> DeviceIndex { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-network-interface-attachment.html#cfn-ec2-network-interface-attachment-instanceid
            /// </summary>
			public Union<string, IntrinsicFunction> InstanceId { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-network-interface-attachment.html#cfn-ec2-network-interface-attachment-networkinterfaceid
            /// </summary>
			public Union<string, IntrinsicFunction> NetworkInterfaceId { get; set; }

        }
    
        public string Type { get; } = "AWS::EC2::NetworkInterfaceAttachment";
        
        public NetworkInterfaceAttachmentProperties Properties { get; } = new NetworkInterfaceAttachmentProperties();
    }
}
