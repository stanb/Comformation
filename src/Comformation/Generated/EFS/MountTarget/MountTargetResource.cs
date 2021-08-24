using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.EFS.MountTarget
{
    /// <summary>
    /// AWS::EFS::MountTarget
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-efs-mounttarget.html
    /// </summary>
    public class MountTargetResource : ResourceBase
    {
        public class MountTargetProperties
        {
            /// <summary>
            /// FileSystemId
            /// The ID of the file system for which to create the mount target.
            /// Required: Yes
            /// Type: String
            /// Maximum: 128
            /// Pattern:
            /// ^(arn:aws[-a-z]*:elasticfilesystem:[0-9a-z-:]+:file-system/fs-[0-9a-f]{8,40}|fs-[0-9a-f]{8,40})$
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> FileSystemId { get; set; }

            /// <summary>
            /// IpAddress
            /// Valid IPv4 address within the address range of the specified subnet.
            /// Required: No
            /// Type: String
            /// Minimum: 7
            /// Maximum: 15
            /// Pattern: ^[0-9]{1,3}\. [0-9]{1,3}\. [0-9]{1,3}\. [0-9]{1,3}$
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> IpAddress { get; set; }

            /// <summary>
            /// SecurityGroups
            /// Up to five VPC security group IDs, of the form sg-xxxxxxxx. These must be for the same VPC as subnet
            /// specified.
            /// Required: Yes
            /// Type: List of String
            /// Maximum: 5
            /// Update requires: No interruption
            /// </summary>
            public List<Union<string, IntrinsicFunction>> SecurityGroups { get; set; }

            /// <summary>
            /// SubnetId
            /// The ID of the subnet to add the mount target in. For file systems that use One Zone storage classes,
            /// use the subnet that is associated with the file system&#39;s Availability Zone.
            /// Required: Yes
            /// Type: String
            /// Minimum: 15
            /// Maximum: 47
            /// Pattern: ^subnet-[0-9a-f]{8,40}$
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> SubnetId { get; set; }

        }

        public string Type { get; } = "AWS::EFS::MountTarget";

        public MountTargetProperties Properties { get; } = new MountTargetProperties();

    }

    public static class MountTargetAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> IpAddress = new ResourceAttribute<Union<string, IntrinsicFunction>>("IpAddress");
    }
}
