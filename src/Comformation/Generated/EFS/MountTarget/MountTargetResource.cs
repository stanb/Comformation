using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.EFS.MountTarget
{
    /// <summary>
    /// AWS::EFS::MountTarget
    /// The AWS::EFS::MountTarget resource is an Amazon EFS resource that creates a mount target for an EFS file
    /// system. You can then mount the file system on Amazon EC2 instances or other resources by using the mount
    /// target.
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
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> FileSystemId { get; set; }

            /// <summary>
            /// IpAddress
            /// Valid IPv4 address within the address range of the specified subnet.
            /// Required: No
            /// Type: String
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
            /// The ID of the subnet to add the mount target in.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> SubnetId { get; set; }

        }

        public string Type { get; } = "AWS::EFS::MountTarget";

        public MountTargetProperties Properties { get; } = new MountTargetProperties();

    }
}
