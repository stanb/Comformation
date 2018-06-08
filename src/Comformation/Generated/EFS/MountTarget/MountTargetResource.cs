using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.EFS.MountTarget
{
    /// <summary>
    /// AWS::EFS::MountTarget
    /// The AWS::EFS::MountTarget resource creates a mount target for an Amazon Elastic File System (Amazon EFS) file
    /// system (AWS::EFS::FileSystem). Use the mount target to mount file systems on Amazon Elastic Compute Cloud
    /// (Amazon EC2) instances.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-efs-mounttarget.html
    /// </summary>
    public class MountTargetResource : ResourceBase
    {
        public class MountTargetProperties
        {
            /// <summary>
            /// FileSystemId
            /// The ID of the file system for which you want to create the mount target.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// Before updating this property, stop EC2 instances that are using this mount target, and then restart
            /// them after the update is complete. This allows the instances to unmount the file system before the
            /// mount target is replaced. If you don't stop and restart them, instances or applications that are
            /// using those mounts might be disrupted when the mount target is deleted (uncommitted writes might be
            /// lost).
            /// </summary>
			public Union<string, IntrinsicFunction> FileSystemId { get; set; }

            /// <summary>
            /// IpAddress
            /// An IPv4 address that is within the address range of the subnet that is specified in the SubnetId
            /// property. If you don't specify an IP address, Amazon EFS automatically assigns an address that is
            /// within the range of the subnet.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// Before updating this property, stop EC2 instances that are using this mount target, and then restart
            /// them after the update is complete. This allows the instances to unmount the file system before the
            /// mount target is replaced. If you don't stop and restart them, instances or applications that are
            /// using those mounts might be disrupted when the mount target is deleted (uncommitted writes might be
            /// lost).
            /// </summary>
			public Union<string, IntrinsicFunction> IpAddress { get; set; }

            /// <summary>
            /// SecurityGroups
            /// A maximum of five VPC security group IDs that are in the same VPC as the subnet that is specified in
            /// the SubnetId property. For more information about security groups and mount targets, see Security in
            /// the Amazon Elastic File System User Guide.
            /// Required: Yes
            /// Type: List of String values
            /// Update requires: No interruption
            /// </summary>
			public Union<List<string>, IntrinsicFunction> SecurityGroups { get; set; }

            /// <summary>
            /// SubnetId
            /// The ID of the subnet in which you want to add the mount target.
            /// Note For each file system, you can create only one mount target per Availability Zone (AZ). All EC2
            /// instances in an AZ share a single mount target for a file system. If you create multiple mount
            /// targets for a single file system, do not specify a subnet that is an AZ that already has a mount
            /// target associated with the same file system.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// Before updating this property, stop EC2 instances that are using this mount target and then restart
            /// them after the update is complete. That way the instances can unmount the file system before the
            /// mount target is replaced. If you don't stop and restart them, instances or applications that are
            /// using those mounts might be disrupted when the mount target is deleted (uncommitted writes might be
            /// lost).
            /// </summary>
			public Union<string, IntrinsicFunction> SubnetId { get; set; }

        }
    
        public string Type { get; } = "AWS::EFS::MountTarget";
        
        public MountTargetProperties Properties { get; } = new MountTargetProperties();
    }
}
