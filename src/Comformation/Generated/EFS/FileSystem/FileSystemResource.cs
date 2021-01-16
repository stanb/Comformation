using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.EFS.FileSystem
{
    /// <summary>
    /// AWS::EFS::FileSystem
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-efs-filesystem.html
    /// </summary>
    public class FileSystemResource : ResourceBase
    {
        public class FileSystemProperties
        {
            /// <summary>
            /// Encrypted
            /// A Boolean value that, if true, creates an encrypted file system. When creating an encrypted file
            /// system, you have the option of specifying a KmsKeyId for an existing AWS Key Management Service (AWS
            /// KMS) customer master key (CMK). If you don&#39;t specify a CMK, then the default CMK for Amazon EFS,
            /// /aws/elasticfilesystem, is used to protect the encrypted file system.
            /// Required: Conditional
            /// Type: Boolean
            /// Update requires: Replacement
            /// </summary>
            public Union<bool, IntrinsicFunction> Encrypted { get; set; }

            /// <summary>
            /// FileSystemTags
            /// A value that specifies to create one or more tags associated with the file system. Each tag is a
            /// user-defined key-value pair. Name your file system on creation by including a
            /// &quot;Key&quot;:&quot;Name&quot;,&quot;Value&quot;:&quot;{value}&quot; key-value pair.
            /// Required: No
            /// Type: List of ElasticFileSystemTag
            /// Update requires: No interruption
            /// </summary>
            public List<ElasticFileSystemTag> FileSystemTags { get; set; }

            /// <summary>
            /// KmsKeyId
            /// The ID of the AWS KMS customer master key (CMK) to be used to protect the encrypted file system.
            /// This parameter is only required if you want to use a nondefault CMK. If this parameter is not
            /// specified, the default CMK for Amazon EFS is used. This ID can be in one of the following formats:
            /// Key ID - A unique identifier of the key, for example 1234abcd-12ab-34cd-56ef-1234567890ab. ARN - An
            /// Amazon Resource Name (ARN) for the key, for example
            /// arn:aws:kms:us-west-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab. Key alias - A
            /// previously created display name for a key, for example alias/projectKey1. Key alias ARN - An ARN for
            /// a key alias, for example arn:aws:kms:us-west-2:444455556666:alias/projectKey1.
            /// If KmsKeyId is specified, the Encrypted parameter must be set to true.
            /// Required: No
            /// Type: String
            /// Maximum: 2048
            /// Pattern:
            /// ^([0-9a-f]{8}-[0-9a-f]{4}-[0-9a-f]{4}-[0-9a-f]{4}-[0-9a-f]{12}|alias/[a-zA-Z0-9/_-]+|(arn:aws[-a-z]*:kms:[a-z0-9-]+:\d{12}:((key/[0-9a-f]{8}-[0-9a-f]{4}-[0-9a-f]{4}-[0-9a-f]{4}-[0-9a-f]{12})|(alias/[a-zA-Z0-9/_-]+))))$
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> KmsKeyId { get; set; }

            /// <summary>
            /// LifecyclePolicies
            /// A list of policies used by EFS lifecycle management to transition files to the Infrequent Access
            /// (IA) storage class.
            /// Required: No
            /// Type: List of LifecyclePolicy
            /// Update requires: No interruption
            /// </summary>
            public List<LifecyclePolicy> LifecyclePolicies { get; set; }

            /// <summary>
            /// PerformanceMode
            /// The performance mode of the file system. We recommend generalPurpose performance mode for most file
            /// systems. File systems using the maxIO performance mode can scale to higher levels of aggregate
            /// throughput and operations per second with a tradeoff of slightly higher latencies for most file
            /// operations. The performance mode can&#39;t be changed after the file system has been created.
            /// Required: No
            /// Type: String
            /// Allowed values: generalPurpose | maxIO
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> PerformanceMode { get; set; }

            /// <summary>
            /// ProvisionedThroughputInMibps
            /// The throughput, measured in MiB/s, that you want to provision for a file system that you&#39;re
            /// creating. Valid values are 1-1024. Required if ThroughputMode is set to provisioned. The upper limit
            /// for throughput is 1024 MiB/s. You can get this limit increased by contacting AWS Support. For more
            /// information, see Amazon EFS Limits That You Can Increase in the Amazon EFS User Guide.
            /// Required: Conditional
            /// Type: Double
            /// Update requires: No interruption
            /// </summary>
            public Union<double, IntrinsicFunction> ProvisionedThroughputInMibps { get; set; }

            /// <summary>
            /// ThroughputMode
            /// The throughput mode for the file system to be created. There are two throughput modes to choose from
            /// for your file system: bursting and provisioned. If you set ThroughputMode to provisioned, you must
            /// also set a value for ProvisionedThroughPutInMibps. You can decrease your file system&#39;s throughput in
            /// Provisioned Throughput mode or change between the throughput modes as long as it’s been more than 24
            /// hours since the last decrease or throughput mode change. For more, see Specifying Throughput with
            /// Provisioned Mode in the Amazon EFS User Guide.
            /// Required: No
            /// Type: String
            /// Allowed values: bursting | provisioned
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> ThroughputMode { get; set; }

            /// <summary>
            /// FileSystemPolicy
            /// The FileSystemPolicy for the EFS file system. A file system policy is an IAM resource policy used to
            /// control NFS access to an EFS file system. For more information, see Using IAM to Control NFS Access
            /// to Amazon EFS in the Amazon EFS User Guide.
            /// Required: No
            /// Type: Json
            /// Update requires: No interruption
            /// </summary>
            public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> FileSystemPolicy { get; set; }

            /// <summary>
            /// BackupPolicy
            /// Use the BackupPolicy to turn automatic backups on or off for the file system.
            /// Required: No
            /// Type: BackupPolicy
            /// Update requires: No interruption
            /// </summary>
            public BackupPolicy BackupPolicy { get; set; }

        }

        public string Type { get; } = "AWS::EFS::FileSystem";

        public FileSystemProperties Properties { get; } = new FileSystemProperties();

    }

    public static class FileSystemAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> FileSystemId = new ResourceAttribute<Union<string, IntrinsicFunction>>("FileSystemId");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
    }
}
