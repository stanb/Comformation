using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.FSx.FileSystem
{
    /// <summary>
    /// AWS::FSx::FileSystem
    /// The AWS::FSx::FileSystem resource creates a new Amazon FSx file system. You must specify the type Amazon FSx
    /// file system to create, Microsoft Windows (WindowsConfiguration) or Lustre (LustreConfiguration). For more
    /// information, see CreateFileSystem in the Amazon FSx API Reference.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-fsx-filesystem.html
    /// </summary>
    public class FileSystemResource : ResourceBase
    {
        public class FileSystemProperties
        {
            /// <summary>
            /// KmsKeyId
            /// The ID of the AWS Key Management Service (AWS KMS) key used to encrypt the file system&#39;s data for an
            /// Amazon FSx for Windows File Server file system. For more information, see CreateFileSystem in the
            /// Amazon FSx API Reference.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> KmsKeyId { get; set; }

            /// <summary>
            /// StorageCapacity
            /// The storage capacity of the file system. For Windows file systems, the storage capacity has a
            /// minimum of 300 GiB, and a maximum of 65,536 GiB. For Lustre file systems, the storage capacity has a
            /// minimum of 3,600 GiB, and is provisioned in increments of 3,600 GiB. For more information, see
            /// StorageCapacity in the Amazon FSx API Reference.
            /// Required: No
            /// Type: Integer
            /// Update requires: Replacement
            /// </summary>
			public Union<int, IntrinsicFunction> StorageCapacity { get; set; }

            /// <summary>
            /// FileSystemType
            /// The type of file system. For more information, see FileSystem in the Amazon FSx API Reference.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> FileSystemType { get; set; }

            /// <summary>
            /// LustreConfiguration
            /// The configuration for the Amazon FSx for Lustre file system. For more information, see
            /// LustreFileSystemConfiguration in the Amazon FSx API Reference.
            /// Required: No
            /// Type: LustreConfiguration
            /// Update requires: No interruption
            /// </summary>
			public LustreConfiguration LustreConfiguration { get; set; }

            /// <summary>
            /// BackupId
            /// The ID of the backup of an Amazon FSx for Windows File Server file system. For more information, see
            /// CreateBackup in the Amazon FSx API Reference.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> BackupId { get; set; }

            /// <summary>
            /// SubnetIds
            /// A list of IDs for the subnets that the file system will be accessible from. File systems support
            /// only one subnet. The file server is also launched in that subnet&#39;s Availability Zone. For more
            /// information, see SubnetIds in the Amazon FSx API Reference.
            /// Required: No
            /// Type: List of String values
            /// Update requires: Replacement
            /// </summary>
			public List<Union<string, IntrinsicFunction>> SubnetIds { get; set; }

            /// <summary>
            /// SecurityGroupIds
            /// A list of IDs for the security groups that apply to the specified network interfaces created for
            /// file system access. These security groups apply to all network interfaces. This list isn&#39;t returned
            /// in later describe requests.
            /// Required: No
            /// Type: List of String values
            /// Update requires: Replacement
            /// </summary>
			public List<Union<string, IntrinsicFunction>> SecurityGroupIds { get; set; }

            /// <summary>
            /// Tags
            /// The tags to be applied to the file system at file system creation. The key value of the Name tag
            /// appears in the console as the file system name. For more information, see Tags in the Amazon FSx API
            /// Reference.
            /// Required: No
            /// Type: List of Resource Tag property types
            /// Update requires: No interruption
            /// </summary>
			public List<TagEntry> Tags { get; set; }

            /// <summary>
            /// WindowsConfiguration
            /// The configuration for a Microsoft Windows file system. For more information, see
            /// WindowsFileSystemConfiguration in the Amazon FSx API Reference.
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
