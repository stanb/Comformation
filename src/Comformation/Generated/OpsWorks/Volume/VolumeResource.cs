using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.OpsWorks.Volume
{
    /// <summary>
    /// AWS::OpsWorks::Volume
    /// The AWS::OpsWorks::Volume resource registers an Amazon Elastic Block Store (Amazon EBS) volume with an AWS
    /// OpsWorks stack.
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-opsworks-volume.html
    /// </summary>
    public class VolumeResource : ResourceBase
    {
        public class VolumeProperties
        {
            /// <summary>
            /// Ec2VolumeId
            /// The ID of the Amazon EBS volume to register with the AWS OpsWorks stack.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-opsworks-volume.html#cfn-opsworks-volume-ec2volumeid
            /// </summary>
			public Union<string, IntrinsicFunction> Ec2VolumeId { get; set; }

            /// <summary>
            /// MountPoint
            /// The mount point for the Amazon EBS volume, such as /mnt/disk1.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-opsworks-volume.html#cfn-opsworks-volume-mountpoint
            /// </summary>
			public Union<string, IntrinsicFunction> MountPoint { get; set; }

            /// <summary>
            /// Name
            /// A name for the Amazon EBS volume.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-opsworks-volume.html#cfn-opsworks-volume-name
            /// </summary>
			public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            /// StackId
            /// The ID of the AWS OpsWorks stack that AWS OpsWorks registers the volume to.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-opsworks-volume.html#cfn-opsworks-volume-stackid
            /// </summary>
			public Union<string, IntrinsicFunction> StackId { get; set; }

        }
    
        public string Type { get; } = "AWS::OpsWorks::Volume";
        
        public VolumeProperties Properties { get; } = new VolumeProperties();
    }
}
