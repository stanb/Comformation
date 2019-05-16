using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.FSx.FileSystem
{
    /// <summary>
    /// AWS::FSx::FileSystem
    /// The AWS::FSx::FileSystem resource is an Amazon FSx resource type that creates either an Amazon FSx for Windows
    /// File Server file system or an Amazon FSx for Lustre file system.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-fsx-filesystem.html
    /// </summary>
    public class FileSystemResource : ResourceBase
    {
        public class FileSystemProperties
        {
            /// <summary>
            /// KmsKeyId
            /// The ID of the AWS Key Management Service (AWS KMS) key used to encrypt the file system&#39;s data for an
            /// Amazon FSx for Windows File Server file system.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> KmsKeyId { get; set; }

            /// <summary>
            /// StorageCapacity
            /// The storage capacity of the file system.
            /// For Windows file systems, the storage capacity has a minimum of 300 GiB, and a maximum of 65,536
            /// GiB.
            /// For Lustre file systems, the storage capacity has a minimum of 3,600 GiB. Storage capacity is
            /// provisioned in increments of 3,600 GiB.
            /// Required: No
            /// Type: Integer
            /// Minimum: 1
            /// Update requires: Replacement
            /// </summary>
			public Union<int, IntrinsicFunction> StorageCapacity { get; set; }

            /// <summary>
            /// FileSystemType
            /// Type of file system. Currently the only supported type is WINDOWS.
            /// Required: No
            /// Type: String
            /// Allowed Values: LUSTRE | WINDOWS
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> FileSystemType { get; set; }

            /// <summary>
            /// LustreConfiguration
            /// The configuration object for Lustre file systems used in the CreateFileSystem operation.
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
            /// The IDs of the subnets to contain the endpoint for the file system. One and only one is supported.
            /// The file system is launched in the Availability Zone associated with this subnet.
            /// Required: No
            /// Type: List of String
            /// Maximum: 50
            /// Update requires: Replacement
            /// </summary>
			public List<Union<string, IntrinsicFunction>> SubnetIds { get; set; }

            /// <summary>
            /// SecurityGroupIds
            /// A list of IDs for the security groups that apply to the specified network interfaces created for
            /// file system access. These security groups will apply to all network interfaces. This list isn&#39;t
            /// returned in later describe requests.
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
            /// The configuration object for the Microsoft Windows file system you are creating.
            /// Required: No
            /// Type: WindowsConfiguration
            /// Update requires: No interruption
            /// </summary>
			public WindowsConfiguration WindowsConfiguration { get; set; }

        }

        public string Type { get; } = "AWS::FSx::FileSystem";

        public FileSystemProperties Properties { get; } = new FileSystemProperties();

    }
}
