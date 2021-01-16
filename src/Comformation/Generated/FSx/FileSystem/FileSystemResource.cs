using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.FSx.FileSystem
{
    /// <summary>
    /// AWS::FSx::FileSystem
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-fsx-filesystem.html
    /// </summary>
    public class FileSystemResource : ResourceBase
    {
        public class FileSystemProperties
        {
            /// <summary>
            /// StorageType
            /// Sets the storage type for the file system you&#39;re creating. Valid values are SSD and HDD.
            /// Set to SSD to use solid state drive storage. SSD is supported on all Windows and Lustre deployment
            /// types. Set to HDD to use hard disk drive storage. HDD is supported on SINGLE_AZ_2 and MULTI_AZ_1
            /// Windows file system deployment types, and on PERSISTENT Lustre file system deployment types.
            /// Default value is SSD. For more information, see Storage Type Options in the Amazon FSx for Windows
            /// User Guide and Multiple Storage Options in the Amazon FSx for Lustre User Guide.
            /// Required: No
            /// Type: String
            /// Allowed values: HDD | SSD
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> StorageType { get; set; }

            /// <summary>
            /// KmsKeyId
            /// The ID of the AWS Key Management Service (AWS KMS) key used to encrypt the file system&#39;s data for
            /// Amazon FSx for Windows File Server file systems and persistent Amazon FSx for Lustre file systems at
            /// rest. In either case, if not specified, the Amazon FSx managed key is used. The scratch Amazon FSx
            /// for Lustre file systems are always encrypted at rest using Amazon FSx managed keys. For more
            /// information, see Encrypt in the AWS Key Management Service API Reference.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> KmsKeyId { get; set; }

            /// <summary>
            /// StorageCapacity
            /// Sets the storage capacity of the file system that you&#39;re creating. StorageCapacity is required if
            /// you are creating a new file system. Do not include StorageCapacity if you are creating a file system
            /// from a backup.
            /// For Lustre file systems:
            /// For SCRATCH_2 and PERSISTENT_1 SSD deployment types, valid values are 1200 GiB, 2400 GiB, and
            /// increments of 2400 GiB. For PERSISTENT HDD file systems, valid values are increments of 6000 GiB for
            /// 12 MB/s/TiB file systems and increments of 1800 GiB for 40 MB/s/TiB file systems. For SCRATCH_1
            /// deployment type, valid values are 1200 GiB, 2400 GiB, and increments of 3600 GiB.
            /// For Windows file systems:
            /// If StorageType=SSD, valid values are 32 GiB - 65,536 GiB (64 TiB). If StorageType=HDD, valid values
            /// are 2000 GiB - 65,536 GiB (64 TiB).
            /// Required: Conditional
            /// Type: Integer
            /// Minimum: 0
            /// Maximum: 2147483647
            /// Update requires: No interruption
            /// </summary>
            public Union<int, IntrinsicFunction> StorageCapacity { get; set; }

            /// <summary>
            /// FileSystemType
            /// The type of Amazon FSx file system, either LUSTRE or WINDOWS.
            /// Required: Yes
            /// Type: String
            /// Allowed values: LUSTRE | WINDOWS
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> FileSystemType { get; set; }

            /// <summary>
            /// LustreConfiguration
            /// The Lustre configuration for the file system being created.
            /// Required: No
            /// Type: LustreConfiguration
            /// Update requires: No interruption
            /// </summary>
            public LustreConfiguration LustreConfiguration { get; set; }

            /// <summary>
            /// BackupId
            /// The ID of the backup. Specifies the backup to use if you&#39;re creating a file system from an existing
            /// backup.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> BackupId { get; set; }

            /// <summary>
            /// SubnetIds
            /// Specifies the IDs of the subnets that the file system will be accessible from. For Windows
            /// MULTI_AZ_1 file system deployment types, provide exactly two subnet IDs, one for the preferred file
            /// server and one for the standby file server. You specify one of these subnets as the preferred subnet
            /// using the WindowsConfiguration &amp;gt; PreferredSubnetID property.
            /// For Windows SINGLE_AZ_1 and SINGLE_AZ_2 file system deployment types and Lustre file systems,
            /// provide exactly one subnet ID. The file server is launched in that subnet&#39;s Availability Zone.
            /// Required: Yes
            /// Type: List of String
            /// Maximum: 50
            /// Update requires: Replacement
            /// </summary>
            public List<Union<string, IntrinsicFunction>> SubnetIds { get; set; }

            /// <summary>
            /// SecurityGroupIds
            /// A list of IDs specifying the security groups to apply to all network interfaces created for file
            /// system access. This list isn&#39;t returned in later requests to describe the file system.
            /// Required: No
            /// Type: List of String
            /// Maximum: 50
            /// Update requires: Replacement
            /// </summary>
            public List<Union<string, IntrinsicFunction>> SecurityGroupIds { get; set; }

            /// <summary>
            /// Tags
            /// An array of key-value pairs to apply to this resource.
            /// For more information, see Tag.
            /// Required: No
            /// Type: List of Tag
            /// Maximum: 50
            /// Update requires: No interruption
            /// </summary>
            public List<Tag> Tags { get; set; }

            /// <summary>
            /// WindowsConfiguration
            /// The configuration object for the Microsoft Windows file system you are creating. This value is
            /// required if FileSystemType is set to WINDOWS.
            /// Required: Conditional
            /// Type: WindowsConfiguration
            /// Update requires: No interruption
            /// </summary>
            public WindowsConfiguration WindowsConfiguration { get; set; }

        }

        public string Type { get; } = "AWS::FSx::FileSystem";

        public FileSystemProperties Properties { get; } = new FileSystemProperties();

    }

    public static class FileSystemAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> LustreMountName = new ResourceAttribute<Union<string, IntrinsicFunction>>("LustreMountName");
    }
}
