using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.VolumeAttachment
{
    /// <summary>
    /// AWS::EC2::VolumeAttachment
    /// Attaches an Amazon EBS volume to a running instance and exposes it to the instance with the specified device
    /// name.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ebs-volumeattachment.html
    /// </summary>
    public class VolumeAttachmentResource : ResourceBase
    {
        public class VolumeAttachmentProperties
        {
            /// <summary>
            /// Device
            /// How the device is exposed to the instance (e. g. , /dev/sdh, or xvdh).
            /// Required: Yes
            /// Type: String
            /// Update requires: Updates are not supported.
            /// </summary>
			public Union<string, IntrinsicFunction> Device { get; set; }

            /// <summary>
            /// InstanceId
            /// The ID of the instance to which the volume attaches. This value can be a reference to an
            /// AWS::EC2::Instance resource, or it can be the physical ID of an existing EC2 instance.
            /// Required: Yes
            /// Type: String
            /// Update requires: Updates are not supported.
            /// </summary>
			public Union<string, IntrinsicFunction> InstanceId { get; set; }

            /// <summary>
            /// VolumeId
            /// The ID of the Amazon EBS volume. The volume and instance must be within the same Availability Zone.
            /// This value can be a reference to an AWS::EC2::Volume resource, or it can be the volume ID of an
            /// existing Amazon EBS volume.
            /// Required: Yes
            /// Type: String
            /// Update requires: Updates are not supported.
            /// </summary>
			public Union<string, IntrinsicFunction> VolumeId { get; set; }

        }

        public string Type { get; } = "AWS::EC2::VolumeAttachment";

        public VolumeAttachmentProperties Properties { get; } = new VolumeAttachmentProperties();

    }
}
