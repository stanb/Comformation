using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.EFS.FileSystem
{
    /// <summary>
    /// AWS::EFS::FileSystem
    /// The AWS::EFS::FileSystem resource creates a new, empty file system in Amazon Elastic File System (Amazon EFS).
    /// You must create a mount target (AWS::EFS::MountTarget) to mount your Amazon EFS file system on an Amazon
    /// Elastic Compute Cloud (Amazon EC2) instance. For more information, see the CreateFileSystem API in the Amazon
    /// Elastic File System User Guide.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-efs-filesystem.html
    /// </summary>
    public class FileSystemResource : ResourceBase
    {
        public class FileSystemProperties
        {
            /// <summary>
            /// Encrypted
            /// A boolean value that, if true, creates an encrypted file system. For more information, see
            /// CreateFileSystem in the Amazon Elastic File System User Guide.
            /// Required: No
            /// Type: Boolean
            /// Update requires: Replacement
            /// </summary>
			public Union<bool, IntrinsicFunction> Encrypted { get; set; }

            /// <summary>
            /// FileSystemTags
            /// Tags to associate with the file system.
            /// Required: No
            /// Type: Amazon Elastic File System FileSystem FileSystemTags
            /// Update requires: No interruption
            /// </summary>
			public Union<List<ElasticFileSystemTag>, IntrinsicFunction> FileSystemTags { get; set; }

            /// <summary>
            /// KmsKeyId
            /// The ID of the AWS KMS customer master key (CMK) to use to protect the encrypted file system. This
            /// parameter is only required if you want to use a non-default CMK. For more information, see
            /// CreateFileSystem in the Amazon Elastic File System User Guide.
            /// Required: Conditional. This parameter is required if you use a non-default CMK.
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> KmsKeyId { get; set; }

            /// <summary>
            /// PerformanceMode
            /// The performance mode of the file system. For valid values, see the PerformanceMode parameter for the
            /// CreateFileSystem action in the Amazon Elastic File System User Guide.
            /// For more information about performance modes, see Amazon EFS Performance in the Amazon Elastic File
            /// System User Guide.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> PerformanceMode { get; set; }

            /// <summary>
            /// ProvisionedThroughputInMibps
            /// The throughput, measured in MiB/s, that you want to provision for a file system that you&#39;re
            /// creating. The limit on throughput is 1024 MiB/s. You can get these limits increased by contacting
            /// AWS Support. For more information, see Amazon EFS Limits That You Can Increase in the Amazon Elastic
            /// File System User Guide.
            /// Valid Range: Minimum value of 0. 0.
            /// Required: No
            /// Type: Double
            /// Update requires: No interruption
            /// </summary>
			public Union<double, IntrinsicFunction> ProvisionedThroughputInMibps { get; set; }

            /// <summary>
            /// ThroughputMode
            /// The throughput mode for the file system to be created. There are two throughput modes to choose from
            /// for your file system: bursting and provisioned. You can decrease your file system&#39;s throughput in
            /// Provisioned Throughput mode or change between the throughput modes as long as it’s been more than 24
            /// hours since the last decrease or throughput mode change.
            /// Valid Values: bursting and provisioned.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> ThroughputMode { get; set; }

        }
    
        public string Type { get; } = "AWS::EFS::FileSystem";
        
        public FileSystemProperties Properties { get; } = new FileSystemProperties();
    }
}
